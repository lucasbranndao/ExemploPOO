using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal saldo);
        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é: {saldo}");
        }

    }
}