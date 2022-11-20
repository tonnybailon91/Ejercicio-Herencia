using System;

class Estudiantes : Persona
{
    public string Curso{ get; set;}

    public Estudiantes(int Id, string Nombre, string Apellido, string Estado_Civil , string Curso)
    : base(Id, Nombre, Apellido, Estado_Civil )
    {
        this.Curso = Curso;
    }

    public void imprimirEstudiantes()
    {
        Console.WriteLine("el curso matriculado IS: "+ Curso);
    }
}
