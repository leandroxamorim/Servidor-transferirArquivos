namespace TransferirArquivoCliente
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPortaHost = new System.Windows.Forms.NumericUpDown();
            this.txtArquivo = new System.Windows.Forms.LinkLabel();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente para Compartilhar Arquivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoIP.Location = new System.Drawing.Point(11, 88);
            this.txtEnderecoIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(363, 35);
            this.txtEnderecoIP.TabIndex = 1;
            this.txtEnderecoIP.Text = "127.0.0.1";
            // 
            // txtPortaHost
            // 
            this.txtPortaHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPortaHost.Location = new System.Drawing.Point(384, 88);
            this.txtPortaHost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPortaHost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPortaHost.Name = "txtPortaHost";
            this.txtPortaHost.Size = new System.Drawing.Size(96, 35);
            this.txtPortaHost.TabIndex = 2;
            this.txtPortaHost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.txtArquivo.Location = new System.Drawing.Point(164, 147);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(476, 23);
            this.txtArquivo.TabIndex = 3;
            this.txtArquivo.TabStop = true;
            this.txtArquivo.Text = "Clique para selecionar um arquivo";
            this.txtArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtArquivo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.txtArquivo_LinkClicked);
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarArquivo.Location = new System.Drawing.Point(11, 193);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(469, 57);
            this.btnEnviarArquivo.TabIndex = 4;
            this.btnEnviarArquivo.Text = "Enviar Arquivo";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.btnEnviarArquivo_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Location = new System.Drawing.Point(12, 270);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(776, 171);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnEnviarArquivo);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.txtPortaHost);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtPortaHost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.NumericUpDown txtPortaHost;
        private System.Windows.Forms.LinkLabel txtArquivo;
        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.Label labelStatus;
    }
}

