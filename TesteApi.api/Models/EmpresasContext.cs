using System.Collections.Generic;
using System.IO;

namespace TesteApi.api.Models
{
    public class EmpresasContext
    {
        public static List<Empresas> Listarempresas()
        {
            var empresas = new List<Empresas>();
            using (StreamReader sr = new StreamReader("Empresas.txt"))
            {
                while (!sr.EndOfStream)
                {
                    empresas.Add(new Empresas(sr.ReadLine()));
                }
                return empresas;
            }
            //A outra forma que enviei
            //using (StreamReader sr = new StreamReader("empresas.txt"))
            //{
            //    var empresas = new List<String>();
            //    while (!sr.EndOfStream)
            //    {
            //        empresas.Add((sr.ReadLine()));
            //    }
            //    return empresas;
            //}
        }
        public static void Adicionarempresas(string id)
        {
            using (StreamWriter sw = File.AppendText("Empresas.txt"))
            {
                sw.WriteLine(id);
            }
        }
    }
}
