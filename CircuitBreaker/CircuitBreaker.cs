using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace CircuitBreaker
{
	public delegate void ChangedStateEventHandler(object sender, CircuitBreakerState state);

	/// <summary>
	/// Inspired by https://github.com/davybrion/CircuitBreaker/
	/// </summary>
	public class CircuitBreaker : ICircuitBreaker
	{
		private readonly object monitor = new object();
		private Exception exceptionFromLastAttemptCall = null;
		private CircuitBreakerState state;

		public CircuitBreaker()
		{
			this.Threshold = 3;
			this.Timeout = TimeSpan.FromSeconds(20);
			this.MoveToClosedState();
		}

		public CircuitBreaker(int threshold, TimeSpan timeout)
		{
			if (threshold < 1)
			{
				throw new ArgumentOutOfRangeException(nameof(threshold), "Threshold should be greater than 0");
			}

			if (timeout.TotalMilliseconds < 1)
			{
				throw new ArgumentOutOfRangeException(nameof(timeout), "Timeout should be greater than 0");
			}

			this.Threshold = threshold;
			this.Timeout = timeout;
			this.MoveToClosedState();
		}

		public event Action<object, CircuitBreakerState> OnStateChange;

		public int Failures { get; private set; }
		public bool IsClosed => this.state.Update() is ClosedState;
		public bool IsHalfOpen => this.state.Update() is HalfOpenState;
		public bool IsOpen => this.state.Update() is OpenState;
		public int Threshold { get; }
		public TimeSpan Timeout { get; }

		/// <summary>
		/// Call the stage change event
		/// </summary>
		/// <param name="state"></param>
		private void NotifyStateChange(CircuitBreakerState state)
		{
			this.OnStateChange?.Invoke(this, state);
		}

		internal void IncreaseFailureCount()
		{
			this.Failures++;
			Console.WriteLine($"CB: Number of failures: {Failures}");
		}

		internal CircuitBreakerState MoveToClosedState()
		{
			Console.WriteLine("CB: Move to closed state...");
			this.state = new ClosedState(this);
			this.NotifyStateChange(this.state);
			return this.state;
		}

		internal CircuitBreakerState MoveToHalfOpenState()
		{
			Console.WriteLine("CB: Move to half-open state...");
			this.state = new HalfOpenState(this);
			this.NotifyStateChange(this.state);
			return this.state;
		}

		internal CircuitBreakerState MoveToOpenState()
		{
			Console.WriteLine("CB: Move to open state...");
			this.state = new OpenState(this);
			this.NotifyStateChange(this.state);
			return this.state;
		}

		internal void ResetFailureCount()
		{
			this.Failures = 0;
		}

		/// <summary>
		/// This should be used as followed :
		/// myCircuitBreaker.AttemptCall(()=&gt;{yourCode();}).IsClosed?"AllFine":"Something wrong";
		/// </summary>
		/// <param name="protectedCode"></param>
		/// <returns></returns>
		public async Task<CircuitBreaker> AttemptCallAsync(Func<Task> protectedCode)
		{
			this.exceptionFromLastAttemptCall = null;
			lock (this.monitor)
			{
				this.state.ProtectedCodeIsAboutToBeCalled();
				if (this.state is OpenState)
				{
					return this; // Stop execution of this method
				}
			}

			try
			{
				Console.WriteLine("CB: Protected code is going to be called.");
				await protectedCode.Invoke().ConfigureAwait(false);
			}
			catch (BrokenCircuitException e)
			{
				this.exceptionFromLastAttemptCall = e;
				lock (this.monitor)
				{
					this.state.ActUponException(e);
				}
				return this; // Stop execution of this method
			}

			lock (this.monitor)
			{
				state.ProtectedCodeHasBeenCalled();
			}
			return this;
		}


		public CircuitBreaker AttemptCall(Func<Task> protectedCode)
		{
			this.exceptionFromLastAttemptCall = null;
			lock (this.monitor)
			{
				this.state.ProtectedCodeIsAboutToBeCalled();
				if (this.state is OpenState)
				{
					return this; // Stop execution of this method
				}
			}

			try
			{
				Console.WriteLine("CB: Protected code is going to be called.");
				protectedCode.Invoke();
			}
			catch (BrokenCircuitException e)
			{
				this.exceptionFromLastAttemptCall = e;
				lock (this.monitor)
				{
					this.state.ActUponException(e);
				}
				return this; // Stop execution of this method
			}

			lock (this.monitor)
			{
				state.ProtectedCodeHasBeenCalled();
			}
			return this;
		}

		public void Close()
		{
			lock (this.monitor)
			{
				this.MoveToClosedState();
			}
		}

		public Exception GetExceptionFromLastAttemptCall()
		{
			return this.exceptionFromLastAttemptCall;
		}

		public bool IsThresholdReached()
		{
			return this.Failures >= this.Threshold;
		}

		public void Open()
		{
			lock (this.monitor)
			{
				this.MoveToOpenState();
			}
		}
	}
}