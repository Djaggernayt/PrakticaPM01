using System.Collections.Generic;

namespace sample
{
    public static class SampleDoc
    {
        //04.04.2023 Калинин Арсений Олегович Описание: метод с перегрузкой предназначенный для формирования шаблона
        public static DotLiquid.Hash CreateDocumentContext(string n, string dater, string krats, string corresp, string execude, string period)
        {
            var context = new
            {
                Title = "КОНТРОЛЬНАЯ КАРТОЧКА",
                Steps = new List<dynamic>{
                    new { Title = "№ документа:", Description = n},
                    new { Title = "Дата регистрации:", Description = dater },
                    new { Title = "Краткое содержание:", Description = krats},
                    new { Title = "Корреспондент", Description = corresp},
                    new { Title = "ОТВ. ЗА КОНТРОЛЬ:", Description = execude },
                    new { Title = "СРОК ИСПОЛНЕНИЯ:", Description = period},
                }

            };

            return DotLiquid.Hash.FromAnonymousObject(context);
        }

        public static DotLiquid.Hash CreateDocumentContext(string n, string dater, string fio, string ad, string krats, string corresp, string execude, string period)
        {
            var context = new
            {
                Title = "КОНТРОЛЬНАЯ КАРТОЧКА",
                Steps = new List<dynamic>{
                    new { Title = "№ документа:", Description = n},
                    new { Title = "Дата регистрации:", Description = dater},
                    new { Title = "ФИО заявителя:", Description = fio},
                    new { Title = "Адрес отправителя:", Description = ad},
                    new { Title = "Краткое содержание:", Description = krats},
                    new { Title = "Корреспондент", Description = corresp},
                    new { Title = "ОТВ. ЗА КОНТРОЛЬ:", Description = execude },
                    new { Title = "СРОК ИСПОЛНЕНИЯ:", Description = period},
                }

            };

            return DotLiquid.Hash.FromAnonymousObject(context);
        }

    }
}
