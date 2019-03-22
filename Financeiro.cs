using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Financeiro
    {
        private string cliente;
        private string veiculo;
        private string motorista;
        private decimal cnh;
        private decimal valorMulta;
        private decimal valorSeguro;
        private decimal valorCombustivel;
        private decimal valorServico;
        private decimal valorViagem;
        private decimal valorAluguel;

        public string getCliente()
        {
            return cliente;
        }
        public string getVeiculo()
        {
            return veiculo;
        }
        public string getMotorista()
        {
            return motorista;
        }
        public decimal getCNH()
        {
            return cnh;
        }
        public decimal getValorMulta()
        {
            return valorMulta;
        }
        public decimal getValorSeguro()
        {
            return valorSeguro;
        }
        public decimal getValorCombustivel()
        {
            return valorCombustivel;
        }
        public decimal getValorServico()
        {
            return valorServico;
        }
        public decimal getValorViagem()
        {
            return valorViagem;
        }
        public decimal getValorAluguel()
        {
            return valorAluguel;
        }

        public void setCliente(string cliente)
        {
            this.cliente = cliente;
        }
        public void setVeiculo(String veiculo)
        {
            this.veiculo = veiculo;
        }
        public void setMotorista(String motorista)
        {
            this.motorista = motorista;
        }
        public void setCNH(decimal cnh)
        {
            this.cnh = cnh;

        }
        public void setValorMulta(decimal valorMulta)
        {
            this.valorMulta = valorMulta;
        }
        public void setValorSeguro(decimal valorSeguro)
        {
            this.valorSeguro = valorSeguro;
        }
        public void serValorCombustivel(decimal valorCombustivel)
        {
            this.valorCombustivel = valorCombustivel;
        }
        public void setValorServico(decimal valorServico)
        {
            this.valorServico = valorServico;
        }
        public void setValorViagem(decimal valorViagem)
        {
            this.valorMulta = valorViagem;
        }
        public void setvalorAluguel(decimal valorAluguel)
        {
            this.valorAluguel = valorAluguel;
        }

        public decimal valorTotal()
        {
            return valorMulta + valorCombustivel + valorSeguro + valorServico + valorViagem + valorAluguel;
        }
    }
}
