public class NegativeNumberException : Exception
{
    public NegativeNumberException()
    {
    }

    public NegativeNumberException(string message) : base(message)
    {
    }

    public NegativeNumberException(string message, Exception inner) : base(message, inner)
    {
    }

    // protected NegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
    // {
    // }
    
}