using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ReadJson.Model;

namespace ReadJson
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hola Mundo");

      // Ruta del archivo. Debe colocarlo en la carpeta bin\Debug para que la ruta de ejecucion sea correcta.
      string file = @".\geo-data.json";

      // Declaracion de variable que tendra las GeoComparaciones List es un tipo lista, y entre los < > se puede especificar cualquier tipo para indicar
      // una lista de 'cosas', por ejemplo se puede hacer una lista de textos... List<string> 
      var listaComparaciones = new List<GeoComparison>();

      // Lectura del archivo y serializacion de Json a Objetos C#
      using(StreamReader r = new StreamReader(file))
      {
        string json = r.ReadToEnd();
        listaComparaciones = JsonConvert.DeserializeObject<List<GeoComparison>>(json);
      }

      // 800144757
      // 900276152

      // Ejemplo de lectura de una combinatoria especifica
      var x = listaComparaciones.First(pedro => (pedro.Source.Nit == "900276152" && pedro.Target.Nit == "800144757") || (pedro.Source.Nit == "800144757" && pedro.Target.Nit == "900276152"));


      // Comando para leer una tecla de la consola: lo usamos simplemente para detener la ejecucion pero se puede guardar el resultado en una variable si se quiere
      Console.ReadKey();

      // Ciclo que imprime las comparaciones
      foreach(var comparacion in listaComparaciones)
      {
        Console.WriteLine(comparacion.Source.Nit);
        Console.WriteLine(comparacion.Target.Nit);
        Console.WriteLine(comparacion.Geo.DistanceText);
        Console.WriteLine("-------------------------------------------------");
      }

      Console.ReadKey();
    }
  }
}
