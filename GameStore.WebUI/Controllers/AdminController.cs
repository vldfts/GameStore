using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        IGameRepository repository;
        public AdminController(IGameRepository repo)
        {
            repository = repo;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View(repository.Games);
        }
        public ViewResult Edit(int gameID)
        {
            Game game = repository.Games
                .FirstOrDefault(g => g.GameID == gameID);
            return View(game);
        }
        [HttpPost]
        public ActionResult Edit(Game game, HttpPostedFileBase image=null)
        {
            if (ModelState.IsValid)
            {
                if (image!=null)
                {
                    game.ImageMimeType = image.ContentType;
                    game.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(game.ImageData, 0, image.ContentLength);
                }
                repository.SaveGame(game);
                TempData["message"] = string.Format("Зміни в грі \"{0}\" було збережено", game.Name);
                return RedirectToAction("Index");
            }
            else
            {
                return View(game);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new Game());
        }
        [HttpPost]
        public ActionResult Delete(int gameID)
        {
            Game deletedGame = repository.DeleteGame(gameID);
            if (deletedGame!=null)
            {
                TempData["message"] = string.Format("Гра \"{0}\" була видалена", deletedGame.Name);
            }
            return RedirectToAction("Index");
        }
    }
}