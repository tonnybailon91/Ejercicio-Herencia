using System;

class Profesor : Persona
{
    public string Depa_N1{ get; set;}
    

    public Profesor (int Id, string Nombre, string Apellido, string Estado_Civil, string Depa_N1)
    : base(Id, Nombre, Apellido, Estado_Civil)
    {
        this.Depa_N1 = Depa_N1;
        
    }

    public void imprimirProfesor()
    {
        Console.WriteLine("el Departamento asignado IS: " + Depa_N1);
    }
}

