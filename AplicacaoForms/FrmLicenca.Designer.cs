
namespace AplicacaoForms
{
    partial class FrmLicenca
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
            this.btnObterLicenca = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnObterLicenca
            // 
            this.btnObterLicenca.Location = new System.Drawing.Point(12, 12);
            this.btnObterLicenca.Name = "btnObterLicenca";
            this.btnObterLicenca.Size = new System.Drawing.Size(136, 62);
            this.btnObterLicenca.TabIndex = 0;
            this.btnObterLicenca.Text = "Obter licença";
            this.btnObterLicenca.UseVisualStyleBackColor = true;
            this.btnObterLicenca.Click += new System.EventHandler(this.btnObterLicenca_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(154, 31);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(374, 22);
            this.txtChave.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(546, 11);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 62);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 107);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnObterLicenca);
            this.Name = "FrmLicenca";
            this.Text = "FrmLicenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObterLicenca;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button btnRegistrar;
    }
}