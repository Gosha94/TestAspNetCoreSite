using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAspNetCoreSite.Data.Models
{
    public class MicrowaveCategoryModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<MicrowaveModel> MicrowaveModels { get; set; }
    }
}
