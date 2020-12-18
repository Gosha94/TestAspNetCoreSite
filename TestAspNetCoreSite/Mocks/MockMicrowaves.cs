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
                    ImagePath="data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxAPDw8NDRAPDw0PDw8NDQ0NDw8NDQ0NFREWFhURFRUYHSggGBolGxUVITEhMSkrLi4uFx8zOD8sNygtLjcBCgoKDQ0NFQ8PFSsdFRktKzUrKzc3KysrKzI3LSsxLS4rKzc3KystNzEtOC4rKzUrMC00Ky03Ky0uKys0NzgrK//AABEIAKwBJQMBIgACEQEDEQH/xAAcAAABBAMBAAAAAAAAAAAAAAACAAEDBAUHCAb/xABUEAABAwIBAwsQBgcFCQEAAAABAAIDBBEFEiFUExUxQVF0kZKT0dIGBxciIyQzNGFicXOUsrO0MlJTcoGxFGNkocTT4VWCg8LwJUJldaOkwcPxFv/EABYBAQEBAAAAAAAAAAAAAAAAAAABAv/EABsRAQEBAQEBAQEAAAAAAAAAAAABEQIxQSED/9oADAMBAAIRAxEAPwDeCSSwfVJ1V0mHtvUyd0Iuynjs+d/93aHlNggzi8f1T9cegoHGJzn1M4NnQ0oZIYz57iQ1p8l7+Ra06quuFWV2VFETSUpzanE7usg8+TZ/AWHpXjW0w2gia272aaXQ6vhg6Sfs0Uuh1fDB0lqUU6f9H8iGtsdmil0Or4YOkl2aaXQ6vhg6S1P+jJjTeRMNbY7NVLodXwwdJLs10mh1fDB0lqQ0yY0yGtt9myk0Or40HSS7NlJoVXwwdJaiNMhNOhrb3ZtpNCq+NB0kuzbSaFWcan6S0/8Ao6EweRDW4ezfSaFWcan6abs30mhVnGp+mtPGBCYFTW4+zhSaFWcan6aXZwpNCrONT9NabMCYwqGtydnGk0Ks41P00uzjSaFWcNP01pkwpjEhrc/ZxpNCrONT9NLs40mhVnGp+mtL6mmMaGt09nGk0Ks41P00uzjSaFWcan6a0rqaWpoa3V2caTQqzjU/TS7ONJoVZxqfprSuppamhrdXZxpNCrONT9NLs40mhVnGp+mtKamlqaGt19nGk0Ks41P003ZypNCrONT9NaV1NNqaGt19nKk0Ks41P00uznR6FWcNP01pQxpjEhrdfZ0o9CrOGn6S9B1J9dLD8Rk/R7yUtQ7NHHVZDWzeRjwSCfNNjuXXORjQuivsoa7HSXPPUT10qugyYKzLrKMWa27h+lQtH1Hn6Y813CNhbzwDH6XEIhPRytlZmDgM0kTrXyXtOdp9KKyaSSSDynXEx2Sip4BDcPqahtPlg2MbMh7yR5e1t+K0rioa6aRz8pz3Ou55f2xPlW0+vF4LDt/j5eVarqonyzvZFG+R+zkxtL3W3bAKxFR1OzzvweVC+mZ+s5RyyOs1XolVyEvMhODVmi1PIS8yIxbqZm7Lyr0Bp2bsvLPWUdgtXotTyEvMozgtXotTyEvMisWYG7svLP50DoW/Wl5aRZR2C1ei1PIS8yjdgtXotTyEvMiMUYm/Wl5Z6AxD60vLPWUOC1ei1PIScyA4JV6LU8hJzIMW6PzpeWegLPPl5VyyhwWr0Wp5CTmUZwWr0Wp5GTmRWMLPPl5RyEjz5eUcskcGq9GqORk5kBwar0ao5GTmQY4/fl5Ryb+/LyhWQOD1WjVHIycyA4PVaNPyMnMoKBPnSco5NfzpOUcrxweq0eo5KTmTa0VOjz8k/mRVHK86TlHJZXnSco5XDhFTo8/JP5kxwip0efkn8yCnledJyhTZXnScoVc1pqdHn5J/Mm1qqdHn5N/MgqZXnSccpr+dJxyrmtVT9hNyT02tVT9hNyT+ZBUz/Wfx0rH68nHVvWqp+wm5J/MlrVU/YTcm/mQVLH68nHSsfrycdXNaqn7Cbkn8yfWqp+wm5J/MgrW7X6T75Wzlm9rILefJx/6K2aCe4ZqMuXYvydTflZFwMq1ti+a6Qw2f7CbkpOZBUyfOk4/9EsnzpOP/AEVzW2f7CbkpOZLW2f7Cbkn8yCpk+dJx/wCibU/Ok4/9Fc1tn+wm5J/Mn1tn+xm5J/Mgpan58nGWd6msamoC+ene4SMGW12VY3GfJP1mnbacxVDW6f7Cbkn8yFrSI5g4EODHggggg22CEHYFFPqkUctrapGyS25lNBt+9JQYL4rTb3h+GE6DxPXj8Dh2/wAfLyrBdag/7QxA/s8I/wCoVnOvJ4HDt/j5eVef61bu/wDEPUw++VfiNqOeoXSKN0ihfIoqR8igfKo3yKB8iIkfKoHyKN8igfIqg3yKu+VA+RVpJUEkkqqyTKOSVVZJVRJJKqskqjklVWSRBJJIq0kiB8irvkQG96ge9C96hc9ATnKJzkLnIC5QO4oCUJchJQOUJTEproHSTXSQOmSSQSR+EG9XfMhSqKPwg3q75lqmRTJWRRtuQBskgD8VLqYySTfdYcpt3C9vobO0c+xmWpNY67nPqCyVlYdE0H/esDIHeXJAsRmzXJtt2UUzbGwvsNNjsi7QbfvSzE5/pOrkAsDjXhKr1TPgMWeWBxnwlV6pnwGLLbqnBfFabe8PwwnSwXxWm3vD8MJKNPD9ebwOHb/Hy8q851rnd+4h6qH3yvR9ec9xw7f4+XlXl+tm7vzEPVw+85PiNkvkUD5ED3qB70Ej5FA+RA96iy1UJ8irvlRSPVWSRA0kqqSSopJFWkeqBklVWSVHI9VnvQDJIqz5Eb3KB7kAPeoXPRucoXFKAc9RucjcVGSoALkBcjKEoAJQEqVMgjuldSWQyIASSSQOkEydBLH4Qb1d8y1SqGL6Y3q75kKw2+0L/gCimBRGQ2ybmwzgbQKtVcDWBuQS8kuDjkMsNi1gL7u7wKOkZlus7M2x7YNbsgbAvt+Tb2NtXUsl9iMzOvcuNxt7Kjc65uc5Oc+lSzDJc5uawJANmkG24bZ/Sp6aFj2OJexrwHEB2QBmtYWtc3ufRbOmpOZPIprA4z9Oq9Uz4DV6DZ3PwACwOMjulV6pnwGqK6nwbxWm9RD7gSSwbxWm9RD7gSUaeF69J7hh2/x8vMvKdbd3fdf6uH3nL1XXr8Bh2/x8vMvH9bp3fVf9yH3nKpWwXvUD5ED5FBJIiCfIotVUEkqh1TMgmklVWSRBJIq8kioKSVVpJEMj1Xe9A75FA96F71C96B3vULnJnOUTnIHc5Rucmc5ASoEShJSJQkoEShKSZAkkkkCQvRIXoASSSQJOmSRU0X0xvV3zIVukqHRuD2kjOLgEgOF72PkVOL6Y3q75kK3TMDntDiA2/bXOSLbl7G3Agu1lbLk5LspmVnvlyHKG2CC4jcUdDVlgLWjKucr6T2jYtsAjcCPEAxzQWvDi2zbaplXHkGQM+xnvtKPDGtynFzg2w7W7snPcbrXAqoGtn1Qi4yS242XOJub7ZU7KmU3c2x2jaKM3tnuRbPa4UcsbNV+kdTOcub2xGbcsNvyBWIxEBkiV+e/bakQRe1/97byQgpPNyXG1ybmwDRwDYXncbHdKr1TPgNXqZY2AjU3OcNvKbk2/fnXl8eHdav1TPgMUV1Lg/i1P6iH3AmT4T4vT+oi9wJKK8F17PAYdv/8Ah5l4vrfu74rvuw/m9ez693i+Hf8AMP4aZeH6hXWnrvRD+b1Ur28kirSSIJJFVkkVxBySKHVFDJIotUQSySKu+RA+RQPegJ71A96F71C5yB3OUTnJnOUbioHLlG4pEoCVQiUJKRKG6gRTFJMgSZIpIEkkkgSGREhegBJJJAkkk4CKli+mN6u+ZCsRscfohx2L5IJsoIR3Qb1d8yFchkcy+S5zb2vkuLbjyoLFZA0ZOpZWy7K+kc2a3/lBStBcbjK7W9sotubjbCsVJmjyA6SSz2B4GW+xYdjZHpUVKwk2YS02sTlW7Xy2GxsKoGVtnEC4sdi5zZtjOrlNTtMZJDsuzsn6W0P3qBzTlHKuTtkm9/LdXKcSZBc1zg1uaweRtXNh6M6Coxq8t1Qju1Z6pnwGL2TI15DqkHd6wfq2fAYlV1BhXi8HqYvcCZPhfi8HqYvcCSyrwHXv8Xw7f/8ADTLwPUU601b/AIH+de96+Pi+H7//AIeZa86kHWlrP8D/ADqxK9XJIqskiF8irySKoJ8ijEihe9AHoJHvUL3oXOUTnIHc5RucmcUBKgRKAlIlASgSElIlMgYpkkkCSSTIGSSSQJJJJAkMiJBIgFIJAIgECARAJwEYaiihHdG71d8wFdpszmkgOaDna62cbB2dtVYh3Vu9X/MBXGNQXqydsjQABlZhchoLWjaByjtqOlAabluVmsLPyCPxCEwEWvt7HlG76FYpYgXWde1jsbJNs1lUCWguuBYEglpflenP5Vejc21hHYbYExsdo/uUAisSBnF7X3Vaipza/wD9O7bdQDqYvmFhmsL5W1urw3VQO+K0fq4/l2LYcca8B1WDvqu9Wz5diUdMYX4vB6mL3AknwvwEHqYvcCZZaa/6+Pi2H7//AIaZa26lnWkrPTB/7Fsjr5+LYfv/APh5lrLqad29WfOh/KRWJXoHyKB70L3qF71UO56EOUTnJg5NBucgJQlyEvCgclASmLggLgqHJQ3SLghygoHKYpsoJZQQJJNlBLKCBJFIuCa4QJJNlBK43UDpJrhOCECCZ4RCydyCMBGAnARtagZoUjWp2sUzGIAib3Zg/ZX/ADAV5rRtqvG3viMfsknzDVkgz/QSt8SXqSgYBuhX6UPbnZmuBtNN9zZViliaYzcAWBtnaJC4C+e42EVLEy/dMq3mWv8AvSJ1nw2pPcbuBJ9AH5KeOnO4UWptuci+TtZVrq9T04yNllzfZOf+n4KorNiI2QtbdWA78r/uR/LsW0441rHqzb37XjzGfAYojpLC/AQepi9wJJYZ4CH1UfuBJRprzr6eLYfv/wDh5Vq/qePbVX34fykW0Ovr4rh+/wAfLyrVmAHPVffh/KRWJWXc5ROck4oCUQxKAlOSgJQMShTkoSUDFCU6ZAyEokyBkydWaOhfMJXMycmGPVZC57WAN/H/AFwhBVTLMt6mqouyRG3K1OGa2qMHaSvLG7ezdrrjasbqObqfqWDKc1o7apZbVGZV6cSGXNfYGpP/AHfWFwxSZZh3U1VC3aN7aV8A7ozwjKjUHA58wy819zPsLG1MBje6N9sptr5Lg5puAQQRs5iEEKVkVk4CAQEQaiARBqAQEYaia1SNYgFrVI1iNrFOyNURsYrDI0bI1ZjiQVGM76iH7JL8dqyzYb7v4EhUms78hH7HN8dqsviMlQ6IvkYxkMTwI3GO7nuluSRnOaMW9JRZbP2LcdOPLxnc6uxt9HAFTZhP66o5eXnU7MH/AF1Ty8vOot6t9q9G30cAVhjfRwBUGYL+0VXLyc6mZgZ0mr5eTnRlkWs/0BZar6smd/Yh91nwGLYVA18Nc2m1WWWOSlmnOrPMha+OWBosTsZpXX/DcXhOrJnf+IehnwGIrobDfAQ+qj90JJYd4GH1UfuhJRWu+vt4rQb/AB8vMtVYEc9V9+H8pFtTr7+K0G/x8vMtU4DnNVbP28JsM5taTOiVkyUBKItO4eAoSw7h4CqgShJRFh3DwFDkHcPAVQKEoyw7h4ChLDuHgKgEoSjyDuHgKbIO4eAoBTIsg7h4ClkHcPAUA2VmjrpIMvUnBpe0scchjjkkEGxcDkmxIuN1QZB3DwFLIO4eAoMieqGruTqxu4OaTkRDtXZdx9HY7o/0XQnHqo7MgN5JJnAxQkPkkEjXl3a9sCJpRY3HbnyKhkHcPAUtTO4eAoL2vlVn7s7PJqx7VnhNWdNlbH13uNvLbYACp1EzpHmSQ3e61zYN2AABYZhmACYRncPAU4jO4eAoAARAIxGdw8BRiI7h4CgjARtapGxHcPAVK2E7h4EEbWKZjFIyE7h4Cp2QHcPAqImRqwyNTRwHcPArMcB3DwIIY4lajiUscB3DwKyyE7h4EGL1Pv8Ag3lP8dqsxN7+eN2np/eqUL2EYlTNsc9BUngnYslU4NqkgmZLNBLkiMuhERymAkgESMcM2U7YtsqKtxxqzHGsczBJtPreLRfyVOzAptPreLRfyURko41YjjWKbgE/9o1/Fof5CmZ1PT/2jiHFov5KCDJ/2vEP+HVZ/wC4pF4Pqyb3/iP9z4DFtLC8B1GUzvmnqZtTMLZKjUrsic5rnNGpsbsljNm/0QtadV4Br8RIzjKaMxzXELARwgj8EVvfD/Aw+qj90JJ6Edyi9Wz3QkorxHXjwaoq6Om/RYnTOgq2zSMjGVJqZikZlBuy7O4ZgtIS4BiTXuLKHEQb2u2jqvzDV1akg5S1nxXQ8U9krOih1mxbQ8T9krOiur0kHKGs2LaHifslX0UxwbFtDxT2Sr6K6wSQxyccGxbQ8U9kq+im1lxfQ8U9kq+iuskkHJmsmL6HinslX0UtZMX0PFPZKvorrNJByZrHi+h4p7JV9FLWTF9DxT2Wr6C6zSQcmayYvoWKeyVfQTayYvoeKeyVfRXWiSDkvWTF9DxT2Sr6KbWTGNDxT2Sr6K61SQcl6yYvoeKeyVfRS1kxjQ8U9kq+iutEkHJmsmMaHinslX0UtZcY0PFPZavorrNJBybrNjGh4r7LV9FLWfGNDxX2Wr6K6ySQcnaz4zomK+y1fRS1nxnRcV9lrOiusUkHJ4wnGdFxb2Ws6KcYVjWi4t7LWdFdXpIOUta8a0bFvZqzop9bMa0bF/Zq3orqxJByv/8AnsYc0TmkxIuDjCHGGpEoBGURa2Vk+W1kwwTGNFxXkazmXVKSDlkYJjGjYryNZzI24FjGjYryVXzLqNJBzGzA8X0fFOSq+ZWI8DxbR8S/GOqXSiSDnOPA8U26fEeTqVew/qWrnNcwUdQ1zwWjLifG253S4ABb+SV0R07C1jGHOWta0ndIFklIkoP/2Q==",
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
                    ImagePath="https://items.s1.citilink.ru/1137377_v04_b.jpg",
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
                    ImagePath="https://avatars.mds.yandex.net/get-mpic/1567763/img_id8539160731524579371.jpeg/orig",
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
                    ImagePath="https://avatars.mds.yandex.net/get-mpic/1521939/img_id5148283591216682376/orig",
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
                    ImagePath="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTq8NFs9qJFoA1-Z33XFQj2cUXp-aAa5CZdGA&usqp=CAU",
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
                    ImagePath="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaOKz7hKVrkhFSYe9RBrEJWXtNvsQoB9iGCQ&usqp=CAU",
                    Price=1600,
                    IsFavourite = true,
                    AvailableRestOfProduct = true,
                    CategoryModel = _microwavesCategory.AllMicrowavesCategories.First()
                }
            };
        }
        public IEnumerable<MicrowaveModel> FavouriteMicrowaves { get; set; }

        public MicrowaveModel GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
