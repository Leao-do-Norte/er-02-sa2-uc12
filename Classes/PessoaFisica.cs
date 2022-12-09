using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using er_02_sa2_uc12.Interfaces; // usando a interface

namespace er_02_sa2_uc12.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get;set;}

        public DateTime dataNasc {get;set;}

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        } // implementação (da interface) da classe abstrata

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        } // implementação da interface
    }
}