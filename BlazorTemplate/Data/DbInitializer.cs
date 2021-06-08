using System.Linq;
using System.Threading.Tasks;
using BlazorTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorTemplate.Data
{
    public class DbInitializer
    {
        public static void InitDb(ApplicationDbContext context)
        {
            // DBが存在しなければ作成する
            context.Database.EnsureCreated();

            //if(!context.Games.Any()) {
            //    context.Games.AddRange(
            //        new Game { GameID = 1, Title = "リバーシ", Min = 2, Max = 2 },
            //        new Game { GameID = 2, Title = "七並べ", Min = 2, Max = 4 },
            //        new Game { GameID = 3, Title = "将棋", Min = 2, Max = 2 },
            //        new Game { GameID = 4, Title = "チェス", Min = 2, Max = 2 }
            //    );
            //}

            context.SaveChanges();
        }
    }
}