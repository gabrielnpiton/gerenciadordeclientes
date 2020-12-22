using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeClientes.Dominio.Cliente.Entidade
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
