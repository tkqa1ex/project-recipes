using System.ComponentModel.Design;
using Recipes.Controller;
using Recipes.Model;

namespace RecipesTest
{
    public class RecipesControllerTest
    {
        private RecipesController controller;

        public RecipesControllerTest()
        {
            controller = new RecipesController();
        }


        [Fact]
        public void AddTest()
        {
            Recipe recipe = new Recipe();
            recipe.RecipeName = "xunit-test-recipe";
            recipe.Ingredients = "no ingredients";
            recipe.Instructions = "no instructions";

            try
            {
                controller.AddRecipe(recipe);
            }
            catch (Exception ex)
            {
                Assert.True(false, $"AddTest failed with error: {ex.Message}");
            }
        }

        [Fact]
        public void EditTest()
        {
            Recipe? recipe = controller.SearchRecipeByName("xunit-test-recipe");
            if(recipe == null)
            {
                Assert.True(false, "EditTest Recipe 'xunit-test-recipe' not found.");
            }

            try
            {
                controller.UpdateRecipe(recipe);
            }
            catch (Exception ex)
            {
                Assert.True(false, $"EditTest failed with error: {ex.Message}");
            }

        }

        [Fact]
        public void SearchFoundTest()
        {
            // recipe should be the recipe added from AddTest
            Recipe? recipe = controller.SearchRecipeByName("xunit-test-recipe");
            if (recipe == null)
            {
                Assert.True(false, "SearchTest Recipe 'xunit-test-recipe' not found.");
            }
            Assert.Equal("xunit-test-recipe", recipe.RecipeName);
        }

        [Fact]
        public void DeleteTest()
        {
            Recipe? recipe = controller.SearchRecipeByName("xunit-test-recipe");
            if (recipe == null)
            {
                Assert.True(false, "DeleteTest Recipe 'xunit-test-recipe' not found.");
            }

            try
            {
                controller.RemoveRecipe(recipe);
            }
            catch (Exception ex)
            {
                Assert.True(false, $"DeleteTest failed with error: {ex.Message}");
            }

        }



        [Fact]
        public void SearchNotFoundTest()
        {
            // recipe should not exist
            Recipe? expected = null;
            Recipe? recipe = controller.SearchRecipeByName("not-in-db-xunit-recipe");
            Assert.Equal(expected, recipe);
        }

        [Fact]
        public void OrderedTest()
        {
            // Runs Tests in the correct order
            AddTest();
            EditTest();
            SearchFoundTest();
            DeleteTest();
            SearchNotFoundTest();
        }

    }
}