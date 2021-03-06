﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class MovimentacaoPagamento
    {
        public string cliente;
        private decimal saldo;
        private decimal valorTotal;

        public string getCliente()
        {
            return cliente;
        }
        public decimal getSaldo()
        {
            return saldo;
        }
        public decimal getTotal()
        {
            return valorTotal;
        }

        public void setCliente(string cliente)
        {
            this.cliente = cliente;
        }
        public void setSaldo(decimal saldo)
        {
            this.saldo = saldo;
        }
        public void setTotal(decimal valor)
        {
            valorTotal = valor;
        }

        public decimal Pagamento()
        {
            return saldo -= valorTotal;
        }
        public void Recebimento(decimal valor)
        {
            saldo = valor;
        }
    }
}
