using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string Tab = "\t";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var linhas = textBoxEntrada.Text.Split(Environment.NewLine);
            var textoDeSaida = new StringBuilder();

            for (int i = 0; i < linhas.Length;)
            {
                textoDeSaida.Append(string.Concat(linhas[i++], Tab));
                textoDeSaida.Append(string.Concat(linhas[i++], Tab));
                textoDeSaida.Append(linhas[i++]);

                var textoTrasacao2 = linhas[i++];

                if(!textoTrasacao2.StartsWith("R$"))
                    textoDeSaida.Append(string.Concat(" ", textoTrasacao2, Tab, Tab, Tab, Tab, Tab));
                else
                {
                    textoDeSaida.Append(string.Concat(Tab, Tab, Tab, Tab, Tab));
                    i--;
                }


                textoDeSaida.Append(string.Concat(linhas[i++], Tab));
                textoDeSaida.Append(string.Concat(linhas[i++], Environment.NewLine));
            }

            textBoxSaida.Text = textoDeSaida.ToString();
        }
    }
}
