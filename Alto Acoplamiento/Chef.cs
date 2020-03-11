using System;

namespace Alto_Acoplamiento
{
     public class Chef
    {
        
        public String Masa = "Mi Especilidad";
        
        public TipoEmpanada tipo1 = new TipoEmpanada ("Carne","Tenedor","Carne");
        public TipoEmpanada tipo2 = new TipoEmpanada ("Humita","Dobles","Choclo");
        public TipoEmpanada tipo3 = new TipoEmpanada ("Verdura","Triangular","Acelga");
        
        public Ayudante ayudante1;
        public Ayudante ayudante2;
        public Ayudante ayudante3;
        

        public Chef (){
            ayudante1 = new Ayudante(tipo1);
            ayudante2 = new Ayudante(tipo2);
            ayudante3 = new Ayudante(tipo3);
        }

        public Empanada HacerEmpanada (String Nombre){
            
            Empanada emp = null;
            if (this.tipo1.Nombre == Nombre){
               emp = ayudante1.HacerEmpanada(this.Masa);  
            }
            
            if (this.tipo2.Nombre == Nombre){
               emp = ayudante2.HacerEmpanada(this.Masa);  
            }
            
            if (this.tipo3.Nombre == Nombre){
               emp = ayudante3.HacerEmpanada(this.Masa);  
            }

            if (emp == null){
               Console.WriteLine("No hacemos ese Tipo de Empanada");  
            }

	        

            return emp;

        }
    }
}
