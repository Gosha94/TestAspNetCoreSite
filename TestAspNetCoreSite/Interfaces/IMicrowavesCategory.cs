using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspNetCoreSite.Data.Models;

namespace TestAspNetCoreSite.Interfaces
{
    public interface IMicrowavesCategory
    {
        IEnumerable<MicrowaveCategoryModel> AllMicrowavesCategories { get; }
    }
}
