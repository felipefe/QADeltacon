using System;
using TechTalk.SpecFlow;
using TechTalk.SpecRun;
using Util;

namespace StepGenerations
{
    [Binding]
    public class LoginSitemaSteps
    {

        QAUtil QAUtil = new QAUtil();

 
        [When(@"for clicado no botão entrar")]
        public void QuandoForClicadoNoBotaoEntrar()
        {
            QAUtil.CliqueEntrarSistema();
        }

        [Then(@"logar no sistema")]
        public void EntaoLogarNoSistema()
        {
            QAUtil.Entrou();
        }
        

    }
}
