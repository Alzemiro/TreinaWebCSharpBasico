﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEnumeradores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            cmbDias.DataSource = Enum.GetNames(typeof(DiasEnum));
        }

        private void btnExibirDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dia escolhido: " + Enum.GetName(typeof(DiasEnum), cmbDias.SelectedIndex));
        }
    }
}
