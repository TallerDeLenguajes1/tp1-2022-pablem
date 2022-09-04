public class Empleado
{
    string dni;
    string nombre;
    string apellido;
    DateTime fechaNac;
    string direccion;
    string cargo;
    DateTime fechaIngreso;

    static float sueldoBasico;

    public string Dni { get => dni; set => dni = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Cargo { get => cargo; set => cargo = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public static float SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }

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
    


}