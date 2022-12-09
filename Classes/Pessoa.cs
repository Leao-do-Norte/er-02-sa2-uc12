using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using er_02_sa2_uc12.Interfaces; // usando a interface

namespace er_02_sa2_uc12.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome {get; set;}
        // o sinal de interrogação informa ao sistema que
        // a variável iniciará sem valor

        public float rendimento {get;set;}

        public string? endereco {get;set;}

        public abstract float CalcularImposto (float rendimento);
    }
}