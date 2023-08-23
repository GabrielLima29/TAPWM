using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pclasse
{
    abstract class Empregado
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula // propriedadde
        {
            get { return matricula; }
            set { matricula = value; }

        }

        public string NomeEmpregado
        {
            get { return NomeEmpregado; }
            set { nomeEmpregado = value; }

        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice 
        {
            get {return homeOffice; }
            set { homeOffice = value; }
        }
        //métodos

        public String VerificaHome()//mètodo
        {

            if (homeOffice == 'S')
                return "Empregado trabalha em home office";
            else
                return "Empregado Não trabalha em home office";

        }

        //virtual --> pode ser sobreescrito

        public virtual int TempoTrabalho()
        {
            TimeSpan span = DateTime.Today.Subtract
                (DataEntradaEmpresa);

            return (span.Days);
        }
        public abstract double SalarioBruto();
           

    }
}
