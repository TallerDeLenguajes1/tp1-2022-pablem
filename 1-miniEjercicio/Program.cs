using System.Net;
using System.Text;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // Para poder visualizar el caracter infinito

        //Plantilla menu principal:
        string? opcion;
        do {
            Console.Clear();
            Console.WriteLine("\n¿Qué operación desea realizar?\n");
            Console.WriteLine("(C)uadrado   (D)ivisión   (K)ilometros/litro   (P)rovincias   (S)alir\n");
            try {
                opcion = Console.ReadLine()!.ToLower();
            }
            catch (Exception) {
                opcion = "z";
            }
            if (opcion == "c")
                cuadrado();
            if (opcion == "d")
                division();
            if (opcion == "k")
                kilometroLitro();
            if (opcion == "p")
                provincias();
        } while (opcion != "s");
              
        static void cuadrado() // En este método uso excepciones derivadas
        {
            System.Console.WriteLine("\n-- FUNCION CUADRADO --\n");
            System.Console.WriteLine("Ingrese un númnero:");
            try {
                int x = Convert.ToInt32(Console.ReadLine());
                x *= x;
                System.Console.WriteLine($"\nEl resultado es: {x}");
            }
            catch (FormatException) {
                Console.WriteLine("Error: Fordmato incorrecto");
            }
            catch (OverflowException) {
                Console.WriteLine("Error: Desbordamiento");
            }
            catch (System.Exception e) {
                Console.WriteLine("Error General: "+ e.Message );
            }
            finally {
                Console.WriteLine("\n(presine enter)");
                Console.ReadKey();
            }
        }

        static void division() // En este método uso atributos: message, inner exception y stack trace 
        {
            float? a, b;
            Console.WriteLine("\n-- FUNCION DIVISION --\n");
            Console.WriteLine("Ingrese el primer número: ");
            try {
                a = float.Parse(Console.ReadLine()!);
                Console.WriteLine("Ingrese el segundo número: ");
                b = float.Parse(Console.ReadLine()!);
                a=a/b;
                Console.WriteLine($"El resultado es: {a}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n[Error al dividir] " + e.Message);                 // Qué ha sucedido
                if(e.InnerException != null )                           
                    Console.WriteLine("\nInner exception: " + e.InnerException.Message); // Llamadas internas 
                Console.WriteLine($"\n[Error al dividir] " + e.StackTrace);              // Dónde ha sucedido
            }
            finally {
                Console.WriteLine("\n(presine enter)");
                Console.ReadKey();
            } 
        }

        static void kilometroLitro() // En este método uso excepciones definidas por el usuario (yo)
        {
            float? k, li;
            bool ban = true;

            var exc = new NegativeNumberException("No puede ingresar cero o números negativos.");

            do
            {
                Console.WriteLine("\n-- CALCULAR Km/L --\n");
                Console.WriteLine("Kilometros conducidos: ");
                try {
                    k = float.Parse(Console.ReadLine()!);
                    if (k<=0)
                        throw exc;

                    Console.WriteLine("Litros usados ");
                    li = float.Parse(Console.ReadLine()!);
                    if (li<=0)
                        throw exc;

                    k=k/li;
                    Console.WriteLine($"El resultado es: {k}");
                    ban = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n[Error al calcular] " + e.Message);                // Qué ha sucedido
                    if(e.InnerException != null )                           
                        Console.WriteLine("\nInner exception: " + e.InnerException.Message); // Llamadas internas 
                    Console.WriteLine($"\n[Error al calcular] " + e.StackTrace);             // Dónde ha sucedido
                }
            } while (ban);
            
            Console.WriteLine("\n(presine enter)");
            Console.ReadKey();
             
        }

        static void provincias() 
        {
            Console.WriteLine("\n-- MOSTRAR PROVINCIAS --\n");

            var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ProvinciasArgentina ListaProvincias = JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);
                            foreach (Provincia Prov in ListaProvincias.Provincias) {
                                Console.WriteLine("id: " + Prov.Id + " Nombre: " + Prov.Nombre);
                            }
                        }
                    }
                }
            }
            catch (WebException)
            {
                Console.WriteLine("Problemas de acceso a la API");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally 
            {
                Console.WriteLine("\n(presine enter)");
                Console.ReadKey();
            }   
        }  
    //FIN DE Main 
    }
}