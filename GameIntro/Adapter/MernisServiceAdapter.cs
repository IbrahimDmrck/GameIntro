﻿using GameIntro.Concrete;
using GameIntro.Work.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameIntro.Adapter
{
    class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.IdentityNumber), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
