using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceptView
{
    public enum Category { Kött, Fisk, Sallader, Soppa, Dessert }
    
    public class Recipes
    {
        public string Title { get; set; }
        public List<string> Ingredients { get; set; }
        public string Author { get; set; }
        public string Instructions { get; set; }
        public Category Category { get; set; }
        ////List<Recipes>



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
        
        public void Create()
        {

        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}