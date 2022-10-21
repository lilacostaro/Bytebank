using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bytebank.Titular;

namespace Bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }


        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set 
            { 
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
                 
            }
        }
        //private string conta;
        //public string Conta
        //{
        //    get { return this.conta; }
        //    set { this.conta = value; }
        //}
        public string Conta { get; set; }
        //private Cliente titlar;
        //public Cliente Titlar
        //{
        //    get { return this.titlar; }
        //    set { this.titlar = value; }
        //}
        private double saldo = 100;

        public ContaCorrente(int numero_agencia, string conta, double saldo, Cliente titular)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            this.saldo = saldo;
            Titular = titular;
            TotalDeContasCriadas++;
        }

        public Cliente Titular { get; set; }
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }

        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void Informcoes_conta()
        {
            Console.WriteLine($"Agencia: {this.numero_agencia}");
            Console.WriteLine($"Conta: {this.Conta}");
            Console.WriteLine($"titular: {this.Titular.Nome}");
            Console.WriteLine($"Saldo: {this.saldo}");
        }

        public void SetSaldo(double valor)
        {
            if(valor < saldo)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }
}
