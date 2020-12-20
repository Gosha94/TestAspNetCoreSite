using System.Collections.Generic;
using TestAspNetCoreSite.Data.Models;

namespace TestAspNetCoreSite.Interfaces
{
    public interface IAllMicrowaves
    {
        IEnumerable<MicrowaveModel> Microwaves { get;}
        IEnumerable<MicrowaveModel> FavouriteMicrowaves { get; }
        MicrowaveModel GetObjectMicrowave(int microwaveId);
    }
}
