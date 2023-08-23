using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pclasse
{
    public partial class frnMensalista2 : Form
    {
        public frnMensalista2()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista2 = new Mensalista();
            objMensalista2.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista2.NomeEmpregado = txtNome.Text;
            objMensalista2.SalarioMensal = Convert.ToDouble(txtSalario.Text);
            objMensalista2.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            if (rbtnSIM.Checked)
                objMensalista2.HomeOffice = 'S';
            else
                objMensalista2.HomeOffice = 'N';

            //get
            MessageBox.Show("Matricula: " + objMensalista2.Matricula + "/n" +
                "Nome:" + objMensalista2.NomeEmpregado + "/n" +
                "DataEntrada: " +
                objMensalista2.DataEntradaEmpresa.ToShortDateString() +
                "/n" +
                "SalarioBruto: " + objMensalista2.SalarioBruto().ToString("N2")
                + "/n" +
                "Tempo Empresa (dias): " + objMensalista2.TempoTrabalho() +
                "/n" + objMensalista2.VerificaHome());

        }

        private void T_Click(object sender, EventArgs e)
        {

        }
    }
}