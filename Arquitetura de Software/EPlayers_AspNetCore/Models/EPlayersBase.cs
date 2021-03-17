using System.Collections.Generic;
using System.IO;

namespace EPlayers_AspNetCore.Models
{
    public abstract class EPlayersBase
    {
        public void CreateFolderAndFile(string path)
        {
            // Database/Equipe.csv
            string folder = path.Split("/")[0];

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(path))
            {
                File.Create(path);
            }
        }


        public List<string> ReadAllLinesCSV(string path)
        {
            List<string> linhas = new List<string>();

            // using => Abrir e fechar determinado tipo de arquivo ou conexão
            // StreamReader -> Ler as informações do meu CSV
            using (StreamReader file = new StreamReader(path))
            {
                string linha;
                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }

            return linhas;
        }

        public void RewriteCSV(string path, List<string> linhas)
        {
            // StreamWriter -> Escrita de arquivos
            using (StreamWriter output = new StreamWriter(path))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + '\n');
                }
            }
        }
    }
}