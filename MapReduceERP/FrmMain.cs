using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapReduceERP
{
    public partial class FrmMain : Form
    {
        String nomarxiu1, nomarxiu2, nomarxiu3;

        String contingutarxiu1 = String.Empty,contingutarxiu2 = String.Empty, contingutarxiu3 = String.Empty;

        Hashtable taulaHash;

        private void btnExportar_Click(object sender, EventArgs e)
        {



            //Aqui farem  un foreach per cada element que hi hagi a dins d'una string, abans haurem de polir les strings treient els salts de linia

            corregirStrings();

            afegirdadestaulaHash();

            mostrardadeslistbox();
        }

        private void mostrardadeslistbox()
        {
            foreach(char key in taulaHash.Keys)
            {
                String dadacompleta = key + "," + taulaHash[key].ToString();
                lbLlistaCompletaParaules.Items.Add(dadacompleta);
            }
        }

        private void afegirdadestaulaHash()
        {
            taulaHash = new Hashtable();

            foreach (char caracter in contingutarxiu1)
            {
                if (!taulaHash.ContainsKey(caracter))
                {
                    taulaHash.Add(caracter, 1);
                }
                else
                {
                    int valor = (int)taulaHash[caracter];
                    taulaHash[caracter] = valor + 1;
                }
            }

            foreach (char caracter in contingutarxiu2)
            {
                if (!taulaHash.ContainsKey(caracter))
                {
                    taulaHash.Add(caracter, 1);
                }
                else
                {
                    int valor = (int)taulaHash[caracter];
                    taulaHash[caracter] = valor + 1;
                }
            }

            foreach (char caracter in contingutarxiu2)
            {
                if (!taulaHash.ContainsKey(caracter))
                {
                    taulaHash.Add(caracter, 1);
                }
                else
                {
                    int valor = (int)taulaHash[caracter];
                    taulaHash[caracter] = valor + 1;
                }
            }
        }

        private void corregirStrings()
        {
            contingutarxiu1 = contingutarxiu1.Trim().ToUpper().Replace(" ", "").Replace(",", "").Replace(".", "");
            contingutarxiu2 = contingutarxiu2.Trim().ToUpper().Replace(" ", "").Replace(",", "").Replace(".", "");
            contingutarxiu3 = contingutarxiu3.Trim().ToUpper().Replace(" ", "").Replace(",", "").Replace(".", "");
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnObrirArxiu1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                nomarxiu1 = openFileDialog.FileName;
                tbArxiu1.Text = nomarxiu1;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    contingutarxiu1 = reader.ReadToEnd();
                }
            }
        }

        private void btnObrirArxiu2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                nomarxiu2 = openFileDialog.FileName;
                tbArxiu2.Text = nomarxiu2;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    contingutarxiu2 = reader.ReadToEnd();
                }
            }
        }

        private void btnObrirArxiu3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                nomarxiu3 = openFileDialog.FileName;
                tbArxiu3.Text = nomarxiu3;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    contingutarxiu3 = reader.ReadToEnd();
                }
            }
        }



    }
}
