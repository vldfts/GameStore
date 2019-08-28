using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using GameStore.WebUI.Controllers;

namespace GameStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            //Mock<IGameRepository> mock = new Mock<IGameRepository>();
            //mock.Setup(m => m.Games).Returns(new List<Game>
            //{
            //    new Game{GameID=1,Name="Game1"},
            //    new Game{GameID=2,Name="Game2"},
            //    new Game{GameID=3,Name="Game3"},
            //    new Game{GameID=4,Name="Game4"},
            //    new Game{GameID=5,Name="Game5"},
            //});
            //GameController controller = new GameController(mock.Object);
            //controller.pageSize = 3;

            //IEnumerable<Game> result = (IEnumerable<Game>)controller.List(2).Model;

            //List<Game> games = result.ToList();
            //Assert.IsTrue(games.Count == 2);
            //Assert.AreEqual(games[0].Name, "Game4");
            //Assert.AreEqual(games[1].Name, "Game5");
        }
    }
}
