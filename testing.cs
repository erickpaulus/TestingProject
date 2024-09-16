using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
class Program
{
    static void Main(string[] args)
    {
        // assign the path to the ChromeDriver executable
        string driverPath = @"path_to_chromedriver\chromedriver.exe";

        // Initialize a new instance of the Chrome driver
        IWebDriver driver = new ChromeDriver(driverPath);

        // Navigate to the login page, please adjust with your webpage target
        driver.Navigate().GoToUrl("https://example.com/login");

        // Find the username and password input fields and the login button
        IWebElement usernameField = driver.FindElement(By.Id("username"));
        IWebElement passwordField = driver.FindElement(By.Id("password"));
        IWebElement loginButton = driver.FindElement(By.Id("loginButton"));

        // Put your username and password in
        usernameField.SendKeys("your_username");
        passwordField.SendKeys("your_password");

        // Click the button of Login
        loginButton.Click();

        // You can extend further actions on the logged-in page here

        // Close the browser
        driver.Quit();
    }
}
