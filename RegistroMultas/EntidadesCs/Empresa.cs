using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Empresa : Propietario
   {
      private string cuit;

      public Empresa (string nombre, string cuit) : base(nombre)
      {
         Cuit = cuit;
      }

      public string Cuit
      {
         get => cuit;
         set => cuit = value.Length == 13 ? value : throw new ArgumentException(" el cuit debe tener 13 caracteres.");
      }

      public override string ToString()
      {
         return $"{Nombre} (CUIT: {Cuit})";
      }
   }
}
