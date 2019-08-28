using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System.Collections.Generic;

namespace GameStore.Domain.Concrete
{
    public class EFGameRepository : IGameRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Game> Games
        {
            get { return context.Games; }
        }

        public Game DeleteGame(int gameID)
        {
            Game dbEntry = context.Games.Find(gameID);
            if (dbEntry!=null)
            {
                context.Games.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveGame(Game game)
        {
            if (game.GameID==0)
            {
                context.Games.Add(game);
            }
            else
            {
                Game dbEntry = context.Games.Find(game.GameID);
                if (dbEntry!=null)
                {
                    dbEntry.Name = game.Name;
                    dbEntry.Description = game.Description;
                    dbEntry.Price = game.Price;
                    dbEntry.Category = game.Category;
                    dbEntry.ImageData = game.ImageData;
                    dbEntry.ImageMimeType = game.ImageMimeType;
                }
            }
            context.SaveChanges();
        }
    }
}
