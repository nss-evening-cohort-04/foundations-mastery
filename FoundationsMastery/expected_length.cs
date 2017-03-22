using System;
using System.Runtime.Serialization;

namespace FoundationsMastery
{
    [Serializable]
    internal class expected_length : Exception
    {
        public expected_length()
        {
        }

        public expected_length(string message) : base(message)
        {
        }

        public expected_length(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected expected_length(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}