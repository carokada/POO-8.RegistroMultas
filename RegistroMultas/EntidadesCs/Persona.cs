using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Persona : Propietario
   {
      private string dni;

      public Persona (string nombre, string dni) : base(nombre)
      {
         Dni = dni;
      }

      public string Dni
      {
         get => dni;
         set => dni = value.Length == 8 ? value : throw new ArgumentException(" el dni debe tener 8 caracteres.");
      }

      public override string ToString()
      {
         return $"{Nombre} (DNI: {Dni})";
      }
   }
}
