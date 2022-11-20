using System;

class Persona
{
    
    public int Id{ get; set;}
    public string Nombre{ get; set;}
    public string Apellido{ get; set;}
    public string Estado_Civil{ get; set;}


    public Persona (int Id, string Nombre, string Apellido, string Estado_Civil)
    {
        this.Id= Id;
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Estado_Civil = Estado_Civil;
    }


    public void imprimirPersona()
    {
        Console.WriteLine("\nEl numero de identificacion IS: " + Id
        + "\n El nombre IS " + Nombre
        + "\n El apellido IS: "+  Apellido
        + "\n El estado civil IS: " + Estado_Civil);
    }
    
}
