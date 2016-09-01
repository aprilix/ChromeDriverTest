using System;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace ChromeTest
{
    public class Class1
    {

        public void start_browser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddExtension(@"seldt.crx"); 
            try
            {
                var serv = ChromeDriverService.CreateDefaultService();
                serv.EnableVerboseLogging = true;
                //options.AddExcludedArgument("disable-background-networking");
                //options.AddExcludedArgument("disable-default-apps");
                //options.AddExcludedArgument("disable-client-side-phishing-detection");
                //options.AddExcludedArgument("disable-component-update");
                //options.AddExcludedArgument("disable-web-resources");
                //options.AddExcludedArgument("safebrowsing-disable-auto-update");
                //options.AddExcludedArgument("metrics-recording-only");
                //options.AddExcludedArgument("disable-hang-monitor");
                //options.AddExcludedArgument("disable-prompt-on-repost");
                //options.AddExcludedArgument("disable-popup-blocking");
                //options.AddExcludedArgument("load-extension");
                //options.AddExcludedArgument("load-component-extension");
                //options.AddExcludedArgument("test-type");
                //options.AddExcludedArgument("disable-sync");
                //options.AddExcludedArgument("use-mock-keychain");
                //options.AddExcludedArgument("ignore-certificate-errors");
                //options.AddArgument(@"--user-data-dir=E:\Temp");
                //options.AddArgument("--enable-devtools-experiments=true");
                //options.AddArgument("--test-type=driver");
                //options.AddArgument("--enable-tab-switcher=true");
                //options.AddArgument("--expose-internals-for-testing=true");
                //options.AddArgument("--enable-experimental-extension-apis=true");
                //options.AddArgument("--enable-accessibility-tab-switcher=true");
                //options.AddArgument("--allow-http-background-page=true");
                //options.AddArgument("--enable-push-api-background-mode=true");
                //options.AddArgument("--safebrowsing-disable-extension-blacklist");
                //options.AddArgument("--auto-open-devtools-for-tabs=true");
                //options.AddArgument("--log-level=2");
                //options.AddArgument("--allow-legacy-extension-manifests=true");
                //options.AddArgument("--disable-web-security");
                //options.AddArgument("--allow-outdated-plugins=true");
                //options.AddArgument("--enable-easy-off-store-extension-install=true");
                //options.AddArgument("data:blank");
                
                var Current = new ChromeDriver(serv, options);
                Current.Navigate().GoToUrl("https://google.ru");
                System.Threading.Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
