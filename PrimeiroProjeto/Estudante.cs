using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class Estudante {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante(string name, string email) {
            Name = name;
            Email = email;
        }
    
        override public string ToString() {
            return $"{Name} {Email}";
        }
    }
}
