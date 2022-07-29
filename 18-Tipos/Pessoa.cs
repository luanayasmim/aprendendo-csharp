using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _18_Tipos
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }

        public Pessoa Copia(){
            return new Pessoa(){
                Nome=this.Nome,
                Idade=this.Idade,
                Documento=this.Documento
            };
        }
    }
}