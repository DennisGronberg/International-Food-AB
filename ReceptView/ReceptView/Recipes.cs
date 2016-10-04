using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceptView
{
    //public enum Category { Kött, Fisk, Sallader, Soppa, Dessert }
    
    public class Recipes
    {
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Author { get; set; }
        public string Instructions { get; set; }
        public string Category { get; set; }
        List<Recipes> list = new List<Recipes>();
        ReadAndWrite rw = new ReadAndWrite();



        public bool ContainsInfo(string title, string author)
        {
            if (title.Trim().Equals("") || author.Trim().Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
        public void Create(string title, string ingredients, string author, string instructions, string category)
        {
            list.Add(new Recipes { Title = title, Ingredients = ingredients, Author = author, Category = category, Instructions = instructions });
            rw.WriteToFile(title, ingredients, author, instructions, category);
        }

        public List<Recipes> Read()
        {
            return list = rw.ReadToList();
        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}