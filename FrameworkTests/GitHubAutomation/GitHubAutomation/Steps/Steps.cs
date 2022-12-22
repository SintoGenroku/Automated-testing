using OpenQA.Selenium;

namespace GitHubAutomation.Steps
{
    public class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void LoginSamsung(string username, string password)
        {
            Pages.LoginPage loginPage = new Pages.LoginPage(driver);
            loginPage.OpenPage();
            loginPage.Login(username, password);
        }

        public void CheckingTheDisplayOfDiscountsOnTheProductPage()
        {
            Pages.SalePage salePage = new Pages.SalePage(driver); 
            salePage.OpenPage();
            
            salePage.OpenProductPage();
        }

        public void OpenTabletsPage()
        {
            Pages.TabletsPage tabletsPage = new Pages.TabletsPage(driver);
            tabletsPage.OpenPage();
            tabletsPage.OpenProductPage();
        }

        public void AddingProductInFavouritesList()
        {
            OpenTabletsPage();
            Pages.ProductPage product = new Pages.ProductPage(driver);
            product.AddingProductInFavourite();
            OpenFavouritePage();    
        }

        public Pages.FavouritePage OpenFavouritePage()
        {
            Pages.FavouritePage favourite = new Pages.FavouritePage(driver);
            favourite.OpenPage();
            return favourite;
        }
        
        public void AddProductInBasket()
        {
            OpenTabletsPage();
            Pages.ProductPage product = new Pages.ProductPage(driver);
            product.AddingProductInBasket();
        }

        public void SetNewName(string name)
        {
            Pages.ProfilePage profile = new Pages.ProfilePage(driver);
            profile.OpenPage();
            profile.ChangeNameProfile(name);
        }

        public void DeleteProductInFavourite()
        {
            OpenFavouritePage().DeleteProductInFavouriteList();
        }
        
        public void SortMonitors()
        {
            Pages.ComputerMonitorsPage computerMonitorsPage = new Pages.ComputerMonitorsPage(driver);
            computerMonitorsPage.OpenPage();
            computerMonitorsPage.SortByPrice();
        }

        public void SearchAndSort(string phoneModel)
        {
            Pages.MainPage mainPage = new Pages.MainPage(driver);
            mainPage.OpenPage();
            mainPage.SearchPhones(phoneModel);
        }
    }
}
