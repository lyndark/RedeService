using ProgrammerEvaluationWeb.Services;

namespace ProgrammerEvaluationTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void OrderTest1()
        {
            var result = OrdenatorService.Order(new int[] { 10, 90, 85 });
            Assert.That(result, Is.EquivalentTo(new int[] { 10, 85, 90 }));
        }

        [Test]
        public void OrderTest2()
        {
            var result = OrdenatorService.Order(new int[] { 2, 22, 100, 600, 15 });
            Assert.That(result, Is.EquivalentTo(new int[] { 2, 15, 22, 100, 600 }));
        }

        [Test]
        public void CreateFileTest()
        {
            FileService.CreateTxtFile(new int[] { 2, 22, 100, 600, 15 });
            var rootPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
            Assert.That(rootPath + "/numeros_ordenar.txt", Does.Exist);
        }

        [Test]
        public void CreateListClsTest()
        {
            var list = clsTesteService.CreateClsTesteList();
            Assert.That(list, Is.Not.Empty);
            Assert.That(list.Count, Is.EqualTo(100));
        }

        [Test]
        public void CreateJSONTest()
        {
            var rootPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
            FileService.CreateJsonFile(clsTesteService.CreateClsTesteList(), rootPath ?? "");
            Assert.That(rootPath + "/data.json", Does.Exist);
        }

        [Test]
        public void ReadJSONTest()
        {
            var rootPath = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
            var list = FileService.ReadJsonFile(rootPath ?? "");
            Assert.That(list, Is.Not.Empty);
            Assert.That(list.Count, Is.EqualTo(100));
        }

        [Test]
        public void GetAPIBanksTest()
        {
            var list = ApiService.GetBankApi();
            Assert.That(list, Is.Not.Empty);
            Assert.That(list.Count, Is.GreaterThan(0));
        }
    }
}