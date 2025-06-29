using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace primeraclase.models
{
    public class TiposDeDatos
    {
        //usando tipos de datos primitivos en C# para criacao de um objeto
        public string DatosDeUmCarro? { get; set; }
        public string Marca? { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }

        public void MostrarDatos()
        {
            Console.WriteLine($"Marca: {Marca}, Ano: {Ano}, Preço: {Preco:C}");
        }   
    }
}

