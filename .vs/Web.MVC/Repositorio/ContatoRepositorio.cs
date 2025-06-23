using Web.MVC.Controllers;
using Web.MVC.Data;

namespace Web.MVC.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {   
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //inserção no banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}
