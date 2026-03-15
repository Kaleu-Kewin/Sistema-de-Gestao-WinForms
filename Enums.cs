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
            Direita,
            Todos
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

        public enum Tema
        {
            Claro,
            Escuro
        }

        public enum FormatoData
        {
            [Description("dd/MM/yyyy")]
            DiaMesAno,

            [Description("MM/dd/yyyy")]
            MesDiaAno,

            [Description("yyyy/MM/dd")]
            AnoMesDia
        }

        public enum Idioma
        {
            [Description("Português (Brasil)")]
            PortuguesBrasil,

            [Description("English (US)")]
            InglesEstadosUnidos,

            [Description("Español")]
            Espanhol
        }

        public enum Moeda
        {
            [Description("Real (R$)")]
            Real,

            [Description("Dólar (US$)")]
            Dolar,

            [Description("Euro (€)")]
            Euro
        }
    }
}
