
public class Multa {
	

    private decimal _valor;
    private int _pontosCnh;
    private DateTime _vencimento;
    private string _motorista;
    private string _infracao;
	public decimal get_valor() {
		return _valor;
	}
	public void set_valor(decimal _valor) {
		this._valor = _valor;
	}
	public int get_pontosCnh() {
		return _pontosCnh;
	}
	public void set_pontosCnh(int _pontosCnh) {
		this._pontosCnh = _pontosCnh;
	}
	public DateTime get_vencimento() {
		return _vencimento;
	}
	public void set_vencimento(DateTime _vencimento) {
		this._vencimento = _vencimento;
	}
	public string get_motorista() {
		return _motorista;
	}
	public void set_motorista(string _motorista) {
		this._motorista = _motorista;
	}
	public string get_infracao() {
		return _infracao;
	}
	public void set_infracao(string _infracao) {
		this._infracao = _infracao;
	}
    
    

}
