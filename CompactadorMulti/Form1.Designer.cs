
namespace CompactadorMulti
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameFile = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCompactar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.txtCompactar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDiretorioPrincipal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiretorioBackup = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 413);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 413);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(216)))));
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtNameFile);
            this.tabPage1.Controls.Add(this.dgvResultado);
            this.tabPage1.Controls.Add(this.btnEnviar);
            this.tabPage1.Controls.Add(this.btnCompactar);
            this.tabPage1.Controls.Add(this.txtEnviar);
            this.tabPage1.Controls.Add(this.txtCompactar);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compactar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Diretorio de Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(100, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Diretorio Zip";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(8, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome Zip";
            // 
            // txtNameFile
            // 
            this.txtNameFile.Location = new System.Drawing.Point(8, 232);
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.Size = new System.Drawing.Size(86, 23);
            this.txtNameFile.TabIndex = 15;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(8, 12);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 100;
            this.dgvResultado.RowTemplate.Height = 25;
            this.dgvResultado.Size = new System.Drawing.Size(506, 200);
            this.dgvResultado.TabIndex = 14;
            this.dgvResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEnviar.Location = new System.Drawing.Point(117, 322);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(285, 55);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Compactar ALL";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // btnCompactar
            // 
            this.btnCompactar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompactar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCompactar.Location = new System.Drawing.Point(398, 221);
            this.btnCompactar.Name = "btnCompactar";
            this.btnCompactar.Size = new System.Drawing.Size(116, 42);
            this.btnCompactar.TabIndex = 12;
            this.btnCompactar.Text = "Compactar";
            this.btnCompactar.UseVisualStyleBackColor = false;
            this.btnCompactar.Click += new System.EventHandler(this.btnCompactar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(8, 286);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(368, 23);
            this.txtEnviar.TabIndex = 11;
            // 
            // txtCompactar
            // 
            this.txtCompactar.Location = new System.Drawing.Point(100, 232);
            this.txtCompactar.Name = "txtCompactar";
            this.txtCompactar.Size = new System.Drawing.Size(276, 23);
            this.txtCompactar.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtDiretorioBackup);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtDiretorioPrincipal);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Configurar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtDiretorioPrincipal
            // 
            this.txtDiretorioPrincipal.Location = new System.Drawing.Point(18, 66);
            this.txtDiretorioPrincipal.Name = "txtDiretorioPrincipal";
            this.txtDiretorioPrincipal.Size = new System.Drawing.Size(485, 23);
            this.txtDiretorioPrincipal.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Diretorio Principal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Diretorio de Backup";
            // 
            // txtDiretorioBackup
            // 
            this.txtDiretorioBackup.Location = new System.Drawing.Point(19, 126);
            this.txtDiretorioBackup.Name = "txtDiretorioBackup";
            this.txtDiretorioBackup.Size = new System.Drawing.Size(485, 23);
            this.txtDiretorioBackup.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(530, 413);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameFile;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCompactar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.TextBox txtCompactar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtDiretorioPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiretorioBackup;
        private System.Windows.Forms.Label label4;
    }
}

