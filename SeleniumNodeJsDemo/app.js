
var webdriver = require('selenium-webdriver');
 
var driver = new webdriver.Builder().
   withCapabilities(webdriver.Capabilities.chrome()).
   build();

function nopCommerceLogin()
{
//login demo
driver.get('http://localhost:36824/login');

var email = driver.findElement(webdriver.By.id('Email'))
                  .sendKeys('meetnbilal@gmail.com');

var password = driver.findElement(webdriver.By.id('Password'))
                     .sendKeys('admin');

driver.findElement(webdriver.By.className('login-button'))
      .click();
//driver.quit();
}


function nopCommerceSearch()
{
//search demo
driver.get('http://localhost:36824');

var searchBox = driver.findElement(webdriver.By.id('small-searchterms'))
                      .sendKeys('Camera');

driver.findElement(webdriver.By.className('search-box-button'))
      .click();

//driver.quit();
}

nopCommerceLogin();
nopCommerceSearch();


