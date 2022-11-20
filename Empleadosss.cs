using System;

class Empleadosss : Persona
{
    
    public int Año_incorporación{ get; set;}
    public int N_Despacho{ get; set;}
    
    public Empleadosss(int Id, string Nombre, string Apellido, string Estado_Civil , int Año_incorporación, int N_Despacho) 
    : base (Id, Nombre, Apellido, Estado_Civil)

   {
        this.Año_incorporación = Año_incorporación;
        this.N_Despacho = N_Despacho;  
   }
   
   public void ImprimirEmpleados()
   {
    Console.WriteLine( "el año de incorporacion IS: " + Año_incorporación + 
        "\n Numero de Despacho IS: " + N_Despacho);
   }

}