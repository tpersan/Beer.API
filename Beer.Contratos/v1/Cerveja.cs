using System;
using System.Collections.Generic;
using System.Text;

namespace Beer.Contratos.v1
{
    public class Bebida
    {
        public string rotulo { get; set; }
        public string descricaoComercial { get; set; }
        public string marca { get; set; }
        public string tipo { get; set; }
        public string principaisIngredientes { get; set; }
        public FormaApresentacao apresentacao { get; set; }
    }

    public class Suco : Bebida
    {
        public string fruta { get; set; }
    }

    public class Cerveja : Bebida
    {
        public decimal teorAlcoolico { get; set; }
        public decimal temperaturaIndicadaConsumo { get; set; }
    }
}


