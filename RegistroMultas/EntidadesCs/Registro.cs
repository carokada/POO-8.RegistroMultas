using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public static class Registro
   {
      private static List<Multa> multas = new List<Multa>();

      public static void AddMulta(Multa multa)
      {
         if (multa == null)
            throw new ArgumentException(" la multa no puede ser nula.");
         if (multas.Contains(multa))
            throw new ArgumentException(" la multa ya esta en la lista multas.");
         multas.Add(multa);
      }

      public static List<Multa> GetAllMultas()
      {
         return multas;
      }

      public static List<Multa> GetMultasByMultado(IMultado multado)
      {
         List<Multa> multasByMultado = new List<Multa>();

         foreach (var multa in multas)
         {
            if (multa.Vehiculo == multado || multa.Vehiculo.Propietario == multado)
            {
               multasByMultado.Add(multa);
            }
         }
         return multasByMultado;
      }

      public static List<Propietario> GetAllPropietariosMultados()
      {
         List<Propietario> propietariosMultados = new List<Propietario>();

         foreach (var multa in multas)
         {
            if (!propietariosMultados.Contains(multa.Vehiculo.Propietario))
               propietariosMultados.Add(multa.Vehiculo.Propietario);
         }
         return propietariosMultados;
      }

      public static Persona GetPersonaByDni(uint dni)
      {
         string stringDni = dni.ToString();
         foreach (var multa in multas)
         {

            if (multa.Vehiculo.Propietario is Persona persona)// verifica que propietarios sea tipo persona y lo guarda en la var "persona"
            {
               if (persona.Dni == stringDni) // si coinciden los dni devuelve la persona 
               {
                  Console.Write(" persona encontrada -> ");
                  return persona;
               }
            }
         }
         Console.WriteLine(" no se encontraron coincidencias segun los datos ingresados");
         return null;
      }
   }
}
