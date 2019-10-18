namespace Beer.Contratos.v1
{

    public class Marca
    {
        public static string Ambev { get { return "Ambev"; } }
        public static string HocusPocus { get { return "HocusPocus"; } }
        public static string Colorado { get { return "Colorado"; } }
    }

    public class TipoCerveja
    {
        public static string IPA { get { return "IPA"; } }
        public static string APA { get { return "APA"; } }
        public static string Golden { get { return "Golden Ale"; } }
        public static string Pilsen { get { return "Pilsen"; } }
    }
    public class TipoSuco
    {
        public static string Integral { get { return "Integral"; } }
        public static string Misto { get { return "Misto"; } }
    }

    public class FormatoApresentacao
    {
        public static string Lata { get { return "Lata"; } }
        public static string Garrafa { get { return "Garrafa"; } }
        public static string Chopp { get { return "Chopp"; } }
    }

}