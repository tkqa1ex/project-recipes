using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Recipes.Model;

namespace Recipes.Controller
{
    public class RecipesController
    {
        private RecipesDbContext db;

        public RecipesController()
        {
            db = db = new RecipesDbContext();
            db.Database.EnsureCreated();
        }
        public void AddRecipe(Recipe recipe)
        {
            db.Recipes.Add(recipe);
            db.SaveChanges();
        }
        public void UpdateRecipe(Recipe recipe)
        {
            db.Recipes.Update(recipe);
            db.SaveChanges();
        }

        public void RemoveRecipe(Recipe recipe)
        {
            db.Recipes.Remove(recipe);
            db.SaveChanges();
        }

        public Recipe? SearchRecipeByName(string name)
        {
            return db.Recipes.FirstOrDefault(x => x.RecipeName == name);
        }
        public DbSet<Recipe> GetRecipes()
        {
            return db.Recipes;
        }
    }
}