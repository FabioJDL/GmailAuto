using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GmailAuto.Test
{
    [TestClass]
    public class NewAccount
    {
        public static string BaseUrl = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&dsh=S722293307%3A1605484529672583&gmb=exp&biz=false&flowName=GlifWebSignIn&flowEntry=SignUp";

        [TestMethod]
        public void SignUp()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl(BaseUrl);

            //NOME
            var nome = driver.FindElement(By.Id("firstName"));
            nome.SendKeys("GmailAuto");

            //SOBRENOME
            var sobrenome = driver.FindElement(By.Id("lastName"));
            sobrenome.SendKeys("87");

            //NOME DE USUÁRIO
            var userName = driver.FindElement(By.Id("username"));
            userName.SendKeys("squadra.treinamento.fabio");

            //SENHA
            var senha  = driver.FindElement(By.Name("Passwd"));
            senha.SendKeys("Fabio_Squadra2020");

            //CONFIRMAR SENHA
            var confirmarSenha = driver.FindElement(By.Name("ConfirmPasswd"));
            confirmarSenha.SendKeys("Fabio_Squadra2020");



            //CLICAR EM "PRÓXIMO"
            var botaoProximo = driver.FindElement(By.Id("accountDetailsNext"));
            botaoProximo.Click();


            //fiquei sem tempo pra terminar!





        }
    }
}