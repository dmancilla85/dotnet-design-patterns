using System;

namespace CircuitBreaker
{
	public class ClosedState : CircuitBreakerState
	{
		public ClosedState(CircuitBreaker circuitBreaker)
				: base(circuitBreaker)
		{
			circuitBreaker.ResetFailureCount();
		}

		public override void ActUponException(Exception e)
		{
			base.ActUponException(e);
			if (this.circuitBreaker.IsThresholdReached())
			{
				this.circuitBreaker.MoveToOpenState();
			}
		}
	}
}