using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleAcesso
{
    public abstract class Funcionario
    {
        private string nome;

        public string Nome
        {
            get => nome;
            set => nome = !string.IsNullOrEmpty(value) ? value : "Desconhecido";
        }

        public string Cargo { get; protected set; }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public void BoasVindas()
        {
            Console.WriteLine($"\nIndetificação: {Nome} | Cargo: {Cargo}");
        }
    }
}