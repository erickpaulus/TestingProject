# Testing Project
This repository contains my experiments to deal with the automating login in a certain web page using C# and Selenium. 

It involves Selenium WebDriver and a web browser driver like ChromeDriver. 

The steps are follow:

1. Install Selenium WebDriver via NuGet:
In your Visual Studio project, right-click on "References" and select "Manage NuGet Packages." Search for "Selenium.WebDriver" and install it.

2. Download and set up a WebDriver for your preferred web browser. For example, if you want to use Chrome, download ChromeDriver from the official website (https://sites.google.com/chromium.org/driver/), unzip the executable, and install it in your project folder or any directory you prefer.

3. Import necessary namespaces in your C# code:

```
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
```

4. Write the code to automate the login:

```
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
```
Make sure to replace "path_to_chromedriver\chromedriver.exe", "https://example.com/login", "your_username", and "your_password" with the appropriate values for your use case. Another important matter, please adjust the id of User Interface (UI) components such as Username field, password field, Login Button. Because each website may declare it in diffrent naming.
This script will launch the Chrome browser, go to the login page, enter a username and password, and then press the login button. You can modify the code to interact with other website components or carry out extra tasks after signing in

The next step how to run this executable automatically. There are several ways which depend on your operation system. For my experiment, I used a Task Schedular to run the executable file. In Linux/MAC, Cron Jobs can be a good solution. 
