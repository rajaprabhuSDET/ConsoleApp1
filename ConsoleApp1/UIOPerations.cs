using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class UIOPerations: BrowserLaunching
    {
        protected String inputValue;
        protected String outputValue;
        public IWebElement element;

        private By getObject(String p, String objectType)
        {
            switch (objectType.ToUpper())
            {
                case "XPATH":
                    return By.XPath(p);

                case "CLASSNAME":
                    return By.ClassName(p);

                case "NAME":
                    return By.Name(p);

                case "CSS":
                    return By.CssSelector(p);

                case "LINK":
                    return By.LinkText(p);

                case "PARTIALLINK":
                    return By.PartialLinkText(p);

                case "ID":
                    return By.Id(p);

                default:
                    return null;
            }
        }

        protected void click(String p, String objectType) 
        {  
	  	    this.waitWithClickable(p, objectType);
	  	    element = driver.FindElement(this.getObject(p, objectType));
            element.Click(); 	
        }

        protected void setTextWithEnter(String p, String objectType, String inputValue)  
        {
	   	    this.waitWithClickable(p, objectType);
            element = driver.FindElement(this.getObject(p,objectType));
            element.Clear();
            element.SendKeys(Keys.Enter);
            element.SendKeys(inputValue);
            element.SendKeys(Keys.Enter);
        }

        protected void setTextWithoutEnter(String p, String objectType, String inputValue)  
        {
	   	    this.waitWithClickable(p, objectType);
            element = driver.FindElement(this.getObject(p,objectType));
            element.Clear();
            element.SendKeys(inputValue);
        }


        protected void goToURL(String inputURL)
        {
            driver.get(inputValue);
        }

        protected String getValueByText(String p, String objectType)  
        {
	   	    this.waitWithoutClickable(p, objectType);
            element = driver.FindElement(this.getObject(p,objectType));
            String label=element.getText();
	   	    return label;
        }
        protected String getValueByAttribute(String p, String objectType)  
        {
	 	    this.waitWithoutClickable(p, objectType);
            element = driver.FindElement(this.getObject(p,objectType));
            String label=element.GetAttribute("value"); 
	 	    return label;
        }

        protected void select(String p, String objectType, String inputValue)  
        {
	        this.waitWithClickable(p, objectType);
            element = driver.findElement(this.getObject(p,objectType));
            Select dropdown = new Select(element);
            dropdown.selectByVisibleText(inputValue);
        }

        protected void mouseHover(String p, String objectType)  
        {
	        this.waitWithClickable(p, objectType);
            element = driver.FindElement(this.getObject(p,objectType));
            Actions mouse_hover = new Actions(driver);
            mouse_hover.MoveToElement(element).Build().Perform();
        }
 
        protected void autoComplete(String p, String objectType, String inputValue)  
        {
	 	    this.waitWithClickable(p, objectType);
            element = driver.FindElement(this.getObject(p,objectType));
            element.SendKeys(inputValue);
            element.SendKeys(Keys.Down);
            element.SendKeys(Keys.Enter);
        }


        protected void waitWithClickable(String p, String objectType)
        {
            wait.Until(ExpectedConditions.presenceOfElementLocated(this.getObject(p, objectType)));
            wait.Until(ExpectedConditions.ElementToBeClickable(this.getObject(p, objectType)));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(this.getObject(p, objectType)));
        }

        protected void waitWithoutClickable(String p, String objectType)
        {
            wait.Until(ExpectedConditions.presenceOfElementLocated(this.getObject(p, objectType)));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(this.getObject(p, objectType)));
        }

        protected void radioButton(String p, String objectType, String inputValue)  
        {
		    this.waitWithClickable(p, objectType);
            List<IWebElement> RadButtonList =driver.findElements(this.getObject(p,objectType));
		    for(int i=0; i< RadButtonList.size() ; i++)
            {
                //System.out.println(((WebElement) RadButtonList.get(i)).getAttribute("value"));
                if (((IWebElement)RadButtonList.get(i)).getAttribute("value").equals(inputValue))
                {
                    //System.out.println("radio button clicked");
                    ((IWebElement)RadButtonList.get(i)).click();
                }
            }
        }

        protected void datePicker(String p, String objectType, String inputValue)  
        {
	 	        this.waitWithClickable(p, objectType);
            element = driver.FindElement(this.getObject(p,objectType));
            element.Clear();
            element.SendKeys(inputValue);
            element.SendKeys(Keys.Enter);
        }

        protected void contSendkeysOperation(String p, String objectType, String inputValue)
        {
            this.waitWithClickable(p, objectType);
            element = driver.FindElement(this.getObject(p, objectType));
            Actions builder = new Actions(driver);
            Actions seriesOfActions = builder.MoveToElement(element).Click().sendKeys(element, inputValue);
            seriesOfActions.Perform();
        }

        protected void waitTillInvisible(String p, String objectType)
        {
            try
            {
                wait.Until(ExpectedConditions.visibilityOfElementLocated(this.getObject(p, objectType)));
                wait.Until(ExpectedConditions.InvisibilityOfElementLocated(this.getObject(p, objectType)));
            }
            catch (TimeoutException e)
            {

            }
        }
        protected void waitLoad(String p, String objectType)
        {
            this.waitWithClickable(p, objectType);
            element = driver.FindElement(this.getObject(p, objectType));
            element.isDisplayed();
        }

        protected Boolean assertText(String p, String objectType, String expectedText)
        {
            Boolean status = false;
            this.waitWithoutClickable(p, objectType);
            element = driver.FindElement(this.getObject(p, objectType));
            String actualText = element.getText();
            if (actualText.Equals(expectedText))
            {
                status = true;
            }
            return status;
        }

       // protected void takeScreenShot() 
       //// {
        //    private File scrFile = driver.getScreenshotAs(OutputType.FILE);
        //FileUtils.copyFile(scrFile, new File("D:\\Exception\\screenshots\\"+".png"));	
   	 
       // }
 
         protected String getInputValue(String dataFlag, databaseOperartions input, String value, String dbcolumn_name) 
         {
	         switch(dataFlag)

             {
	 		        case "Read":
	 			        inputValue = input.read_data(dbcolumn_name);
                break;
    		
	 		        case "Default":	
	 			        inputValue = value;
                break;
             }   
	 	        return inputValue;
         }
    }
}
