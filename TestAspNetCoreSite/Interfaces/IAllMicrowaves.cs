using System.Collections.Generic;
using TestAspNetCoreSite.Data.Models;

namespace TestAspNetCoreSite.Interfaces
{
    interface IAllMicrowaves
    {
        IEnumerable<MicrowaveModel> Microwaves { get;}
        IEnumerable<MicrowaveModel> FavouriteMicrowaves { get; set; }
        MicrowaveModel GetObjectCar(int carId);
    }
}
