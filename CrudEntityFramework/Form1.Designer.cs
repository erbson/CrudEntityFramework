namespace CrudEntityFramework
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btmaximized = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btfechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnovo = new System.Windows.Forms.Button();
            this.btpesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_pesquisarcliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.btmaximized);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btfechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 68);
            this.panel1.TabIndex = 0;
            // 
            // btmaximized
            // 
            this.btmaximized.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btmaximized.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btmaximized.FlatAppearance.BorderSize = 0;
            this.btmaximized.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmaximized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btmaximized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmaximized.Image = ((System.Drawing.Image)(resources.GetObject("btmaximized.Image")));
            this.btmaximized.Location = new System.Drawing.Point(800, 14);
            this.btmaximized.Name = "btmaximized";
            this.btmaximized.Size = new System.Drawing.Size(39, 34);
            this.btmaximized.TabIndex = 2;
            this.btmaximized.UseVisualStyleBackColor = true;
            this.btmaximized.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(236, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Clientes";
            this.label1.UseMnemonic = false;
            // 
            // btfechar
            // 
            this.btfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btfechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btfechar.FlatAppearance.BorderSize = 0;
            this.btfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfechar.Image = ((System.Drawing.Image)(resources.GetObject("btfechar.Image")));
            this.btfechar.Location = new System.Drawing.Point(866, 14);
            this.btfechar.Name = "btfechar";
            this.btfechar.Size = new System.Drawing.Size(39, 34);
            this.btfechar.TabIndex = 0;
            this.btfechar.TabStop = false;
            this.btfechar.UseVisualStyleBackColor = true;
            this.btfechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnovo);
            this.panel2.Controls.Add(this.btpesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(725, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 405);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(198, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Atualizar Cadastro";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Apagar Cliente";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnovo
            // 
            this.btnovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnovo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnovo.FlatAppearance.BorderSize = 0;
            this.btnovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnovo.Image = ((System.Drawing.Image)(resources.GetObject("btnovo.Image")));
            this.btnovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnovo.Location = new System.Drawing.Point(3, 109);
            this.btnovo.Name = "btnovo";
            this.btnovo.Size = new System.Drawing.Size(198, 54);
            this.btnovo.TabIndex = 2;
            this.btnovo.Text = "Novo Cliente";
            this.btnovo.UseVisualStyleBackColor = true;
            this.btnovo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btpesquisar
            // 
            this.btpesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btpesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btpesquisar.FlatAppearance.BorderSize = 0;
            this.btpesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btpesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btpesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btpesquisar.Image")));
            this.btpesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btpesquisar.Location = new System.Drawing.Point(3, 43);
            this.btpesquisar.Name = "btpesquisar";
            this.btpesquisar.Size = new System.Drawing.Size(198, 54);
            this.btpesquisar.TabIndex = 1;
            this.btpesquisar.Text = "Pesquisar";
            this.btpesquisar.UseVisualStyleBackColor = true;
            this.btpesquisar.Click += new System.EventHandler(this.btpesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 387);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel3.Controls.Add(this.bt_pesquisarcliente);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Location = new System.Drawing.Point(29, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 113);
            this.panel3.TabIndex = 3;
            // 
            // bt_pesquisarcliente
            // 
            this.bt_pesquisarcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_pesquisarcliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_pesquisarcliente.FlatAppearance.BorderSize = 0;
            this.bt_pesquisarcliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_pesquisarcliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_pesquisarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_pesquisarcliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisarcliente.Image = ((System.Drawing.Image)(resources.GetObject("bt_pesquisarcliente.Image")));
            this.bt_pesquisarcliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_pesquisarcliente.Location = new System.Drawing.Point(525, 34);
            this.bt_pesquisarcliente.Name = "bt_pesquisarcliente";
            this.bt_pesquisarcliente.Size = new System.Drawing.Size(149, 47);
            this.bt_pesquisarcliente.TabIndex = 2;
            this.bt_pesquisarcliente.Text = "Pesquisar";
            this.bt_pesquisarcliente.UseVisualStyleBackColor = true;
            this.bt_pesquisarcliente.Click += new System.EventHandler(this.bt_pesquisarcliente_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(643, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 19);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 49);
            this.comboBox1.MaximumSize = new System.Drawing.Size(700, 0);
            this.comboBox1.MinimumSize = new System.Drawing.Size(500, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(500, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.l);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btfechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnovo;
        private System.Windows.Forms.Button btpesquisar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btmaximized;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_pesquisarcliente;
    }
}

