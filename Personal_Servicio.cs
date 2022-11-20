using System;

class Personal_Servicio : Persona
{
    public string seccion1{ get; set;}
    

    public Personal_Servicio(int Id, string Nombre, string Apellido, string Estado_Civil, string seccion1)
    : base(Id, Nombre, Apellido, Estado_Civil)
    {
        this.seccion1= seccion1;
        

    }

    public void imprimirPersonal_Servicio()
    {
        Console.WriteLine("La seccion asignada Is: " +seccion1);
        
    }
}