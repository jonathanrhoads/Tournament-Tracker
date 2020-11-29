﻿using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        PrizeModel CreatePrize(PrizeModel model);

        PersonModel CreatePerson(PersonModel model);

        List<PersonModel> getPerson_All();
    }
}