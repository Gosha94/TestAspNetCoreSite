using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TestAspNetCoreSite.Data.EfCoreContext;
using TestAspNetCoreSite.Data.Models;
using TestAspNetCoreSite.Interfaces;

namespace TestAspNetCoreSite.Data.Repository
{
    public class MicrowaveRepository : IAllMicrowaves
    {
        private readonly AppDbaseContext _appDbContext;

        public MicrowaveRepository(AppDbaseContext appDbaseContext)
        {
            this._appDbContext = appDbaseContext;
        }
        // Получаем из БД объекты, входящие в опред категорию товара
        public IEnumerable<MicrowaveModel> Microwaves => this._appDbContext.Microwaves.Include(microWav => microWav.CategoryId);
        // Получаем из БД все объекты, поле IsFavourite которых - true
        public IEnumerable<MicrowaveModel> FavouriteMicrowaves => this._appDbContext.Microwaves.Where(micrW => micrW.IsFavourite).Include(micr => micr.CategoryId);
        public MicrowaveModel GetObjectMicrowave(int microwaveId) => _appDbContext.Microwaves.FirstOrDefault(mic => mic.Id == microwaveId);
    }
}
