using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAcesso
{
    public class Operador : Funcionario, IValidavel
    {
        public Operador(string nome) : base(nome, "Operador de Pátio") {}

        public bool Validar()
        {
            Console.Write("-->[TECLADO] Digite sua senha (4 dígitos): ");
            string senha = Console.ReadLine();
            return senha == "1234";
        }
    }
}