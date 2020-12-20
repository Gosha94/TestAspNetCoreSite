using System.Collections.Generic;
using TestAspNetCoreSite.Data.EfCoreContext;
using TestAspNetCoreSite.Data.Models;
using TestAspNetCoreSite.Interfaces;

namespace TestAspNetCoreSite.Data.Repository
{
    public class MicrowaveCategoryRepository : IMicrowavesCategory
    {
        private readonly AppDbaseContext _appDbContext;

        public MicrowaveCategoryRepository(AppDbaseContext appDbaseContext)
        {
            this._appDbContext = appDbaseContext;
        }

        public IEnumerable<MicrowaveCategoryModel> AllMicrowavesCategories => this._appDbContext.MicrowaveCategory;
    }
}
