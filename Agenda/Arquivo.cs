using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Agenda
{
    public static class Arquivo
    {
        public static void Salvar(string caminho, string arquivo, params object[] valores)
        {
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
            if(!caminho.EndsWith(@"\"))
                caminho += @"\";
            string valoresTotal = "";
            foreach(object valor in valores)
            {
                valoresTotal += valor + "-";
            }
            StreamWriter writer = new StreamWriter(caminho + arquivo, true, Encoding.UTF8);
            writer.WriteLine(valoresTotal);
            writer.Dispose();
        }
    }
}
