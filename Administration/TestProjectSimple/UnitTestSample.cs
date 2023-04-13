using DotLiquid;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sample;

namespace TestProjectSimple
{
    [TestClass]
    public class UnitTestSample
    {
        //07.04.2023 Калинин Арсений Олегович Описание: тестирование метода создания шаблона для печати и перегрузки метода
        [TestMethod]
        public void TestMethodCreateDoc1()
        {
            string n = "1", dater = "1", krats = "1", corresp = "1", execude = "1", period = "1";
            bool test;
            Hash hash = SampleDoc.CreateDocumentContext(n, dater, krats, corresp, execude, period);
            if (hash != null)
            {
                test = true;
            }
            else
            {
                test = false;
            }
            Assert.IsTrue(test, "Метод должен вернуть true.");
        }
        [TestMethod]
        public void TestMethodCreateDoc2()
        {
            string n = "1", dater = "1", krats = "1", corresp = "1", execude = "1", period = "1";
            bool test;
            Hash hash = SampleDoc.CreateDocumentContext(n, dater, krats, corresp, execude, period);
            if (hash != null)
            {
                test = true;
            }
            else
            {
                test = false;
            }
            Assert.IsFalse(test, "Метод должен вернуть False.");
        }
        [TestMethod]
        public void TestMethodCreateDoc3()
        {
            string n = "1sljaskaad", dater = "askdashd", krats = "sdfhdsklhc", corresp = "asdlkahkd", execude = "asdkjasd", period = "asdkadh", fio = "asdhajdk", ad = "sfddgf";
            bool test;
            Hash hash = SampleDoc.CreateDocumentContext(n, dater, fio, ad, krats, corresp, execude, period);
            if (hash != null)
            {
                test = true;
            }
            else
            {
                test = false;
            }
            Assert.IsTrue(test, "Метод должен вернуть true.");
        }
        [TestMethod]
        public void TestMethodCreateDoc4()
        {
            string n = "1sljaskaad", dater = "askdashd", krats = "sdfhdsklhc", corresp = "asdlkahkd", execude = "asdkjasd", period = "asdkadh", fio = "asdhajdk", ad = "sfddgf";
            bool test;
            Hash hash = SampleDoc.CreateDocumentContext(n, dater, fio, ad, krats, corresp, execude, period);
            if (hash != null)
            {
                test = true;
            }
            else
            {
                test = false;
            }
            Assert.IsFalse(test, "Метод должен вернуть False.");
        }
        [TestMethod]
        public void TestMethodCreateDoc5()
        {
            string n = "1", dater = "1", krats = "1", corresp = "1", execude = "1", period = "1";
            bool test;
            Hash hash = SampleDoc.CreateDocumentContext(n, dater, krats, corresp, execude, period);
            if (hash != null)
            {
                test = true;
            }
            else
            {
                test = false;
            }
            Assert.IsTrue(test, "Метод должен вернуть False.");
        }
    }
}
