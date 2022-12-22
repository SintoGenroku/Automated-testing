using NUnit.Framework;

namespace GitHubAutomation
{
    [TestFixture]
    public class SmokeTests
    {
        private Steps.Steps steps = new Steps.Steps();
        private const string USERNAME = "bor_as1999@mail.ru";
        private const string PASSWORD = "payW6LQwm%-W?GD";
        private const string name = "Andrew";
        private const string phoneModel = "S22";

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void OneCanCheckingTheDisplayOfDiscountsOnTheProductPage()
        {
            steps.CheckingTheDisplayOfDiscountsOnTheProductPage();
        }
 
        [Test]
        public void OneCanAddingProductInFavouriteList()
        {
            steps.LoginSamsung(USERNAME, PASSWORD);
            steps.AddingProductInFavouritesList();
        }

        [Test]
        public void OneCanAddingProductInBasket()
        {
            steps.LoginSamsung(USERNAME, PASSWORD);
            steps.AddProductInBasket();
        }
       
        [Test]
        public void OneCanChangeNameProfile()
        {
            steps.LoginSamsung(USERNAME, PASSWORD);
            steps.SetNewName(name);
        }

        [Test]
        public void OneCanDeleteProductInFavourite()
        {
            steps.LoginSamsung(USERNAME, PASSWORD);
            steps.DeleteProductInFavourite();
        }

        [Test]
        public void OneCanSortMonitors()
        {
            steps.SortMonitors();
        }

        [Test]
        public void OneCanSearchAndSort()
        {
            steps.SearchAndSort(phoneModel);
        }

    }
}
