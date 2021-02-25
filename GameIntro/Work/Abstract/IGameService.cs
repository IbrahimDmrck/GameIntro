using GameIntro.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Abstract
{
    interface IGameService
    {
        void Add(Game game );
        void Update(Game game);
        void Delete(Game game);
    }
}
