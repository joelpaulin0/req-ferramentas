using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReqFerramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmColaboradores frm = new FrmColaboradores(); 
            frm.ShowDialog();
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            frmFerramentas frm = new frmFerramentas();
            frm.ShowDialog();
        }

        private void btnRequisicoes_Click(object sender, EventArgs e)
        {
            frmRequisitos frm = new frmRequisitos();
            frm.ShowDialog();
        }
    }
}
