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
    public partial class AddRecipe : Form
    {
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void cmdSaveRecipe_Click(object sender, EventArgs e)
        {
            Recipes recipe = new Recipes();
            if (recipe.ContainsInfo(txtTitle.Text, txtAuthor.Text) == true)
            {
                recipe.Create(txtTitle.Text, cbCategory.SelectedItem.ToString(), txtAuthor.Text, txtInputRecipe.Text, txtInstructions.Text);
            }
            else
            {
                MessageBox.Show("Inte tillräcklig information.");
            }
            
        }
    }
}
