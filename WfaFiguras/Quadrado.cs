using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfaFiguras.recurses;

namespace WfaFiguras
{
    public class Quadrado:Formas
    {
        private double lado;
        
        public  Quadrado(string nome, double _lado):base(nome) 
        {
            lado = _lado;
        }

        public override double Area()
        {
            return Math.Pow(lado,2);
        }
        public override double Perimetro()
        {
            return lado * 4;
        }
        public double Lado { get => lado; set => lado = value; }
    }
}
