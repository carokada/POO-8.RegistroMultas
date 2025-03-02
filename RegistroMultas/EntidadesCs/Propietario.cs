using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public abstract class Propietario : IMultado
   {
      internal List<Vehiculo> vehiculos; // asoc multiple vehiculo (1 propietario muchos vehiculos)

      private string nombre;

      public Propietario(string nombre)
      {
         vehiculos = new List<Vehiculo>();

         Nombre = nombre;
      }

      public string Nombre
      {
         get => nombre;
         set => nombre = value.Length > 0 ? value : throw new ArgumentException(" el nombre no puede estar vacio.");
      }

      public void AddVehiculo(Vehiculo vehiculo)
      {
         if (vehiculo == null)
            throw new ArgumentException(" el vehiculo no puede ser nulo.");
         if (vehiculos.Contains(vehiculo))
            throw new ArgumentException(" el vehiculo ya esta en la lista vehiculos.");
         vehiculos.Add(vehiculo);
         if (vehiculo.Propietario == null)
            vehiculo.Propietario = this;
      }

      public void RemoveVehiculo(Vehiculo vehiculo)
      {
         if (vehiculo == null)
            throw new ArgumentException(" el vehiculo no puede ser nulo.");
         if (!vehiculos.Contains(vehiculo))
            throw new ArgumentException(" el vehiculo no esta en la lista vehiculos.");
         vehiculos.Add(vehiculo);
      }

      public List<Vehiculo> GetAllVehiculos()
      {
         return vehiculos;
      }

      public List<Multa> GetAllMultas()
      {
         List<Multa> multasPorPropietario = new List<Multa>();

         foreach (var vehiculo in vehiculos)
         {
            foreach (var multa in vehiculo.GetAllMultas())
            {
               multasPorPropietario.Add(multa);
            }
         }
         return multasPorPropietario;
      }

      public decimal GetTotalMultas()
      {
         decimal totalMultas = 0;
         foreach (var multa in GetAllMultas())
            totalMultas += multa.CalcularMonto();
         return totalMultas;
      }
   }
}
