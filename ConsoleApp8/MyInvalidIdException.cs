using System.Runtime.Serialization;

namespace ConsoleApp8
{
    [Serializable]
    public class MyInvalidIdException : Exception
    {
        public MyInvalidIdException()
        {
        }

        public MyInvalidIdException(string? message) : base(message)
        {
        }

        public MyInvalidIdException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MyInvalidIdException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}