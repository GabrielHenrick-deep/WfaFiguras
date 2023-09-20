using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaFiguras.recurses
{
    public abstract class Formas
    {
        //Atributos
        private string nome;
        //Construtors
        public Formas(string _nome)
        {
            nome= _nome;
        }
        //Métodos
        public virtual double Area()
        {
            return 0.0;
        }
        public virtual double Perimetro()
        { 
            return 0.0; 
        }
        public string Nome { get => nome; set => nome = value; }
    }
}//Fim da classe Formas
