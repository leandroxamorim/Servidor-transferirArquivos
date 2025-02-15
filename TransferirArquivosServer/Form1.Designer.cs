namespace TransferirArquivosServer
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.listaLogs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, -2);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(801, 95);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Servidor para Compartilhar Arquivos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoIP.Location = new System.Drawing.Point(12, 96);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(385, 31);
            this.txtEnderecoIP.TabIndex = 1;
            this.txtEnderecoIP.Text = "127.0.0.1";
            // 
            // txtPorta
            // 
            this.txtPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorta.Location = new System.Drawing.Point(403, 96);
            this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(120, 31);
            this.txtPorta.TabIndex = 2;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(12, 136);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(385, 52);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Estabelecer Conexão";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(403, 136);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(385, 52);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Parar Servidor";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.Location = new System.Drawing.Point(12, 202);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(776, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique aqui para selecionar uma pasta";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // listaLogs
            // 
            this.listaLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLogs.FormattingEnabled = true;
            this.listaLogs.ItemHeight = 25;
            this.listaLogs.Location = new System.Drawing.Point(12, 244);
            this.listaLogs.Name = "listaLogs";
            this.listaLogs.Size = new System.Drawing.Size(776, 229);
            this.listaLogs.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.listaLogs);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListBox listaLogs;
    }
}

