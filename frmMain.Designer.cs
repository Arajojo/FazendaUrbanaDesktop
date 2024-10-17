namespace FazendaUrbanaDesktop
{
    partial class frmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOS = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.combListagem = new System.Windows.Forms.ComboBox();
            this.dgRelatorio = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnOS);
            this.panel2.Controls.Add(this.btnCliente);
            this.panel2.Controls.Add(this.btnFornecedor);
            this.panel2.Controls.Add(this.btnProduto);
            this.panel2.Controls.Add(this.btnFuncionario);
            this.panel2.Controls.Add(this.btnRelatorio);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 41);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de fazenda urbana";
            // 
            // btnOS
            // 
            this.btnOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnOS.FlatAppearance.BorderSize = 0;
            this.btnOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOS.Location = new System.Drawing.Point(390, 3);
            this.btnOS.Name = "btnOS";
            this.btnOS.Size = new System.Drawing.Size(75, 35);
            this.btnOS.TabIndex = 7;
            this.btnOS.Text = "Gerar OS";
            this.btnOS.UseVisualStyleBackColor = false;
            this.btnOS.Click += new System.EventHandler(this.btnOS_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCliente.Location = new System.Drawing.Point(471, 3);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(142, 35);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Cadastro de cliente";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFornecedor.Location = new System.Drawing.Point(619, 3);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(169, 35);
            this.btnFornecedor.TabIndex = 5;
            this.btnFornecedor.Text = "Cadastro de fornecedor";
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProduto.FlatAppearance.BorderSize = 0;
            this.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProduto.Location = new System.Drawing.Point(794, 3);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(148, 35);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "Cadastro de produto";
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFuncionario.Location = new System.Drawing.Point(948, 3);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(171, 35);
            this.btnFuncionario.TabIndex = 3;
            this.btnFuncionario.Text = "Cadastro de funcionário";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.Location = new System.Drawing.Point(1125, 3);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(120, 35);
            this.btnRelatorio.TabIndex = 2;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            // 
            // combListagem
            // 
            this.combListagem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combListagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.combListagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combListagem.FormattingEnabled = true;
            this.combListagem.Items.AddRange(new object[] {
            "Listar ordens de serviços",
            "Listar clientes",
            "Listar fornecedores",
            "Listar produtos",
            "Listar funcionários"});
            this.combListagem.Location = new System.Drawing.Point(12, 89);
            this.combListagem.Name = "combListagem";
            this.combListagem.Size = new System.Drawing.Size(228, 21);
            this.combListagem.TabIndex = 2;
            this.combListagem.SelectedIndexChanged += new System.EventHandler(this.combListagem_SelectedIndexChanged);
            // 
            // dgRelatorio
            // 
            this.dgRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRelatorio.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRelatorio.Location = new System.Drawing.Point(11, 116);
            this.dgRelatorio.Name = "dgRelatorio";
            this.dgRelatorio.Size = new System.Drawing.Size(1249, 433);
            this.dgRelatorio.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1273, 561);
            this.Controls.Add(this.dgRelatorio);
            this.Controls.Add(this.combListagem);
            this.Controls.Add(this.panel2);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button btnOS;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combListagem;
        private System.Windows.Forms.DataGridView dgRelatorio;
    }
}