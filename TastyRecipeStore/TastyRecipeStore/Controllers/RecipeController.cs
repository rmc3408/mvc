﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TastyRecipeStore.Models;

namespace TastyRecipeStore.Controllers
{
    public class RecipeController : Controller
    {
        public IRecipeRepository repository;

        public RecipeController(IRecipeRepository theRecipe)
        {
            repository = theRecipe;
        }

        public ViewResult List()
        {
            return View(repository.FoodRepository);
        }


        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Form()
        {
            //Open Form action.
            return View();
        }

        [HttpPost]
        public ViewResult Form(Recipe recipeFromForm)
        {
            //Add number of the recipe as you save it.
            recipeFromForm.RecipeID = repository.FoodRepository.Count() + 1;

            return View("Index");
        }

        public ViewResult ViewRecipe(int id)
        {
            //Search for first results in the repository
            return View(repository.FoodRepository.FirstOrDefault(p => p.RecipeID == id));
        }
        public ActionResult Crud() => RedirectToAction("Index", "Admin");

        public ViewResult Review()
        {
            return View();
        }
    }
}