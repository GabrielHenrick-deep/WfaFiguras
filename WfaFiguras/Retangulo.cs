using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WfaFiguras.recurses;

namespace WfaFiguras
{
    public class Retangulo:Formas
    {
        private double baseRetangulo;
        private double HRetangulo;

        public Retangulo(string nome, double _baseRetangulo, double _HRetangulo):base(nome)
        {
            baseRetangulo = _baseRetangulo;
            HRetangulo = _HRetangulo;
        }

        public double BaseRetangulo { get => baseRetangulo; set => baseRetangulo = value; }
        public double HRetangulo1 { get => HRetangulo; set => HRetangulo = value; }

        public override double Area()
        {
            return (baseRetangulo * HRetangulo) ;
        }
        public override double Perimetro()
        {
            return (baseRetangulo*2 + HRetangulo*2);
        }
    }
}
