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
        string path = ("C:\\Grupparbete");

        public void WriteToFile()
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (!File.Exists(path + "\\Recept.txt"))
            {
                StreamWriter sw = new StreamWriter(path, true);
                try
                {
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

        public List<Recipes> ReadToList()
        {
            List<Recipes> recipeList = new List<Recipes>();
            StreamReader reader = new StreamReader(path + "\\Recept.txt");
            try
            {
                string row = reader.ReadLine();
                while (row != null)
                {
                    string[] value = row.Split('|');
                    recipeList.Add(new Recipes { Title = value[0], Author = value[1], Category = value[2], Ingredients = value[3], Instructions = value[4] });
                    row = reader.ReadLine();
                }
                return recipeList;
            }
            catch(Exception ex)
            {
                string test = ex.StackTrace;
                /* väldigt mycket fel */
                recipeList = new List<Recipes>();
                return recipeList;
            }
            finally { reader.Close(); }




        }

    }
}
