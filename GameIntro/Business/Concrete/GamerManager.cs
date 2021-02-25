using GameIntro.Concrete;
using GameIntro.Work.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Work.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService )
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName +  " \n " + " Tebrikler! ; Kaydınız Başarıyla Gerçekleşmiştir! ");
            } 
            else
            {
                Console.WriteLine("Doğrulama başarısız oldu, oyuncu ekleme işlemi gerçekleşemedi!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " \n " + " Kayıt Silme İşlemi Gerçekleşti!");
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName +  " \n " + "Tebrikler! ; Kaydınız Başarıyla Güncellendi!");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız! Güncelleme iptal edildi!");
            }
        }
    }
}
