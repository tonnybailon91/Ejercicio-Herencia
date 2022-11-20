internal class Program
{
    private static void Main(string[] args)
    {
    
        Persona per = new Persona (1234567890, "Tonny", "Santana", "Soltero");
        per.imprimirPersona();
        
        Empleadosss emp = new Empleadosss(0, "", "", "", 1991, 35);
        emp.ImprimirEmpleados();

        Estudiantes est = new Estudiantes(1, "", "", "", "programacion");
        est.imprimirEstudiantes();

        Personal_Servicio per_se = new Personal_Servicio(0, "", "", "", "biblioteca");
        per_se.imprimirPersonal_Servicio();

        Profesor prof = new Profesor (0, "", "", "", "matematicas");
        prof.imprimirProfesor();

    }
}