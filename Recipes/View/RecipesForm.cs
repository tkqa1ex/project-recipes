using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Recipes.Controller;
using Recipes.Model;


namespace Recipes.View
{
    public partial class RecipesForm : Form
    {
        private RecipesController recipesController;

        public RecipesForm()
        {
            recipesController = new RecipesController();
            InitializeComponent();
        }

        private void RefreshRecipeList()
        {
            // Clear the existing items in the ListBox
            listBoxRecipes.Items.Clear();

            // Fetch the updated list of recipes from the database using Entity Framework
            var recipes = recipesController.GetRecipes().ToList();

            // Add each recipe to the ListBox
            foreach (var recipe in recipes)
            {
                listBoxRecipes.Items.Add(recipe.RecipeName);
            }
        }

        private void RecipesForm_Load(object sender, EventArgs e)
        {
            RefreshRecipeList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();
            // Retrieve information entered by the user from the input fields
            string recipeName = textBoxRecipeName.Text;
            string ingredients = textBoxIngredients.Text;
            string instructions = textBoxInstructions.Text;
            recipe.RecipeName = recipeName;
            recipe.Ingredients = ingredients;
            recipe.Instructions = instructions;

            // Validate the input (check if required fields are filled)
            if (string.IsNullOrEmpty(recipeName) || string.IsNullOrEmpty(ingredients) || string.IsNullOrEmpty(instructions))
            {
                MessageBox.Show("Please enter recipe name, ingredients, and instructions.");
                return;
            }


            // Clear the input fields to prepare for adding another recipe
            textBoxRecipeName.Text = "";
            textBoxIngredients.Text = "";
            textBoxInstructions.Text = "";

            recipesController.AddRecipe(recipe);
            RefreshRecipeList();

            MessageBox.Show("Recipe added successfully!");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a recipe to edit.");
                return;
            }

            string selectedRecipeName = listBoxRecipes.SelectedItem.ToString();
            Recipe? recipe = recipesController.SearchRecipeByName(selectedRecipeName);

            if (recipe == null)
            {
                MessageBox.Show("Recipe not found!");
                return;
            }
            // Update the selected recipe with the modified information
            recipe.RecipeName = textBoxRecipeName.Text;
            recipe.Ingredients = textBoxIngredients.Text;
            recipe.Instructions = textBoxInstructions.Text;

            recipesController.UpdateRecipe(recipe);
            RefreshRecipeList();

            MessageBox.Show("Recipe updated successfully!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list (assuming you have a list to display recipes)
            if (listBoxRecipes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a recipe to delete.");
                return;
            }


            string selectedRecipeName = listBoxRecipes.SelectedItem.ToString();
            Recipe? recipe = recipesController.SearchRecipeByName(selectedRecipeName);

            recipesController.RemoveRecipe(recipe);

            RefreshRecipeList();

            MessageBox.Show("Recipe deleted successfully!");
        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem == null) return;
            string selectedRecipeName = listBoxRecipes.SelectedItem.ToString();
            Recipe? recipe = recipesController.SearchRecipeByName(selectedRecipeName);
            textBoxRecipeName.Text = recipe.RecipeName;
            textBoxIngredients.Text = recipe.Ingredients;
            textBoxInstructions.Text = recipe.Instructions;
        }
    }
}
