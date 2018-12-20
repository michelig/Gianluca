using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Clienti
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
    }
}
