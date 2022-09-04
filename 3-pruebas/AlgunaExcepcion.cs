public class AlgunaExcepcion : Exception
{
    public AlgunaExcepcion()
    {
    }

    public AlgunaExcepcion(string message) : base(message)
    {
    }

    public AlgunaExcepcion(string message, Exception inner) : base(message, inner)
    {
    }
}