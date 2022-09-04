try
{
    Console.WriteLine("\nIngrese un número:");
    int h = Convert.ToInt16(Console.ReadLine());
}
catch (Exception ex)
{
    // throw;
    // throw new AlgunaExcepcion("mensaje de error 1", ex);
    // throw new AlgunaExcepcion("mensaje de error 2");
    // throw ex;
}

Console.WriteLine("\n-- Segunda Parte --\n");

FuncionLLamadoraA();
FuncionLLamadoraB();

void FuncionLLamadoraA()
{
    Dividir(3,3);
}

void FuncionLLamadoraB()
{
    try
    {
        Dividir(3,0);
    }
    catch (Exception e)
    {
        Console.WriteLine($"\nStack Trace B: " + e.StackTrace);
    }
}

void Dividir(int a,int b)
{
    try
    {
        int c = a/b;
    }
    catch (Exception ex)
    {
        //Informar cual de las dos funciones ocasionó el error
        Console.WriteLine($"\nStack Trace: " + ex.StackTrace);
        throw;
    }
}


