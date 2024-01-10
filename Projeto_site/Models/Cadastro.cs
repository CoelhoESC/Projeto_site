using System.Globalization;

namespace Projeto_site.Models
{
    public class Cadastro
    {
        public int id { get; set; }
        public string nome {  get; set; }
        public DateOnly dtNasc { get; set; }
        public string email { get; set; }
        public string password { get; set; }


    }
}
