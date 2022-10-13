public class Empleado
{
    string dni;
    string nombre;
    string apellido;
    DateTime fechaNac;
    string direccion;
    DateTime fechaIngreso;

    static float sueldoBasico;

    bool casado, hijos, titulo; //?
    int cantHijos;              //?

    public Empleado(string dni, string nombre, string apellido, DateTime fechaNac, string direccion, DateTime fechaIngreso)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNac = fechaNac;
        this.direccion = direccion;
        this.fechaIngreso = fechaIngreso;
    }

    public string Dni { get => dni; set => dni = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public static float SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public bool Casado { get => casado; set => casado = value; }
    public bool Hijos { get => hijos; set => hijos = value; }
    public bool Titulo { get => titulo; set => titulo = value; }
    public int CantHijos { get => cantHijos; set => cantHijos = value; }

    public int Antiguedad()
    {
        var fechaAux = new DateTime(DateTime.Today.Year, fechaIngreso.Month, fechaIngreso.Day);
        return (DateTime.Today - fechaAux).Days >= 0 ? DateTime.Today.Year - fechaIngreso.Year : DateTime.Today.Year - fechaIngreso.Year - 1;
    }

    public int Edad()
    {
        var fechaAux = new DateTime(DateTime.Today.Year, fechaNac.Month, fechaNac.Day);
        return (DateTime.Today - fechaAux).Days >= 0 ? DateTime.Today.Year - fechaNac.Year : DateTime.Today.Year - fechaNac.Year - 1;
    }

    public float Salario()
    {
        float descuento = (float)0.15*SueldoBasico;
        float adicional = (Antiguedad()>=20) ? (float)0.25 : (float)0.01*Antiguedad();
        
        return sueldoBasico*(1+adicional) - descuento;
    }

    public void Mostrar()
    {
        Console.WriteLine($"\t{Apellido}, {Nombre}.");
        Console.WriteLine("\tEdad: " + Edad() + " años.");
        Console.WriteLine("\tAntigüedad: " + Antiguedad() + " año/s.");
        Console.WriteLine("\tSalario: " + Salario() + " USDC.");
        Console.WriteLine();
    }

}