using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivosServer
{
    public partial class Form1 : Form
    {
        Task tarefa;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = FTServer.PastaRecepcaoArquivos;
            FTServer.ListaMensagem = listaLogs;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            int porta = (int)txtPorta.Value;
            string endIP = txtEnderecoIP.Text;
            try
            {
                FTServer.EnderecoIP = endIP;
                FTServer.PortaHost = porta;

                tarefa = Task.Factory.StartNew(() => { FTServer.IniciarServidor(); });
            }
            catch (Exception ex)
            {
                listaLogs.Invoke(new Action(()=>{
                    listaLogs.Items.Add("Erro ao iniciar: " + ex.Message);
                    listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
                }));
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try 
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                listaLogs.Invoke(new Action(() => {
                    listaLogs.Items.Add("Erro: " + ex.Message);
                    listaLogs.SetSelected(listaLogs.Items.Count - 1, true);
                }));
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.PastaRecepcaoArquivos = dialog.SelectedPath + @"\";
                linkLabel1.Text = FTServer.PastaRecepcaoArquivos;
            }
        }
    }
}
