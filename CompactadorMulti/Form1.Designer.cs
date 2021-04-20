
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
            this.txtCompactar = new System.Windows.Forms.TextBox();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnCompactar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.txtNameFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompactar
            // 
            this.txtCompactar.Location = new System.Drawing.Point(104, 246);
            this.txtCompactar.Name = "txtCompactar";
            this.txtCompactar.Size = new System.Drawing.Size(276, 23);
            this.txtCompactar.TabIndex = 0;
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(12, 300);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(368, 23);
            this.txtEnviar.TabIndex = 1;
            // 
            // btnCompactar
            // 
            this.btnCompactar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCompactar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCompactar.Location = new System.Drawing.Point(404, 227);
            this.btnCompactar.Name = "btnCompactar";
            this.btnCompactar.Size = new System.Drawing.Size(116, 42);
            this.btnCompactar.TabIndex = 3;
            this.btnCompactar.Text = "Compactar";
            this.btnCompactar.UseVisualStyleBackColor = false;
            this.btnCompactar.Click += new System.EventHandler(this.btnCompactar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEnviar.Location = new System.Drawing.Point(404, 283);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(116, 42);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            // 
            // dgvResultado
            // 
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(12, 12);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.RowHeadersWidth = 100;
            this.dgvResultado.RowTemplate.Height = 25;
            this.dgvResultado.Size = new System.Drawing.Size(506, 209);
            this.dgvResultado.TabIndex = 5;
            this.dgvResultado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNameFile
            // 
            this.txtNameFile.Location = new System.Drawing.Point(12, 246);
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.Size = new System.Drawing.Size(86, 23);
            this.txtNameFile.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome Zip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Diretorio Zip";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(530, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameFile);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCompactar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.txtCompactar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompactar;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnCompactar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TextBox txtNameFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

