using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReceptView
{
    public partial class ShowRecipes : Form
    {
        

        Recipes recipe = new Recipes();
        public ShowRecipes()
        {
            
            InitializeComponent();
            cbCategory.SelectedIndex = 0;
        }

        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            AddRecipe frm = new AddRecipe();
            frm.Show();
        }

        private void cmdShowRecipe_Click(object sender, EventArgs e)
        {
            if(cbCategory.SelectedItem == null)
            {
                cbCategory.SelectedItem = "";
            }
            fillList(recipe.Read(txtSearch.Text, cbCategory.SelectedItem.ToString()));

        }

        public void fillList(List<Recipes> list)
        {
            lstRecipes.Items.Clear();
            foreach (Recipes recipe in list)
            {
                lstRecipes.Items.Add(recipe.Title);
            }
        }
    }
}
