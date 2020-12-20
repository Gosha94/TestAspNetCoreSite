using System.Collections.Generic;
using TestAspNetCoreSite.Data.Models;

namespace TestAspNetCoreSite.Interfaces
{
    public interface IAllMicrowaves
    {
        IEnumerable<MicrowaveModel> Microwaves { get;}
        IEnumerable<MicrowaveModel> FavouriteMicrowaves { get; set; }
        MicrowaveModel GetObjectMicrowave(int microwaveId);
    }
}
