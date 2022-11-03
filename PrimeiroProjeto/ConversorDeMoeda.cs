using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto {
    internal class ConversorDeMoeda {
        public static double cotacao;
        public static double dolares;
        public static double Conversor() {
            return (dolares * cotacao) + (dolares * cotacao * 0.06f);
        }
    }
}
