using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesCs
{
   public class Multa
   {
      private Vehiculo vehiculo;

      private DateTime fecha;
      private decimal latitud;
      private decimal longitud;
      private ushort unidades;
      public static decimal MontoUnidad { get; set; }

      public Multa(Vehiculo vehiculo, DateTime fecha, decimal latitud, decimal longitud)
      {
         Fecha = fecha;
         Latitud = latitud;
         Longitud = longitud;
         Vehiculo = vehiculo;

         Registro.AddMulta(this);
      }

      public Multa(Vehiculo vehiculo, DateTime fecha, decimal latitud, decimal longitud, ushort unidades) : this(vehiculo, fecha, latitud, longitud)
      {
         Unidades = unidades;
      }

      public DateTime Fecha
      {
         get => fecha;
         set => fecha = value <= DateTime.Now ? value : throw new ArgumentException(" la fecha no puede ser mayor a la del sistema.");
      }

      public decimal Latitud
      {
         get => latitud;
         set => latitud = (value >= -90 && value <= 90) ? value : throw new ArgumentException(" la latitud debe ser un valor entre -90 y 90");
      }

      public decimal Longitud
      {
         get => longitud;
         set => longitud = (value >= -180 && value <= 180) ? value : throw new ArgumentException(" la longitud debe ser un valor entre -180 y 180");
      }

      public ushort Unidades
      {
         get => unidades;
         set => unidades = value > 0 ? value : throw new ArgumentException(" las unidades no pueden ser un valor menor a cero.");
      }

      public Vehiculo Vehiculo
      {
         get => vehiculo;
         set
         {
            vehiculo = value ?? throw new ArgumentException(" el vehiculo no puede estar vacio.");
            if (!vehiculo.multas.Contains(this))
               vehiculo.AddMulta(this);
         }
      }

      public decimal CalcularMonto()
      {
         return unidades * MontoUnidad;
      }

      public override string ToString()
      {
         return $" {Vehiculo} ->\t [{Fecha}]\t ${CalcularMonto()}";
      }
   }
}
