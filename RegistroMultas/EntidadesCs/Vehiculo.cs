using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Vehiculo : IMultado
   {
      private Propietario propietario; // asoc propietario (1 vehiculo 1 propietario)
      internal List<Multa> multas; // asoc multiple multas (1 vehiculo muchas multas)

      private string patente;

      public Vehiculo(string patente)
      {
         multas = new List<Multa>();

         Patente = patente;
      }

      public string Patente
      {
         get => patente;
         set => patente = (value.Length == 6 || value.Length == 8) ? value : throw new ArgumentException(" la patente debe tener 6 u 8 catacteres.");
      }

      public Propietario Propietario
      {
         get => propietario;
         set
         {
            propietario = value ?? throw new ArgumentException(" el propietario no puede ser nulo.");
            if (!propietario.vehiculos.Contains(this))
               propietario.AddVehiculo(this);
         }  
      }

      internal void AddMulta(Multa multa)
      {
         if (multa == null)
            throw new ArgumentException(" la multa no puede ser nula.");
         if (multas.Contains(multa))
            throw new ArgumentException(" la multa ya esta en la lista multas.");
         multas.Add(multa);
      }

      public List<Multa> GetAllMultas()
      {
         return multas;         
      }

      public decimal GetTotalMultas()
      {
         decimal totalMultas = 0;
         foreach (var multa in multas)
            totalMultas += multa.CalcularMonto();
         return totalMultas;
      }

      public override string ToString()
      {
         return $"{Patente} {(Propietario != null ? $"[{Propietario.Nombre}]" : "")}";
      }
   }
}
