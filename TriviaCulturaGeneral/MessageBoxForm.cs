using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TriviaCulturaGeneral
{
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm(string respuesta )
        {
            InitializeComponent();
            lblMesOk.Text = respuesta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
