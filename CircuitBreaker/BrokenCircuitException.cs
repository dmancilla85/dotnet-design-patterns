using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CircuitBreaker
{
	[Serializable]
	/// <summary>
	/// BrokenCircuit Exception
	/// </summary>
	public class BrokenCircuitException : Exception
	{
    public BrokenCircuitException()
    {
    }

    public BrokenCircuitException(string message)
        : base(message)
    {
    }

    public BrokenCircuitException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    // Without this constructor, deserialization will fail
    protected BrokenCircuitException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
  }
}
