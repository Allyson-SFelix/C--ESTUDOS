using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAulaInicial {
    internal class Produtos {
        public bool Exist;
        public string Name;


        public Produtos(bool exist, string name) {
            this.Exist = exist;
            this.Name = name;
        }

        public String GetNome() {
            return Name;
        }
    }
    }
