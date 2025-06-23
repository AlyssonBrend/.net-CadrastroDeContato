using Web.MVC.Controllers;

namespace Web.MVC.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel Adicionar(ContatoModel contato);
    }
}
