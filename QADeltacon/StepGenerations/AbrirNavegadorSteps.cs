
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecRun;
using Util;


namespace StepGenerations
{
    [Binding]
    public class AbrirNavegadorSteps
    {
        private QAUtil QAUtil = new QAUtil();

        [When(@"o sistema rodar")]
        public void QuandoOSistemaRodar()
        {
            QAUtil.IniciarNavegador();
        }
        
        [Then(@"acessar a pagina inicial")]
        public void EntaoAcessarAPaginaInicial()
        {
            QAUtil.NavegadorAberto();
        }
    }
}
