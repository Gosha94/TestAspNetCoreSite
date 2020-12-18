using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAspNetCoreSite.Data.Models
{
    public class MicrowaveModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesctiptionForMainPage { get; set; }
        public string LongDescription { get; set; }
        public string ImagePath { get; set; }
        public ushort Price { get; set; }
        public bool IsFavourite { get; set; }
        public bool AvailableRestOfProduct { get; set; }
        public int CategoryId { get; set; }
        public virtual MicrowaveCategoryModel CategoryModel { get; set; }
    }
}
