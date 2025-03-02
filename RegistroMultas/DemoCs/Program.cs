using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCs;

namespace DemoCs
{
   class Program
   {
      static void Main(string[] args)
      {
         string divisor = "----------------------------------------------------------";

         Console.WriteLine(divisor);
         Console.WriteLine(" estableciendo MontoUnidad...");
         Multa.MontoUnidad = 1200;
         Console.WriteLine($" MontoUnidad: ${Multa.MontoUnidad}");

         Console.WriteLine($"\n {divisor}");
         Console.WriteLine(" creando propietarios: personas...");
         Persona persona1 = new Persona("Carlos Vives", "09136842");
         Persona persona2 = new Persona("Susana Gimenez", "19294356");
         Persona persona3 = new Persona("Mercedes Sosa", "21943682");
         try
         {
            Persona persona4 = new Persona("", "34322295");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Persona persona4 = new Persona("Marcelo Tinelli", "2496538");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n mostrando personas cargadas: ");
         Console.WriteLine(persona1);
         Console.WriteLine(persona2);
         Console.WriteLine(persona3);

         Console.WriteLine($"\n {divisor}");
         Console.WriteLine(" creando propietarios: empresas...");
         Empresa empresa1 = new Empresa("California", "1234567891023");
         Empresa empresa2 = new Empresa("Todo Frio", "1234567891024");
         Empresa empresa3 = new Empresa("Electromisiones", "1234567891025");
         try
         {
            Persona persona4 = new Persona("Fravega", "12345678910213");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n mostrando empresas cargadas: ");
         Console.WriteLine(empresa1);
         Console.WriteLine(empresa2);
         Console.WriteLine(empresa3);

         Console.WriteLine($"\n {divisor}");
         Console.WriteLine(" creando vehiculos...");
         Vehiculo vehiculo1 = new Vehiculo("ABC123");
         Vehiculo vehiculo2 = new Vehiculo("ABCD1234");
         Vehiculo vehiculo3 = new Vehiculo("ABZ945");
         Vehiculo vehiculo4 = new Vehiculo("FGBV1684");
         Vehiculo vehiculo5 = new Vehiculo("GHD864");
         Vehiculo vehiculo6 = new Vehiculo("PASD8462");
         try
         {
            Vehiculo vehiculo7 = new Vehiculo("ABZ94");
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n mostrando vehiculos cargados: ");
         Console.WriteLine(vehiculo1);
         Console.WriteLine(vehiculo2);
         Console.WriteLine(vehiculo3);
         Console.WriteLine(vehiculo4);
         Console.WriteLine(vehiculo5);
         Console.WriteLine(vehiculo6);

         Console.WriteLine($"\n {divisor}");
         Console.WriteLine(" asociando propietarios y vehiculos...");
         persona1.AddVehiculo(vehiculo1);
         empresa2.AddVehiculo(vehiculo2);
         persona3.AddVehiculo(vehiculo3);
         vehiculo4.Propietario = persona2;
         vehiculo5.Propietario = empresa2;
         vehiculo6.Propietario = empresa2;

         Console.WriteLine("\n mostrando vehiculos por propietario: ");
         MostrarVehiculosPorPropietario(persona1);
         MostrarVehiculosPorPropietario(persona2);
         MostrarVehiculosPorPropietario(persona3);
         MostrarVehiculosPorPropietario(empresa1);
         MostrarVehiculosPorPropietario(empresa2);
         MostrarVehiculosPorPropietario(empresa3);

         Console.WriteLine(divisor);
         Console.WriteLine(" creando multas...");
         Multa multa1 = new Multa(vehiculo1, DateTime.Now, -90, 180);
         Multa multa2 = new Multa(vehiculo2, DateTime.Now, 90, -180);
         Multa multa3 = new Multa(vehiculo3, DateTime.Now, 15, 100);
         Multa multa4 = new Multa(vehiculo1, DateTime.Now, 62, -165, 2);
         Multa multa5 = new Multa(vehiculo2, DateTime.Now, -19, 67, 1);
         Multa multa6 = new Multa(vehiculo3, DateTime.Now, -56, -39, 3);
         Multa multa7 = new Multa(vehiculo3, DateTime.Now, -6, -10, 1);
         Multa multa8 = new Multa(vehiculo5, DateTime.Now, 81, 135, 3);
         Multa multa9 = new Multa(vehiculo6, DateTime.Now, 60, -6, 2);
         Multa multa10 = new Multa(vehiculo5, DateTime.Now, -71, 95, 5);
         try
         {
            Multa multa11 = new Multa(vehiculo3, new DateTime(2025, 5, 28), 15, 15);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Multa multa11 = new Multa(vehiculo3, DateTime.Now, -100, 150);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         try
         {
            Multa multa11 = new Multa(vehiculo3, DateTime.Now, 50, 200);
         }
         catch (Exception e)
         {
            Console.WriteLine($" !! error: {e.Message}");
         }
         Console.WriteLine("\n cargando unidades en multas...");
         multa1.Unidades = 3;
         multa2.Unidades = 2;
         multa3.Unidades = 1;
         Console.WriteLine("\n mostrando multas cargadas: ");
         Console.WriteLine(multa1);
         Console.WriteLine(multa2);
         Console.WriteLine(multa3);
         Console.WriteLine(multa4);
         Console.WriteLine(multa5);
         Console.WriteLine(multa6);
         Console.WriteLine(multa7);
         Console.WriteLine(multa8);
         Console.WriteLine(multa9);
         Console.WriteLine(multa10);

         Console.WriteLine(divisor);
         Console.WriteLine("\n mostrando multas por vehiculo: \n");
         MostrarMultasPorVehiculo(vehiculo1);
         MostrarMultasPorVehiculo(vehiculo2);
         MostrarMultasPorVehiculo(vehiculo3);
         MostrarMultasPorVehiculo(vehiculo4);
         MostrarMultasPorVehiculo(vehiculo5);
         MostrarMultasPorVehiculo(vehiculo6);
         Console.WriteLine("\n mostrando multas por propietario: \n");
         MostrarMultasPorPropietario(persona1);
         MostrarMultasPorPropietario(persona2);
         MostrarMultasPorPropietario(persona3);
         MostrarMultasPorPropietario(empresa1);
         MostrarMultasPorPropietario(empresa2);
         MostrarMultasPorPropietario(empresa3);

         Console.WriteLine(divisor);
         Console.WriteLine(" mostrando metodos de clase utilitaria Registro: \n");
         MostrarMultasEnRegistro();
         MostrarMultasPorMultado(empresa2);
         MostrarPropietariosMultados();
         Console.WriteLine(" busqueda de personas por dni:");
         Console.WriteLine(Registro.GetPersonaByDni(21943682));
         Console.WriteLine(Registro.GetPersonaByDni(15636826));

         //Console.WriteLine($"\n {divisor}");
         //Console.WriteLine("");
         //Console.WriteLine();
         Console.WriteLine(divisor);
         Console.WriteLine("\n presione una tecla para salir ");
         Console.ReadKey();
      }

      private static void MostrarVehiculosPorPropietario(Propietario propietario)
      {
         Console.WriteLine($" vehiculos de {propietario.Nombre}: ");
         foreach (var vehiculo in propietario.GetAllVehiculos())
            Console.WriteLine($"\t ~ {vehiculo}");
         Console.WriteLine($" -> total multas: {propietario.GetTotalMultas()} \n");
      }

      private static void MostrarMultasPorVehiculo(Vehiculo vehiculo)
      {
         Console.WriteLine($" multas de vehiculo {vehiculo}: ");
         foreach (var multa in vehiculo.GetAllMultas())
            Console.WriteLine($"\t ~ {multa}");
         Console.WriteLine($" -> total multas: {vehiculo.GetTotalMultas()} \n");
      }

      private static void MostrarMultasPorPropietario(Propietario propietario)
      {
         Console.WriteLine($" multas de {propietario}: ");
         foreach (var multa in propietario.GetAllMultas())
            Console.WriteLine($"\t ~ {multa}");
         Console.WriteLine($" -> total multas: {propietario.GetTotalMultas()} \n");
      }

      private static void MostrarMultasEnRegistro()
      {
         Console.WriteLine($" multas cargadas en registro: ");
         foreach (var multa in Registro.GetAllMultas())
            Console.WriteLine($"\t ~ {multa}");
         Console.WriteLine();
      }

      private static void MostrarMultasPorMultado(IMultado multado)
      {
         Console.WriteLine($" multas de {multado}: ");
         foreach (var multa in Registro.GetMultasByMultado(multado))
            Console.WriteLine($"\t ~ {multa}");
         Console.WriteLine();
      }

      private static void MostrarPropietariosMultados()
      {
         Console.WriteLine($" propietarios multados: ");
         foreach (var propietario in Registro.GetAllPropietariosMultados())
            Console.WriteLine($"\t ~ {propietario}");
         Console.WriteLine();
      }
   }
}
