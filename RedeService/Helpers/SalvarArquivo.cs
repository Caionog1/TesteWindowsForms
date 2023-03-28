using Newtonsoft.Json;
using RedeService.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeService.Helpers
{
    public static class SalvarArquivo
    {
        public static bool SalvandoArquivos(List<string> listaNumeros, string path, string nomeArquivo)
        {
            try
            {
                if (File.Exists(path + @"\" +  nomeArquivo))
                {
                    File.Delete(path + @"\" + nomeArquivo);
                }

                using (var sw = File.CreateText(path + @"\" + nomeArquivo))
                {
                    foreach (var numero in listaNumeros)
                    {
                        sw.WriteLine(numero);
                    }
                    sw.Flush();
                    sw.Dispose();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("O Arquivo não foi salvo");
            }

            return false;
        }

        public static bool SalvandoArquivoJson(List<Teste> data, string pathJson)
        {
            try
            {
                if (File.Exists(pathJson))
                {
                    File.Delete(pathJson);
                }

                using (StreamWriter fl = File.CreateText(pathJson))
                {
                    JsonSerializer ser = new JsonSerializer();
                    ser.Serialize(fl,data);
                }

                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("O arquivo não foi salvo");
            }
            return false;
        }
    }
}
