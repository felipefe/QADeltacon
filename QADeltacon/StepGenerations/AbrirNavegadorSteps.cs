using TechTalk.SpecFlow;
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
