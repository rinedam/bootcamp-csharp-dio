using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsPoo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Saldo atual: {saldo:C}");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque de {valor:C}. Saldo atual: {saldo:C}");
            }
        }
    }
}