using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Reflection;

namespace FacebookOtoArkadasOnaylama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWebDriver driver = null;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            IWebElement username = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[1]/input"));
            username.SendKeys("");

            Thread.Sleep(2500);

            IWebElement password = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[1]/div[2]/div/input"));
            password.SendKeys("");

            Thread.Sleep(2500);

            IWebElement login = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div/div/div/div[2]/div/div[1]/form/div[2]/button"));
            login.Click();
        }


        private void btnScrollKaydir_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://www.facebook.com/friends/requests");
            Thread.Sleep(4000);


            //.q5bimw55.rpm2j7zs.k7i0oixp.gvuykj2m.j83agx80.cbu4d94t.ni8dbmo4.eg9m0zos.l9j0dhe7.du4w35lb.ofs802cu.pohlnb88.dkue75c7.mb9wzai9.d8ncny3e.buofh1pr.g5gj957u.tgvbjcpo.l56l04vs.r57mb794.kh7kg01d.c3g1iek1.k4xni2cv
            string jsCommand = "" +
                "sayfa = document.querySelector('.q5bimw55.rpm2j7zs.k7i0oixp.gvuykj2m.j83agx80.cbu4d94t.ni8dbmo4.eg9m0zos.l9j0dhe7.du4w35lb.ofs802cu.pohlnb88.dkue75c7.mb9wzai9.d8ncny3e.buofh1pr.g5gj957u.tgvbjcpo.l56l04vs.r57mb794.kh7kg01d.c3g1iek1.k4xni2cv');" +
                "sayfa.scrollTo(0,sayfa.scrollHeight);" +
                "var sayfaSonu = sayfa.scrollHeight;" +
                "return sayfaSonu;";

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            var sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));

            while (true)
            {
                var son = sayfaSonu;
                Thread.Sleep(3000);
                sayfaSonu = Convert.ToInt32(js.ExecuteScript(jsCommand));
                if (son == sayfaSonu)
                    break;
            }



            ////ScrollDown End
        }

        
        
        private void btnİstekleriOnayla_Click(object sender, EventArgs e)
        {
            int onaylanacakIstekSayisi = (int.Parse)(txtOnaylanacakIstekSayisi.Text);
            
            for (int i = 0; i < onaylanacakIstekSayisi; i++)
            {
                
                //IReadOnlyCollection<IWebElement> arkadasSiniriEklenemiyor = driver.FindElements(By.XPath("/html/body/div[5]/div[1]/div/div[2]/div/div/div"));
                
                //if (arkadasSiniriEklenemiyor.Count>0) 
                //{
                //    IWebElement Eklenemiyor = driver.FindElement(By.XPath("/html/body/div[5]/div[1]/div/div[2]/div/div/div/div[4]/div/div/div[1]/div/span/span"));
                //    Eklenemiyor.Click();
                //}
                Thread.Sleep((int.Parse)(txtKacSaniyeAraIleOnaylansin.Text) * 1000);

                IWebElement oge = driver.FindElement(By.CssSelector(".rq0escxv.l9j0dhe7.du4w35lb.j83agx80.pfnyh3mw.taijpn5t.bp9cbjyn.owycx6da.btwxx1t3.kt9q3ron.ak7q8e6j.isp2s0ed.ri5dt5u2.rt8b4zig.n8ej3o3l.agehan2d.sk4xxmp2.d1544ag0.tw6a2znq.s1i5eluu.tv7at329"));
                IJavaScriptExecutor yürütücü = (IJavaScriptExecutor)driver;
                yürütücü.ExecuteScript("arguments[0].click();", oge);


            }

            MessageBox.Show($"İşlem Başarılı. {onaylanacakIstekSayisi} İstek Onaylandı");

        }

        private void btnArkadasCikarma_Click(object sender, EventArgs e)
        {
            
            driver.Navigate().GoToUrl("https://www.facebook.com/profile.php?id=100070203337962&sk=friends");

            /*
             döngü işlemleri

           
            hu5pjgll lzf7d6o1
            /html/body/div[1]/div/div[1]/div/div[3]/div/div/div[2]/div/div/div[1]/div[1]/div/div/div[1]/div/div[1]/div/div[4]/div[2]/div/div/span
            a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7 ltmttdrg g0qnabr5
             */

            Thread.Sleep(5000);

             IReadOnlyCollection<IWebElement> arkadaslar =  driver.FindElements(By.CssSelector(".hu5pjgll.lzf7d6o1"));
            MessageBox.Show(arkadaslar.Count.ToString());

            int baslangic = 18;
            for (int i = 0; i < arkadaslar.Count; i++)
            {
                IWebElement bir = arkadaslar.ElementAt<IWebElement>(baslangic);
                bir.Click();

                baslangic++;
                Thread.Sleep(4000);
               
                IWebElement iki = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[2]/div/div/div[1]/div[1]/div/div/div[1]/div/div[1]/div/div[4]/div[2]/div/div/span"));
                iki.Click();
               
                Thread.Sleep(3000);
                IWebElement uc = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/div[4]/div/div[1]/div[1]/div/div[1]/div/span/span"));
                uc.Click();
            }

           

        }

        private void btnArkadasCikarmaScrol_Click(object sender, EventArgs e)
        {
            
        }
    }
}


