using Projeto_site.Database;
using Projeto_site.Models;

namespace Projeto_site.Repositorio
{
    public class CRUD : ICRUD
    {

        private readonly Db_Context _context;

        public CRUD (Db_Context context)
        {
            _context = context;
        }


        public Cadastro CreatCadastro(Cadastro cadastro)
        {
            _context.Add(cadastro);
            this._context.SaveChanges();
            return cadastro;
        }

        public bool DeleteCadastro(int id)
        {
            Cadastro cadastro = GetCadastro(id);
            _context.cadastros.Remove(cadastro);
            return true; 
        }

        public List<Cadastro> GetAllCadastros()
        {
            return _context.cadastros.ToList();
        }

        public Cadastro GetCadastro(int id)
        {
            Cadastro cadastro = _context.cadastros.FirstOrDefault(i => i.id == id);
            return cadastro;
        }

        public Cadastro UpdateCadastro(Cadastro cadastro)
        {
            Cadastro cadastro_update = GetCadastro(cadastro.id) ?? throw new Exception("Houve um erro.");

            cadastro_update.nome = cadastro.nome;
            cadastro_update.email = cadastro.email;
            cadastro.dtNasc = cadastro.dtNasc;
            cadastro_update.password = cadastro.password;

            _context.cadastros.Update(cadastro_update);
            _context.SaveChanges();
            return cadastro_update;
        }
    }
}
