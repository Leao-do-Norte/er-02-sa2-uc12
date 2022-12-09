using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using er_02_sa2_uc12.Interfaces; // usando a interface

namespace er_02_sa2_uc12.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj {get;set;}

        public string? razaoSocial {get;set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        } // implementação (da interface) da classe abstrata

        public bool ValidarCnpj(string cnpj)
        {
            throw new NotImplementedException();
        } // implementação da interface
    }
}