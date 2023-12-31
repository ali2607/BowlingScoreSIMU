﻿using BowlingScoreInterface.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BowlingScoreInterface.Controllers
{
    public class GameController : Controller
    {
        /// <summary>
        /// Method to return the view of the game page.
        /// </summary>
        /// <returns>The main view.</returns>
        public IActionResult Index(string serializedGame)
        {
            Game? game = new();
            try
            {
                game = JsonSerializer.Deserialize<Game>(serializedGame);
            }
            catch (JsonException e)
            {
                throw new JsonException("Error while deserializing the game", e);
            }
            return View(game);
        }
    }
}
