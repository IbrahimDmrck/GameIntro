using GameIntro.Concrete;
using GameIntro.Work.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi " + '\n');
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silindi " + '\n');
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi " + '\n');
        }
    }
}
