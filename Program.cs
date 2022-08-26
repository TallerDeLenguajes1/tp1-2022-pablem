static int cuadrado(int x){
    return x * x;
}

try
{
    int num = Convert.ToInt32(Console.ReadLine());
    
    num = cuadrado(num);
    
    Console.WriteLine(num);
}
catch (FormatException e)
{
    Console.WriteLine("Error: "+ e.Message );
    // throw;
}
catch (OverflowException e)
{
    Console.WriteLine("Error: "+ e.Message );
    // throw;
}
catch (System.Exception e)
{
    Console.WriteLine("Error: "+ e.Message );
    // throw;
}