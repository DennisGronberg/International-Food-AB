namespace ReceptView
{
    partial class AddRecipe
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
            this.lblInputRecipe = new System.Windows.Forms.Label();
            this.txtInputRecipe = new System.Windows.Forms.TextBox();
            this.cmdSaveRecipe = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtInstructions = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputRecipe
            // 
            this.lblInputRecipe.AutoSize = true;
            this.lblInputRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lblInputRecipe.Location = new System.Drawing.Point(23, 158);
            this.lblInputRecipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputRecipe.Name = "lblInputRecipe";
            this.lblInputRecipe.Size = new System.Drawing.Size(77, 15);
            this.lblInputRecipe.TabIndex = 0;
            this.lblInputRecipe.Text = "Input recipe :";
            // 
            // txtInputRecipe
            // 
            this.txtInputRecipe.Location = new System.Drawing.Point(22, 182);
            this.txtInputRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInputRecipe.Multiline = true;
            this.txtInputRecipe.Name = "txtInputRecipe";
            this.txtInputRecipe.Size = new System.Drawing.Size(116, 202);
            this.txtInputRecipe.TabIndex = 1;
            // 
            // cmdSaveRecipe
            // 
            this.cmdSaveRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.cmdSaveRecipe.Location = new System.Drawing.Point(22, 398);
            this.cmdSaveRecipe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSaveRecipe.Name = "cmdSaveRecipe";
            this.cmdSaveRecipe.Size = new System.Drawing.Size(90, 26);
            this.cmdSaveRecipe.TabIndex = 2;
            this.cmdSaveRecipe.Text = "Save recipe";
            this.cmdSaveRecipe.UseVisualStyleBackColor = true;
            this.cmdSaveRecipe.Click += new System.EventHandler(this.cmdSaveRecipe_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Kött ",
            "Fisk ",
            "Sallader ",
            "Soppa ",
            "Dessert"});
            this.cbCategory.Location = new System.Drawing.Point(123, 72);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(94, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lblCategory.Location = new System.Drawing.Point(20, 72);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(90, 15);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Food category :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lblAuthor.Location = new System.Drawing.Point(23, 110);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(48, 15);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Author :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(123, 106);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(94, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtInstructions
            // 
            this.txtInstructions.Location = new System.Drawing.Point(172, 182);
            this.txtInstructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInstructions.Multiline = true;
            this.txtInstructions.Name = "txtInstructions";
            this.txtInstructions.Size = new System.Drawing.Size(124, 202);
            this.txtInstructions.TabIndex = 8;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lblInstructions.Location = new System.Drawing.Point(170, 158);
            this.lblInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(105, 15);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "Input instructions :";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(123, 37);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(94, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.lblRecipeName.Location = new System.Drawing.Point(20, 37);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(97, 15);
            this.lblRecipeName.TabIndex = 9;
            this.lblRecipeName.Text = "Name of recipe :";
            // 
            // AddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 448);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.txtInstructions);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cmdSaveRecipe);
            this.Controls.Add(this.txtInputRecipe);
            this.Controls.Add(this.lblInputRecipe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddRecipe";
            this.Text = "AddRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputRecipe;
        private System.Windows.Forms.TextBox txtInputRecipe;
        private System.Windows.Forms.Button cmdSaveRecipe;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblRecipeName;
    }
}