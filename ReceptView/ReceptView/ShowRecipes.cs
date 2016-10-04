using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptView
{
    public partial class ShowRecipes : Form
    {
        Recipes recipe = new Recipes();
        public ShowRecipes()
        {
            InitializeComponent();
        }

        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            //Add Recipe
            AddRecipe frm = new AddRecipe();
            frm.Show();
        }

        private void cmdShowRecipe_Click(object sender, EventArgs e)
        {
            fillList(recipe.Read());
        }

        public void fillList(List<Recipes> list)
        {
            foreach (Recipes recipe in list)
            {
                lstRecipes.Items.Add(recipe.Title);
            }
        }
    }
}
