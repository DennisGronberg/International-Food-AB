namespace ReceptView
{
    partial class ShowRecipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddRecipe = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.lstShowRecipe = new System.Windows.Forms.ListBox();
            this.cmdShowRecipe = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recept";
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Location = new System.Drawing.Point(361, 294);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.cmdAddRecipe.TabIndex = 1;
            this.cmdAddRecipe.Text = "Lägg till";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            this.cmdAddRecipe.Click += new System.EventHandler(this.cmdAddRecipe_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Kött",
            "Fisk",
            "Sallad",
            "Soppa",
            "Dessert"});
            this.cbCategory.Location = new System.Drawing.Point(12, 33);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.Location = new System.Drawing.Point(12, 60);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(121, 225);
            this.lstRecipes.TabIndex = 3;
            // 
            // lstShowRecipe
            // 
            this.lstShowRecipe.FormattingEnabled = true;
            this.lstShowRecipe.Location = new System.Drawing.Point(140, 60);
            this.lstShowRecipe.Name = "lstShowRecipe";
            this.lstShowRecipe.Size = new System.Drawing.Size(296, 225);
            this.lstShowRecipe.TabIndex = 4;
            // 
            // cmdShowRecipe
            // 
            this.cmdShowRecipe.Location = new System.Drawing.Point(12, 294);
            this.cmdShowRecipe.Name = "cmdShowRecipe";
            this.cmdShowRecipe.Size = new System.Drawing.Size(75, 23);
            this.cmdShowRecipe.TabIndex = 5;
            this.cmdShowRecipe.Text = "Visa";
            this.cmdShowRecipe.UseVisualStyleBackColor = true;
            this.cmdShowRecipe.Click += new System.EventHandler(this.cmdShowRecipe_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(139, 36);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 13);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(183, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(280, 294);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 8;
            this.cmdDelete.Text = "Ta bort";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // ShowRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 324);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmdShowRecipe);
            this.Controls.Add(this.lstShowRecipe);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cmdAddRecipe);
            this.Controls.Add(this.label1);
            this.Name = "ShowRecipes";
            this.ShowIcon = false;
            this.Text = "International Food AB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAddRecipe;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.ListBox lstShowRecipe;
        private System.Windows.Forms.Button cmdShowRecipe;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button cmdDelete;
    }
}

