using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi_Candidatos.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Idade { get; set; }
        public string Urllinkedin { get; set; }
        public string Categoria { get; set; }

        
    }
}