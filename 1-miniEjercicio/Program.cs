using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //Plantilla menu principal:
        string opcion;
        do {
            Console.Clear();
            Console.WriteLine("\n¿Qué operación desea realizar?\n");
            Console.WriteLine("\n(C)uadrado   (D)ivisión   (K)ilometros/litro   (P)rovincias   (S)alir\n");
            opcion = Console.ReadLine().ToLower();
            if (opcion == "c")
                cuadrado();
            if (opcion == "d")
                division();
            if (opcion == "d")
                cuadrado();
        } while (opcion != "s");
            
            
        static void cuadrado()
        {
            System.Console.WriteLine("\n-- FUNCION CUADRADO --\n");
            System.Console.WriteLine("\nIngrese un númnero:");
            try {
                int x = Convert.ToInt32(Console.ReadLine());
                x *= x;
                System.Console.WriteLine($"\nEl resultado es: {x}");
            }
            catch (FormatException) {
            Console.WriteLine("Error: Fordmato incorrecto");
            // throw;
            }
            catch (OverflowException) {
                Console.WriteLine("Error: Desbordamiento");
                // throw;
            }
            catch (System.Exception e) {
                Console.WriteLine("Error General: "+ e.Message );
                // throw;
            }
        }
        static void division()
        {
            float a, b;
            System.Console.WriteLine("\n-- FUNCION DIVISION --\n");
            Console.WriteLine("Ingrese el primer número: ");
            try {
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                b = float.Parse(Console.ReadLine());
                a=a/b;
                Console.WriteLine($"El resultado es: {a}");
            }
            catch (System.Exception)
            {
                
                throw;
            } 
        }
        
    //FIN DE Main 
    }
}