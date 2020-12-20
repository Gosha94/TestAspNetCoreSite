using System;
using System.Collections.Generic;
using System.Linq;
using TestAspNetCoreSite.Data.Models;
using TestAspNetCoreSite.Interfaces;

namespace TestAspNetCoreSite.Mocks
{
    public class MockMicrowaves : IAllMicrowaves
    {
        private readonly IMicrowavesCategory _microwavesCategory = new MockMicrowaveCategory();
        public IEnumerable<MicrowaveModel> Microwaves
        {
            get => new List<MicrowaveModel>()
               {
                new MicrowaveModel
                {
                    Name = "Искра-5000",
                    ShortDesctiptionForMainPage="Быстрый разогрев",
                    LongDescription="Отлично подходит для облучения соседей! (Опция доступна при покупке от 5 шт.)",
                    ImagePath="/img/1.jpg",
                    Price=18000,
                    IsFavourite = true,
                    AvailableRestOfProduct = true,
                    CategoryModel = _microwavesCategory.AllMicrowavesCategories.First()
                },
                new MicrowaveModel
                {
                    Name = "The Grelka",
                    ShortDesctiptionForMainPage="Британский бренд, китайское качество...",
                    LongDescription="Инновационная разработка британских ученых, позволяет обогревать жилище холодной зимней порой!",
                    ImagePath="/img/2.jpg",
                    Price = 30000,
                    IsFavourite = true,
                    AvailableRestOfProduct = true,
                    CategoryModel = _microwavesCategory.AllMicrowavesCategories.Last()
                },
                new MicrowaveModel
                {
                    Name = "Работяга",
                    ShortDesctiptionForMainPage="Просто работает, и все. Работает, вот и не трожь!",
                    LongDescription="За свою цену слегка подогревает воздух вокруг микроволновки",
                    ImagePath="/img/3.jpg",
                    Price = 9000,
                    IsFavourite = true,
                    AvailableRestOfProduct = true,
                    CategoryModel = _microwavesCategory.AllMicrowavesCategories.Last()
                },
                new MicrowaveModel
                {
                    Name = "На разогреве",
                    ShortDesctiptionForMainPage="Вот это подогрев!",
                    LongDescription="Может разогреть как засохшую пиццу, так и твоего кота, который косячит",
                    ImagePath="/img/4.jpg",
                    Price = 5500,
                    IsFavourite = true,
                    AvailableRestOfProduct = true,
                    CategoryModel = _microwavesCategory.AllMicrowavesCategories.First()
                },
                new MicrowaveModel
                {
                    Name = "Неисправность-800",
                    ShortDesctiptionForMainPage="Чаще не работает, чем работает!",
                    LongDescription="Ну сломалась, и что? Сейчас схожу еще две таких куплю!",
                    ImagePath="/img/5.jpg",
                    Price=3000,
                    IsFavourite = true,
                    AvailableRestOfProduct = true,
                    CategoryModel = _microwavesCategory.AllMicrowavesCategories.Last()
                },
                new MicrowaveModel
                {
                    Name = "Суши весла",
                    ShortDesctiptionForMainPage="Отлично сушит носки",
                    LongDescription="Сушилка для фруктов и носков одновременно!",
                    ImagePath="/img/6.jpg",
                    Price=1600,
                    IsFavourite = true,
                    AvailableRestOfProduct = true,
                    CategoryModel = _microwavesCategory.AllMicrowavesCategories.First()
                }
            };
        }
        public IEnumerable<MicrowaveModel> FavouriteMicrowaves { get; set; }

        public MicrowaveModel GetObjectMicrowave(int microwaveId)
        {
            throw new NotImplementedException();
        }
    }
}
