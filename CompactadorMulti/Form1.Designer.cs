
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCompactar
            // 
            this.txtCompactar.Location = new System.Drawing.Point(12, 246);
            this.txtCompactar.Name = "txtCompactar";
            this.txtCompactar.Size = new System.Drawing.Size(368, 23);
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
            this.btnCompactar.Location = new System.Drawing.Point(404, 227);
            this.btnCompactar.Name = "btnCompactar";
            this.btnCompactar.Size = new System.Drawing.Size(116, 42);
            this.btnCompactar.TabIndex = 3;
            this.btnCompactar.Text = "Compactar";
            this.btnCompactar.UseVisualStyleBackColor = true;
            this.btnCompactar.Click += new System.EventHandler(this.btnCompactar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(404, 283);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(116, 42);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 413);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCompactar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.txtCompactar);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

