using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceptView
{
    public class Recipes
    {
        #region Properties

        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Author { get; set; }
        public string Instructions { get; set; }
        public string Category { get; set; }

        #endregion

        #region Constructor

        ReadAndWrite rnw = new ReadAndWrite();
        List<Recipes> list = new List<Recipes>();
        List<Recipes> results = new List<Recipes>();

        #endregion

        #region Methods

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
            rnw.WriteToFile(title, ingredients, author, instructions, category);
        }

        public List<Recipes> Read(string searchText, string category)
        {
            list = rnw.ReadToList();
            if (category == "Alla")
            {
                results = list.Where(x => x.Title.Contains(searchText)).ToList();
            }
            else
            {
                results = list.Where(x => x.Title.Contains(searchText) && x.Category == category).ToList();
            }
            return results;
        }

        #endregion

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}