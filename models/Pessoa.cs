using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeraclase.models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Ola meu Nome é: {Nome}, e minha Idade: {Idade}");
        }
    }
}



