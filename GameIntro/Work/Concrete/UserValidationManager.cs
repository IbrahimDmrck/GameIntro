using GameIntro.Concrete;
using GameIntro.Work.Abstract;
using GameIntro.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        IUserValidationService userValidationService;

        public bool Validate(Gamer gamer)
        {
            userValidationService = new MernisServiceAdapter();

            return userValidationService.Validate(gamer);
        }
    }
}
