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
        //string path = ("C:\\Grupparbete");...
        //string path = Directory.GetCurrentDirectory() + "\\RecipeDatabase.txt";
        string path = "..\\..\\..\\..\\RecipeDatabase.txt";

        public void WriteToFile(string title, string ingredients, string author, string instructions, string category)
        {
            List<string> Save = new List<string>();
            Save.Add(title);
            Save.Add(ingredients);
            Save.Add(author);
            Save.Add(instructions);
            Save.Add(category);
          
                StreamWriter sw = new StreamWriter(path,true);
                try
                {              
                foreach (string s in Save)
                {
                    sw.Write(s+"|");
                }
                
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    sw.Close();
                }

            //}

        }

        public List<Recipes> ReadToList()
        {
            List<Recipes> recipeList = new List<Recipes>();
            StreamReader reader = new StreamReader(path);
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
