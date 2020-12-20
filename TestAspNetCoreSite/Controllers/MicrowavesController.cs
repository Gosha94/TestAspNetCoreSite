using Microsoft.AspNetCore.Mvc;
using TestAspNetCoreSite.Interfaces;
using TestAspNetCoreSite.ViewModels;

namespace TestAspNetCoreSite.Controllers
{
    public class MicrowavesController : Controller
    {
        // Функции контроллера возвращают результирующую html страницу в виде ViewResult
        private readonly IAllMicrowaves _allMicrowaves;
        private readonly IMicrowavesCategory _allMicrowavesCategory;

        public MicrowavesController(IAllMicrowaves iAllMicrowaves, IMicrowavesCategory iMicrowavesCat)
        {
            _allMicrowaves = iAllMicrowaves;
            _allMicrowavesCategory = iMicrowavesCat;
        }
        public ViewResult GetAllMicrowavesData()
        {
            // Для передачи данных внутрь Html, не рекомендуется использовать, исп модели данных
            //ViewBag.Category = "Любой текст";
            //var microwaves = this._allMicrowaves.Microwaves;
            ViewBag.Title = "Лучшие микроволновки 2021";
            MicrowavesListViewModel micrVm = new MicrowavesListViewModel();
            micrVm.AllMicrowaves = _allMicrowaves.Microwaves;
            micrVm.CurrentCategory = "Микроволновки";

            return View(micrVm);
        }

    }
}
