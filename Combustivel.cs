
public class Combustivel {

	private String tipo;
    private double km;
    private double custoGasolina;
    private double custoAlcool;
    private String posto;
    
	public Combustivel(String tipo, double km, double custoGasolina, double custoAlcool, String posto) {
		this.tipo = tipo;
		this.km = km;
		this.custoGasolina = custoGasolina;
		this.custoAlcool = custoAlcool;
		this.posto = posto;
		
		
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public double getKm() {
		return km;
	}

	public void setKm(double km) {
		this.km = km;
	}

	public double getCustoGasolina() {
		return custoGasolina;
	}

	public void setCustoGasolina(double custoGasolina) {
		this.custoGasolina = custoGasolina;
	}

	public double getCustoAlcool() {
		return custoAlcool;
	}

	public void setCustoAlcool(double custoAlcool) {
		this.custoAlcool = custoAlcool;
	}

	public String getPosto() {
		return posto;
	}

	public void setPosto(String posto) {
		this.posto = posto;
	}