using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAspNetCoreSite.Data.Models;
using TestAspNetCoreSite.Interfaces;

namespace TestAspNetCoreSite.Mocks
{
    public class MockMicrowaveCategory : IMicrowavesCategory
    {
        // TODO Реализовать взаимодействие с БД, сейчас даные создаются в коде
        public IEnumerable<MicrowaveCategoryModel> AllMicrowavesCategories
        {
            get => new List<MicrowaveCategoryModel>
            {
                new MicrowaveCategoryModel { CategoryName = "Электрические микроволновки", Description= "Современная, мощная микроволновка" },
                new MicrowaveCategoryModel { CategoryName = "Механические микроволновки", Description= "Устаревший аналог, большая скидка, плавный нагрев пищи при условии равномерного кручения тарелки на солнце" }
            };
            
        } 
    }
}
