using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfaFiguras.recurses;

namespace WfaFiguras
{
    public class Triangulo:Formas
    {
        private double baseTriangulo;
        private double Htriangulo;

        public Triangulo(string nome, double _baseTriangulo, double _Htriangulo):base(nome)
        {
            baseTriangulo = _baseTriangulo;
            Htriangulo  = _Htriangulo;
        }

        public override double Area()
        {
            return (baseTriangulo * Htriangulo)/2;
        }

        public override double Perimetro()
        {
            return (baseTriangulo + (2*Math.Sqrt(Math.Pow((baseTriangulo/2),2) + Math.Pow(Htriangulo,2))));
        }
        public double BaseTriangulo { get => baseTriangulo; set => baseTriangulo = value; }
        public double Htriangulo1 { get => Htriangulo; set => Htriangulo = value; }
    }
}
