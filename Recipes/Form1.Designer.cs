namespace Recipes
{
    partial class Form1
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
            txtRecipeName = new TextBox();
            txtInstructions = new TextBox();
            btnDelete = new Button();
            btnSave = new Button();
            listBoxRecipes = new ListBox();
            txtIngredients = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(411, 53);
            txtRecipeName.Margin = new Padding(3, 4, 3, 4);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(140, 27);
            txtRecipeName.TabIndex = 7;
            // 
            // txtInstructions
            // 
            txtInstructions.Location = new Point(763, 53);
            txtInstructions.Margin = new Padding(3, 4, 3, 4);
            txtInstructions.Multiline = true;
            txtInstructions.Name = "txtInstructions";
            txtInstructions.Size = new Size(200, 300);
            txtInstructions.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(814, 361);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(604, 361);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 29);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.FormattingEnabled = true;
            listBoxRecipes.Location = new Point(61, 53);
            listBoxRecipes.Margin = new Padding(3, 4, 3, 4);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.Size = new Size(281, 204);
            listBoxRecipes.TabIndex = 14;
            listBoxRecipes.SelectedIndexChanged += listBoxRecipes_SelectedIndexChanged;
            // 
            // txtIngredients
            // 
            txtIngredients.Location = new Point(557, 53);
            txtIngredients.Margin = new Padding(3, 4, 3, 4);
            txtIngredients.Multiline = true;
            txtIngredients.Name = "txtIngredients";
            txtIngredients.Size = new Size(200, 300);
            txtIngredients.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(411, 361);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 498);
            Controls.Add(btnAdd);
            Controls.Add(txtIngredients);
            Controls.Add(listBoxRecipes);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(txtInstructions);
            Controls.Add(txtRecipeName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.TextBox txtInstructions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.TextBox txtIngredients;
        private System.Windows.Forms.Button btnAdd;
    }
}

