using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptView
{
    public class ReadAndWrite
    {
        public void WriteToFile()
        {
            string path = ("C:\\Grupparbete");
            if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            if (!File.Exists(path + "\\Recept.txt"))
            {
                StreamWriter sw = new StreamWriter(path,true);
                try { 
                sw = new StreamWriter(path + "\\Recept.txt");
                sw.Write("Recept");
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    sw.Close();
                }

            }
            

        }
        public List<Recipes> Read()
        {

        }
    }
}
