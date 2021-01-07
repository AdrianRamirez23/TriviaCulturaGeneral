using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TriviaCulturaGeneral
{
    public partial class MessageBoxForm1 : Form
    {
        public MessageBoxForm1(string respuesta)
        {
            InitializeComponent();
            lblMess.Text = respuesta;
        }

        private void MessageBoxForm1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
