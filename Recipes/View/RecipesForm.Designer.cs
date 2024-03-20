namespace Recipes.View
{
    partial class RecipesForm
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
            listBoxRecipes = new ListBox();
            textBoxIngredients = new TextBox();
            labelIngredients = new Label();
            labelInstructions = new Label();
            textBoxInstructions = new TextBox();
            buttonSave = new Button();
            textBoxRecipeName = new TextBox();
            buttonAdd = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // listBoxRecipes
            // 
            listBoxRecipes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxRecipes.FormattingEnabled = true;
            listBoxRecipes.Location = new Point(629, 12);
            listBoxRecipes.Name = "listBoxRecipes";
            listBoxRecipes.Size = new Size(159, 424);
            listBoxRecipes.TabIndex = 0;
            listBoxRecipes.SelectedIndexChanged += listBoxRecipes_SelectedIndexChanged;
            // 
            // textBoxIngredients
            // 
            textBoxIngredients.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxIngredients.Location = new Point(12, 66);
            textBoxIngredients.Multiline = true;
            textBoxIngredients.Name = "textBoxIngredients";
            textBoxIngredients.Size = new Size(611, 139);
            textBoxIngredients.TabIndex = 1;
            // 
            // labelIngredients
            // 
            labelIngredients.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelIngredients.AutoSize = true;
            labelIngredients.Location = new Point(12, 43);
            labelIngredients.Name = "labelIngredients";
            labelIngredients.Size = new Size(86, 20);
            labelIngredients.TabIndex = 2;
            labelIngredients.Text = "Ingredients:";
            // 
            // labelInstructions
            // 
            labelInstructions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelInstructions.AutoSize = true;
            labelInstructions.Location = new Point(12, 208);
            labelInstructions.Name = "labelInstructions";
            labelInstructions.Size = new Size(87, 20);
            labelInstructions.TabIndex = 4;
            labelInstructions.Text = "Instructions:";
            // 
            // textBoxInstructions
            // 
            textBoxInstructions.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxInstructions.Location = new Point(12, 231);
            textBoxInstructions.Multiline = true;
            textBoxInstructions.Name = "textBoxInstructions";
            textBoxInstructions.Size = new Size(611, 180);
            textBoxInstructions.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Location = new Point(242, 417);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(142, 29);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxRecipeName
            // 
            textBoxRecipeName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxRecipeName.Location = new Point(12, 12);
            textBoxRecipeName.Name = "textBoxRecipeName";
            textBoxRecipeName.Size = new Size(611, 27);
            textBoxRecipeName.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAdd.Location = new Point(12, 417);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(142, 29);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Location = new Point(481, 417);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(142, 29);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxRecipeName);
            Controls.Add(buttonSave);
            Controls.Add(labelInstructions);
            Controls.Add(textBoxInstructions);
            Controls.Add(labelIngredients);
            Controls.Add(textBoxIngredients);
            Controls.Add(listBoxRecipes);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxRecipes;
        private TextBox textBoxIngredients;
        private Label labelIngredients;
        private Label labelInstructions;
        private TextBox textBoxInstructions;
        private Button buttonSave;
        private TextBox textBoxRecipeName;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}