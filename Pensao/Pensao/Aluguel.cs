using System;
using System.Collections.Generic;
using System.Text;

namespace Pensao
{
    class Aluguel
    {
        public int NumQuarto { get; set; }
        private string _nome;
        private string _email;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _email = value;
                }
            }
        }

        public override string ToString()
        {
            return "Quarto número "
                + NumQuarto
                + " reservado para:\n"
                + "Nome: "
                + Nome + "\n"
                + "Email: "
                + Email;
        }
    }
}