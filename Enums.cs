using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Dashboard
{
    public class Enums
    {
        public enum LadoBorda
        {
            Superior,
            Inferior,
            Esquerda,
            Direita
        }

        public enum Estados
        {
            [Description("Selecione...")]
            Selecione, 

            AC, AL, AP, AM, BA, CE, DF, ES, GO,
            MA, MT, MS, MG, PA, PB, PR, PE, PI, 
            RJ, RN, RS, RO, RR, SC, SP, SE, TO,
        }

        public enum TipoPessoa
        {
            [Description("Selecione...")]
            Selecione,

            [Description("Pessoa Física")]
            PF,

            [Description("Pessoa Jurídica")]
            PJ
        }
    }
}
