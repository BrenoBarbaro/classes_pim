using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Cliente
    {
        private string nome;
        private string CPF;
        private string email;
        private string telefone;
        private DateTime dt_Nascimento;
        private string endereco;

        public string getNome()
        {
            return nome;
        }
        public string getCPF()
        {
            return CPF;
        }
        public string getEmail()
        {
            return email;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public DateTime getDtNascimento()
        {
            return dt_Nascimento;
        }
        public string getEndereco()
        {
            return endereco;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setCPF(string cpf)
        {
            this.CPF = cpf;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public void setNascimento(DateTime nascimento)
        {
            this.dt_Nascimento = nascimento;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
    }
}
