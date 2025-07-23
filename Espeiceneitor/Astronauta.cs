using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espeiceneitor
{
    public class Astronauta
    {
        private static int _Indexi = 1;

        public int Id { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Origem { get; set; }

        public Astronauta(string nome, DateTime dataNascimento, string origem)
        {
            Id = _Indexi;
            Nome = nome;
            DataNascimento = dataNascimento;
            Origem = origem;

            _Indexi++;
        }
    }
}
//Deu certo