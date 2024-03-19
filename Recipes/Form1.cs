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
using System.Xml.Linq;

namespace Recipes
{
    public partial class Form1 : Form
    {
        private MyDbContext db = new MyDbContext();
        public Form1()
        {
            db.Database.EnsureCreated();
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshRecipeList();
        }

        private Recipe selectedRecipeForEdit;
        private void RefreshRecipeList()
        {
            // Clear the existing items in the ListBox
            listBoxRecipes.Items.Clear();

            // Fetch the updated list of recipes from the database using Entity Framework
            using (var context = new MyDbContext())
            {
                var recipes = context.Recipes.ToList();

                // Add each recipe to the ListBox
                foreach (var recipe in recipes)
                {
                    listBoxRecipes.Items.Add(recipe.RecipeName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list (assuming you have a list to display recipes)
            if (listBoxRecipes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a recipe to edit.");
                return;
            }

            // Retrieve the selected recipe from the list
            var selectedRecipe = listBoxRecipes.SelectedItem.ToString();
            Recipe? recipe = db.Recipes.FirstOrDefault(x => x.RecipeName == selectedRecipe);

            // Update the selected recipe with the modified information
            recipe.RecipeName = txtRecipeName.Text;
            recipe.Ingredients = txtIngredients.Text; // Assuming Ingredients is a string
            recipe.Instructions = txtInstructions.Text;

            // Save the changes to the database using Entity Framework
            db.Recipes.Update(recipe);
            db.SaveChanges();
            RefreshRecipeList();

            MessageBox.Show("Recipe updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list (assuming you have a list to display recipes)
            if (listBoxRecipes.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a recipe to delete.");
                return;
            }

            // Retrieve the selected recipe from the list
            var selectedRecipe = listBoxRecipes.SelectedItem.ToString();
            Recipe? recipe = db.Recipes.FirstOrDefault(x => x.RecipeName == selectedRecipe);
            db.Recipes.Remove(recipe);

            // Delete the selected recipe from the database using Entity Framework
            db.SaveChanges();
            RefreshRecipeList();

            MessageBox.Show("Recipe deleted successfully!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Recipe recipe = new Recipe();
            // Retrieve information entered by the user from the input fields
            string recipeName = txtRecipeName.Text;
            string ingredients = txtIngredients.Text; // Assuming Ingredients is a string
            string instructions = txtInstructions.Text;
            recipe.RecipeName = recipeName;
            recipe.Ingredients = ingredients;
            recipe.Instructions = instructions;

            // Validate the input (e.g., check if required fields are filled)
            if (string.IsNullOrEmpty(recipeName) || string.IsNullOrEmpty(ingredients) || string.IsNullOrEmpty(instructions))
            {
                MessageBox.Show("Please enter recipe name, ingredients, and instructions.");
                return;
            }

            // Create a new Recipe object with the entered information
            Recipe newRecipe = new Recipe
            {
                RecipeName = recipeName,
                Ingredients = ingredients,
                Instructions = instructions
            };

            // Clear the input fields to prepare for adding another recipe
            txtRecipeName.Text = "";
            txtIngredients.Text = "";
            txtInstructions.Text = "";

            // Add the new recipe to the database using Entity Framework
            db.Recipes.Add(recipe);
            db.SaveChanges();
            RefreshRecipeList();

            MessageBox.Show("Recipe added successfully!");
        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedItem == null) return;
            var selectedRecipe = listBoxRecipes.SelectedItem.ToString();
            Recipe? recipe = db.Recipes.FirstOrDefault(x => x.RecipeName == selectedRecipe);
            txtRecipeName.Text = recipe.RecipeName;
            txtIngredients.Text = recipe.Ingredients; 
            txtInstructions.Text = recipe.Instructions;

        }

       
    }
}