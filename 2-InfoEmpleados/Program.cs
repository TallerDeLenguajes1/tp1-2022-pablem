public static class Program
{
    private static void Main(string[] args)
    {
       int N = 1;
        Empleado.SueldoBasico = 10000;
        
        Console.WriteLine("\nIngrese la cantidad de empleados: ");
        try
        {
            N = Convert.ToInt32(Console.ReadLine()); 
        } 
        catch (FormatException ex)
        {
            Console.WriteLine("\n[Error al ingresar cantidad de empleados] " + ex.Message+"\n");
        }
        var listaEmpleados = new List<Empleado>();
        Empleado nuevo;
        for (int i = 0; i < N; i++)
        {
            try
            {
                Console.WriteLine($"-- EMPLEADO {i+1}/{N} --");
                Console.WriteLine("Ingrese el DNI:");
                string dni = Console.ReadLine()!;
                Console.WriteLine("Ingrese el Nombre:");
                string nom = Console.ReadLine()!;
                Console.WriteLine("Ingrese el Apellido:");
                string ap = Console.ReadLine()!;
                Console.WriteLine("Ingrese la Fecha de nacimiento: (aaaa-mm-dd)");
                DateTime fechaNac = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Ingrese la Dirección:");
                string dir = Console.ReadLine()!;
                Console.WriteLine("Ingrese la Fecha de ingreso: (aaaa-mm-dd)");
                DateTime fechaIng = Convert.ToDateTime(Console.ReadLine());
                nuevo = new Empleado(dni,nom,ap,fechaNac,dir,fechaIng);
                listaEmpleados.Add(nuevo);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n[Error al cargar datos] " + e.Message+"\n");
                i--;
            }
        }
        Console.WriteLine("\nEmpleados Cargados\n");
        int j=1;
        foreach (var emp in listaEmpleados)
        {
            Console.WriteLine($"{j++})");
            emp.Mostrar();
        }
    }
}