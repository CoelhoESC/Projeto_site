using Projeto_site.Models;

namespace Projeto_site.Repositorio
{
    public interface ICRUD
    {
        List<Cadastro> GetAllCadastros();
        Cadastro CreatCadastro(Cadastro cadastro);
        Cadastro UpdateCadastro(Cadastro cadastro);
        Cadastro GetCadastro(int id);
        bool DeleteCadastro(int id);

    }
}
