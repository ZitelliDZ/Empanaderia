using System;


namespace Alto_Acoplamiento
{
public class Ayudante
{
	public TipoEmpanada tipo { get; set; }

	public Ayudante(TipoEmpanada tipo)
	{
		this.tipo = tipo;		
	}

	public Empanada HacerEmpanada(String Masa)
	{

		Empanada emp = new Empanada();

		emp.HacerLaMasa(Masa);
		emp.HacerRepulgue(this.tipo.Repulgue);
		emp.PonerRelleno(this.tipo.Relleno);

		return emp;
	}

}
}
