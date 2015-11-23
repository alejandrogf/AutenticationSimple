using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutenticationSimple.Models
{
    public class Usuario
    {
        [DisplayName("Nombre de usuario")]
        public string Login { get; set; }
        [DisplayName("Contraseña")]
        public string Password { get; set; }
    }
}
