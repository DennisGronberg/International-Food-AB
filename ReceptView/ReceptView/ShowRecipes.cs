﻿using System;
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
        #region Constructor

        Recipes recipe = new Recipes();

        public ShowRecipes()
        {
            InitializeComponent();
            cbCategory.SelectedIndex = 0;
            fillList(recipe.Read());
        }

        #endregion

        private void cmdAddRecipe_Click(object sender, EventArgs e)
        {
            AddRecipe frm = new AddRecipe();
            frm.Show();
        }

        private void cmdShowRecipe_Click(object sender, EventArgs e)
        {
            // ladda lstShowRecipe
        }

        public void fillList(List<Recipes> list)
        {
            lstRecipes.Items.Clear();
            foreach (Recipes recipe in list)
            {
                lstRecipes.Items.Add(recipe.Title);
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillList(recipe.Search(txtSearch.Text, cbCategory.SelectedItem.ToString()));
        }
    }
}
