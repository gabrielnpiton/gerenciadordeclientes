using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeClientes.Dominio.Cliente.Entidade
{
    public class Cliente
    {
        //Propriedades
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public Endereco  Endereco { get; set; }

    }
}
