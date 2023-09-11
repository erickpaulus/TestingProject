# Testing Project with C# and Selenium
This repository contains my experiments to deal with the automating login in a certain web page using C# and Selenium. 

It involves Selenium WebDriver and a web browser driver like ChromeDriver. 

The steps are follow:

1. Install Selenium WebDriver via NuGet:
In your Visual Studio project, right-click on "References" and select "Manage NuGet Packages." Search for "Selenium.WebDriver" and install it.

2. Download and set up a WebDriver for your preferred web browser. For example, if you want to use Chrome, download ChromeDriver from the official website (https://sites.google.com/chromium.org/driver/), unzip the executable, and install it in your project folder or any directory you prefer.

3. Open a class or a project 
4. add these two namespaces in your C# code:

```
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
```

5. Write the code to automate the login:

```
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
```
Make sure to replace "path_to_chromedriver\chromedriver.exe", "https://example.com/login", "your_username", and "your_password" with the appropriate values for your use case. Another important matter, please adjust the id of User Interface (UI) components such as Username field, password field, Login Button. Because each website may declare it in diffrent naming. You can find the element ids by right clicking on the input field, then browser will open an Inspect Page. 

This code will launch the Chrome browser, go to the login page, put in a username and password, and then press the login button. You can modify the code to interact with other website components or carry out extra tasks after signing in.

The next step how to run this executable automatically. There are several ways which depend on your operating system. For my experiment, I used a Task Schedular to run the executable file in Windows OS. In Linux/MAC, Cron Jobs can be a good solution. 

By knowing this testing project, you can extend this project to automatically log in to open Wi-Fi that requires web login at anytime you set.
