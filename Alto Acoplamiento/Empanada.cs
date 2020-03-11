using System;

namespace Alto_Acoplamiento
{
    public class Empanada
    {

        public String masa { get; set; }
        public String Repulgue { get; set; }
        public String Relleno { get; set; }

        public Empanada()
        {
            
        }

        public void HacerLaMasa(String Masa)
        {
            this.masa = Masa;
        }
        public void HacerRepulgue(String Repulgue)
        {
            this.Repulgue = Repulgue;
        }
        public void PonerRelleno(String Relleno)
        {
            this.Relleno = Relleno;
        }


    }
}
