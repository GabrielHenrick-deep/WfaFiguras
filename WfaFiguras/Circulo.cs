using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfaFiguras.recurses;

namespace WfaFiguras
{
    public class Circulo:Formas
    {
        //Atributos
        private double raio;
        //Construtor
        public Circulo(string nome, double _raio):base(nome) 
        {
            raio = _raio;
        }
        //Métodos
        public override double Area()
        {
            return Math.PI * (Math.Pow(raio,2));
        }
        public override double Perimetro()
        {
            return 2*(Math.PI * raio);
        }
        public double Raio { get => raio; set => raio = value; }
    }
}//Fim da classe Circulo
