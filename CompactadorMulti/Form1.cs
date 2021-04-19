using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
namespace CompactadorMulti
{
    public partial class Form1 : Form
    {

        public static DirectoryInfo directory = new DirectoryInfo(@"D:\_DESENVOLVIMENTO\CODIGO FONTE");
        public static string[] GetDirectory = Directory.GetDirectories(@"D:\_DESENVOLVIMENTO\CODIGO FONTE\");

        Collection<Arquivos> lista = new Collection<Arquivos>();
        FileInfo[] arquivos = directory.GetFiles(@"*.*");
        public Form1()
        {
            InitializeComponent();


            Arquivos obj = new Arquivos();
            //dataGridView1.ColumnAdded("teste");
            foreach (var item in GetDirectory)
            {

                lista.Add(new Arquivos { Nome = item });

            }



            //var a = arquivos;
            //dataGridView1.Width = 20000;

            dgvResultado.DataSource = lista;

        }

        public class Arquivos
        {
            public string Nome { get; set; }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvResultado.Rows[e.RowIndex].Cells[0].Value;
            txtCompactar.Text = name.ToString();
            var a = lista.First(a => a.Nome == name);
            lista.Remove(a);




        }

        private async void btnCompactar_Click(object sender, EventArgs e)
        {
            try
            {
                string diretorio = @"D:\_DESENVOLVIMENTO\CODIGO FONTE\Nova pasta";
                string arquivo = txtCompactar.Text /*=/* txtCompactar.Text + @"D:\_DESENVOLVIMENTO\CODIGO FONTE\blogDev.rar"*/ ;
                if (File.Exists(arquivo))
                {

                  


                    File.Delete(arquivo);
                }
                else
                {
              
                    ZipFile.CreateFromDirectory(diretorio, arquivo+".zip");
                  
                    MessageBox.Show("Concluido", "");
                }

            }
            catch (Exception a)
            {
                Console.WriteLine(a);
            }
        


        }
    }
}
