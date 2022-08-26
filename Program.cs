static int cuadrado(int x){
    return x * x;
}

static float division(float a, float b) {
    return a/b;
}

static float kilomLitro(float k, float l) {

}

/* try
{
    System.Console.WriteLine("1. Ingrese un númnero");
    int num = Convert.ToInt32(Console.ReadLine());
    
    num = cuadrado(num);
    
    Console.WriteLine(num);
}
catch (FormatException)
{
    Console.WriteLine("Error: Fordmato incorrecto");
    // throw;
}
catch (OverflowException)
{
    Console.WriteLine("Error: Desbordamiento");
    // throw;
}
catch (System.Exception e)
{
    Console.WriteLine("Error: "+ e.Message );
    // throw;
} */
try
{
	    System.Console.WriteLine("1. Ingrese el primer número: ");
	    float a = float.Parse(Console.ReadLine());
	    System.Console.WriteLine("2. Ingrese el segundo número: ");
	    float b = float.Parse(Console.ReadLine());
	    System.Console.WriteLine($"El resultado es: {division(a,b)}");
}
catch (System.Exception)
{
	
	throw;
}
