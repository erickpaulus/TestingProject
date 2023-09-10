# Testing Project
This repository contains my experiments to deal with the automating login in a certain web page using C# and Selenium. 

It involves Selenium WebDriver and a web browser driver like ChromeDriver. 

The steps are follow:

1. Install Selenium WebDriver via NuGet:
In your Visual Studio project, right-click on "References" and select "Manage NuGet Packages." Search for "Selenium.WebDriver" and install it.

2. Download and set up a WebDriver for your preferred web browser. For example, if you want to use Chrome, download ChromeDriver from the official website (https://sites.google.com/chromium.org/driver/), unzip the executable, and install it in your project folder or any directory you prefer.

3. Import necessary namespaces in your C# code:

'''
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
Write the code to automate the login:
csharp
Copy code
class Program
{
    static void Main(string[] args)
    {
        // Specify the path to the ChromeDriver executable
        string driverPath = @"path_to_chromedriver\chromedriver.exe";

        // Initialize a new instance of the Chrome driver
        IWebDriver driver = new ChromeDriver(driverPath);

        // Navigate to the login page
        driver.Navigate().GoToUrl("https://example.com/login");

        // Find the username and password input fields and the login button
        IWebElement usernameField = driver.FindElement(By.Id("username"));
        IWebElement passwordField = driver.FindElement(By.Id("password"));
        IWebElement loginButton = driver.FindElement(By.Id("loginButton"));

        // Enter your username and password
        usernameField.SendKeys("your_username");
        passwordField.SendKeys("your_password");

        // Click the login button
        loginButton.Click();

        // You can perform further actions on the logged-in page here

        // Close the browser
        driver.Quit();
    }
}
'''
Make sure to replace "path_to_chromedriver\chromedriver.exe", "https://example.com/login", "your_username", and "your_password" with the appropriate values for your use case.

This code will open a Chrome browser window, navigate to the login page, fill in the username and password fields, and click the login button. You can extend the code to interact with other elements on the page or perform additional actions after logging in.
