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

        public static DirectoryInfo directory = new DirectoryInfo(@"E:\_VERSIONAMENTO-BITBUCKET");
        public static string[] GetDirectory = Directory.GetDirectories(@"E:\_VERSIONAMENTO-BITBUCKET\");

        Collection<Arquivos> lista = new Collection<Arquivos>();
        FileInfo[] arquivos = directory.GetFiles(@"*.*");
        public Form1()
        {
            InitializeComponent();


            Arquivos obj = new Arquivos();
            //dataGridView1.ColumnAdded("teste");
            foreach (var item in GetDirectory)
            {
                FileInfo filein = new FileInfo(item);

                lista.Add(new Arquivos { Nome = filein.Name,Diretorio = item });
            }

            //var a = arquivos;
            //dataGridView1.Width = 20000;

            dgvResultado.DataSource = lista;

        }

        public class Arquivos
        {
            public string Diretorio { get; set; }

            public string Nome { get; set; }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvResultado.Rows[e.RowIndex].Cells[0].Value;
            txtCompactar.Text = name.ToString();

            //var a = lista.First(a => a.Diretorio == name);

            FileInfo filein = new FileInfo(name.ToString());
            txtNameFile.Text = filein.Name;
            //MessageBox.Show(filein.Name,"teste");
            //var a = lista.First(a => a.Nome == name);
            //lista.Remove(a);




        }

        private async void btnCompactar_Click(object sender, EventArgs e)
        {
            try
            {
                 Compactar(txtCompactar.Text);

                Rename(txtCompactar.Text + ".zip", @$"E:\_VERSIONAMENTO-BITBUCKET\{txtNameFile.Text} {DateTime.Now.ToString("dd-MM-yyyy  HH-mm-ss")}.zip");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString(), "");
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public async void Compactar(string dir)
        {

            string parent = Path.GetDirectoryName(dir);
            string name = Path.GetFileName(dir) + ".zip";

            string fileName = Path.Combine(parent, name);


            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

           ZipFile.CreateFromDirectory(dir, fileName, CompressionLevel.Fastest, true);

            MessageBox.Show("Concluido", "");


        }


        public void Rename(string originalName , string NewName)
        {
            File.Move(originalName, NewName);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //try
        //{
        //    //    string diretorio = @"D:\_DESENVOLVIMENTO\CODIGO FONTE";
        //    string arquivo = txtCompactar.Text /*=/* txtCompactar.Text + @"D:\_DESENVOLVIMENTO\CODIGO FONTE\blogDev.rar"*/ ;
        //    if (File.Exists(arquivo))
        //    {




        //        File.Delete(arquivo);
        //    }
        //    else
        //    {



        //        ZipFile.CreateFromDirectory(diretorio, arquivo+".zip");

        //        MessageBox.Show("Concluido", "");
        //    }

        //}
        //catch (Exception a)
        //{
        //    Console.WriteLine(a);
        //}
    }
}
