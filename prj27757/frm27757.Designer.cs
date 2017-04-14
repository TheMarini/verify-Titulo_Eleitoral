namespace prj27757
{
    partial class frm27757
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblValido = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.MaskedTextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblValido
            // 
            this.lblValido.AutoSize = true;
            this.lblValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValido.ForeColor = System.Drawing.Color.Gray;
            this.lblValido.Location = new System.Drawing.Point(8, 56);
            this.lblValido.Name = "lblValido";
            this.lblValido.Size = new System.Drawing.Size(134, 24);
            this.lblValido.TabIndex = 7;
            this.lblValido.Text = "digite seu título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.txtTitulo.ForeColor = System.Drawing.Color.Gray;
            this.txtTitulo.Location = new System.Drawing.Point(12, 12);
            this.txtTitulo.Mask = "0000 0000 0000";
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(260, 36);
            this.txtTitulo.TabIndex = 6;
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownHeight = 150;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Enabled = false;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.IntegralHeight = false;
            this.cbEstado.Location = new System.Drawing.Point(199, 57);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(73, 26);
            this.cbEstado.TabIndex = 8;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // frm27757
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 95);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblValido);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frm27757";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Título Eleitoral";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValido;
        private System.Windows.Forms.MaskedTextBox txtTitulo;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}

