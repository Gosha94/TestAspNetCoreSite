using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspNetCoreSite.Data.Models;

namespace TestAspNetCoreSite.ViewModels
{
    public class MicrowavesListViewModel
    {
        public IEnumerable<MicrowaveModel> AllMicrowaves { get; set; }
        public string CurrentCategory { get; set; }
    }
}
