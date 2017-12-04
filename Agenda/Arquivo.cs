using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Agenda
{
    public static class Arquivo
    {
        public static void Salvar(string caminho, string arquivo, object list)
        {
            VerificarDiretorio(ref caminho);

            Stream stream = File.Open(caminho + arquivo, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, list);

            stream.Dispose();
        }
        public static object Ler(string caminho, string arquivo)
        {
            VerificarDiretorio(ref caminho);

            Stream stream = File.Open(caminho + arquivo, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            object obj = formatter.Deserialize(stream);

            stream.Dispose();

            return obj;
        }
        private static void VerificarDiretorio(ref string caminho)
        {
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
            if (!caminho.EndsWith(@"\"))
                caminho += @"\";
        }
    }
}
