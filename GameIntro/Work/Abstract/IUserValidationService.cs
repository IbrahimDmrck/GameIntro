using GameIntro.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Abstract
{
    interface IUserValidationService 
    { 
         bool Validate(Gamer gamer);
    }
}
