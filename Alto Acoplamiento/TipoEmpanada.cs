using System;

namespace Alto_Acoplamiento
{
     public class TipoEmpanada
    {
        
       public String Nombre { get ; set; }
       public String Repulgue { get ; set; }
       public String Relleno { get ; set; }

        public TipoEmpanada (String nombre, String Repulgue, String Relleno){
            this.Nombre = nombre;
            this.Relleno = Relleno;
            this.Repulgue = Repulgue;
        }

        
    }
}
