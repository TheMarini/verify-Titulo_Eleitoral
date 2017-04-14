using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj27757
{
    public partial class frm27757 : Form
    {
        public frm27757()
        {
            InitializeComponent();

            string[] estado = { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SE", "SC", "SP",  "TO", "Exterior" };
            int[] codigo = {     24,   17,   22,   25,   05,   07,   20,   14,   10,   11,   02,   19,   18,   13,   12,   08,   15,   06,   03,   16,   23,   26,   04,   21,   09,   01,    27,     28};

            foreach (string item in estado)
	        {
                if (item == "Exterior")
	            {
		            cbEstado.Items.Add("--------");
	            }
                
		        cbEstado.Items.Add(item);
	        }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedItem != "--------")
            {
                if (cls27757.valido)
                {
                    lblValido.ForeColor = Color.Green;
                    lblValido.Text = "Válido";
                }
                else
                {
                    lblValido.ForeColor = Color.Green;
                    lblValido.Text = "Inválido";
                }
            }
            else
            {
                cbEstado.SelectedItem = null;
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            cls27757.titulo = txtTitulo.Text;
            if (cls27757.titulo.Length == 12)
            {
                cbEstado.Enabled = true;
                lblValido.Text = "selecione seu estado";
            }
            else
            {
                cbEstado.Enabled = false;
                lblValido.Text = "digite seu título";
            }
        }


    }
}
