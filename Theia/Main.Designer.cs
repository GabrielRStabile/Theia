
namespace Theia
{
    partial class Main
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
            this.barraDeBusca = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.Panel();
            this.testamentoIndicador = new System.Windows.Forms.Label();
            this.procuracaoIndicador = new System.Windows.Forms.Label();
            this.Filtros = new System.Windows.Forms.Label();
            this.inventarioIndicador = new System.Windows.Forms.Label();
            this.vendaECompraIndicador = new System.Windows.Forms.Label();
            this.tudoIndicador = new System.Windows.Forms.Label();
            this.TestamentoSecao = new System.Windows.Forms.Label();
            this.ProcuracaoSecao = new System.Windows.Forms.Label();
            this.VendaECompraSecao = new System.Windows.Forms.Label();
            this.TudoSecao = new System.Windows.Forms.Label();
            this.marginBarraDeBusca = new System.Windows.Forms.Panel();
            this.tituloBarraDeBusca = new System.Windows.Forms.Label();
            this.InventarioSecao = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.marginBarraDeBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraDeBusca
            // 
            this.barraDeBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.barraDeBusca.BackColor = System.Drawing.Color.White;
            this.barraDeBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.barraDeBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.barraDeBusca.Font = new System.Drawing.Font("Nirmala UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barraDeBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.barraDeBusca.Location = new System.Drawing.Point(20, 0);
            this.barraDeBusca.Name = "barraDeBusca";
            this.barraDeBusca.Size = new System.Drawing.Size(852, 40);
            this.barraDeBusca.TabIndex = 0;
            // 
            // header
            // 
            this.header.Controls.Add(this.testamentoIndicador);
            this.header.Controls.Add(this.procuracaoIndicador);
            this.header.Controls.Add(this.Filtros);
            this.header.Controls.Add(this.inventarioIndicador);
            this.header.Controls.Add(this.vendaECompraIndicador);
            this.header.Controls.Add(this.tudoIndicador);
            this.header.Controls.Add(this.TestamentoSecao);
            this.header.Controls.Add(this.ProcuracaoSecao);
            this.header.Controls.Add(this.VendaECompraSecao);
            this.header.Controls.Add(this.TudoSecao);
            this.header.Controls.Add(this.marginBarraDeBusca);
            this.header.Controls.Add(this.tituloBarraDeBusca);
            this.header.Location = new System.Drawing.Point(-1, 1);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(932, 123);
            this.header.TabIndex = 1;
            // 
            // testamentoIndicador
            // 
            this.testamentoIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.testamentoIndicador.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testamentoIndicador.ForeColor = System.Drawing.Color.White;
            this.testamentoIndicador.Location = new System.Drawing.Point(402, 113);
            this.testamentoIndicador.Name = "testamentoIndicador";
            this.testamentoIndicador.Size = new System.Drawing.Size(90, 3);
            this.testamentoIndicador.TabIndex = 13;
            this.testamentoIndicador.Visible = false;
            // 
            // procuracaoIndicador
            // 
            this.procuracaoIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.procuracaoIndicador.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procuracaoIndicador.ForeColor = System.Drawing.Color.White;
            this.procuracaoIndicador.Location = new System.Drawing.Point(304, 112);
            this.procuracaoIndicador.Name = "procuracaoIndicador";
            this.procuracaoIndicador.Size = new System.Drawing.Size(85, 3);
            this.procuracaoIndicador.TabIndex = 12;
            this.procuracaoIndicador.Visible = false;
            // 
            // Filtros
            // 
            this.Filtros.AutoSize = true;
            this.Filtros.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtros.ForeColor = System.Drawing.Color.White;
            this.Filtros.Location = new System.Drawing.Point(829, 90);
            this.Filtros.Name = "Filtros";
            this.Filtros.Size = new System.Drawing.Size(68, 25);
            this.Filtros.TabIndex = 11;
            this.Filtros.Text = "Filtros ⇲";
            this.Filtros.Click += new System.EventHandler(this.Filtros_Click);
            // 
            // inventarioIndicador
            // 
            this.inventarioIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.inventarioIndicador.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventarioIndicador.ForeColor = System.Drawing.Color.White;
            this.inventarioIndicador.Location = new System.Drawing.Point(214, 112);
            this.inventarioIndicador.Name = "inventarioIndicador";
            this.inventarioIndicador.Size = new System.Drawing.Size(80, 3);
            this.inventarioIndicador.TabIndex = 10;
            this.inventarioIndicador.Visible = false;
            // 
            // vendaECompraIndicador
            // 
            this.vendaECompraIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.vendaECompraIndicador.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendaECompraIndicador.ForeColor = System.Drawing.Color.White;
            this.vendaECompraIndicador.Location = new System.Drawing.Point(77, 112);
            this.vendaECompraIndicador.Name = "vendaECompraIndicador";
            this.vendaECompraIndicador.Size = new System.Drawing.Size(130, 3);
            this.vendaECompraIndicador.TabIndex = 9;
            this.vendaECompraIndicador.Visible = false;
            // 
            // tudoIndicador
            // 
            this.tudoIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.tudoIndicador.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tudoIndicador.ForeColor = System.Drawing.Color.White;
            this.tudoIndicador.Location = new System.Drawing.Point(24, 112);
            this.tudoIndicador.Name = "tudoIndicador";
            this.tudoIndicador.Size = new System.Drawing.Size(47, 3);
            this.tudoIndicador.TabIndex = 8;
            // 
            // TestamentoSecao
            // 
            this.TestamentoSecao.AutoSize = true;
            this.TestamentoSecao.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestamentoSecao.ForeColor = System.Drawing.Color.White;
            this.TestamentoSecao.Location = new System.Drawing.Point(400, 88);
            this.TestamentoSecao.Name = "TestamentoSecao";
            this.TestamentoSecao.Size = new System.Drawing.Size(96, 25);
            this.TestamentoSecao.TabIndex = 7;
            this.TestamentoSecao.Text = "Testamento";
            this.TestamentoSecao.Click += new System.EventHandler(this.TestamentoSecao_Click);
            // 
            // ProcuracaoSecao
            // 
            this.ProcuracaoSecao.AutoSize = true;
            this.ProcuracaoSecao.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcuracaoSecao.ForeColor = System.Drawing.Color.White;
            this.ProcuracaoSecao.Location = new System.Drawing.Point(301, 88);
            this.ProcuracaoSecao.Name = "ProcuracaoSecao";
            this.ProcuracaoSecao.Size = new System.Drawing.Size(93, 25);
            this.ProcuracaoSecao.TabIndex = 6;
            this.ProcuracaoSecao.Text = "Procuração";
            this.ProcuracaoSecao.Click += new System.EventHandler(this.ProcuracaoSecao_Click);
            // 
            // VendaECompraSecao
            // 
            this.VendaECompraSecao.AutoSize = true;
            this.VendaECompraSecao.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendaECompraSecao.ForeColor = System.Drawing.Color.White;
            this.VendaECompraSecao.Location = new System.Drawing.Point(77, 87);
            this.VendaECompraSecao.Name = "VendaECompraSecao";
            this.VendaECompraSecao.Size = new System.Drawing.Size(131, 25);
            this.VendaECompraSecao.TabIndex = 4;
            this.VendaECompraSecao.Text = "Venda e Compra";
            this.VendaECompraSecao.Click += new System.EventHandler(this.VendaECompraSecao_Click);
            // 
            // TudoSecao
            // 
            this.TudoSecao.AutoSize = true;
            this.TudoSecao.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TudoSecao.ForeColor = System.Drawing.Color.White;
            this.TudoSecao.Location = new System.Drawing.Point(24, 86);
            this.TudoSecao.Name = "TudoSecao";
            this.TudoSecao.Size = new System.Drawing.Size(47, 25);
            this.TudoSecao.TabIndex = 3;
            this.TudoSecao.Text = "Tudo";
            this.TudoSecao.Click += new System.EventHandler(this.TudoSecao_Click);
            // 
            // marginBarraDeBusca
            // 
            this.marginBarraDeBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marginBarraDeBusca.BackColor = System.Drawing.Color.White;
            this.marginBarraDeBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marginBarraDeBusca.Controls.Add(this.barraDeBusca);
            this.marginBarraDeBusca.Location = new System.Drawing.Point(24, 28);
            this.marginBarraDeBusca.Name = "marginBarraDeBusca";
            this.marginBarraDeBusca.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.marginBarraDeBusca.Size = new System.Drawing.Size(873, 44);
            this.marginBarraDeBusca.TabIndex = 1;
            // 
            // tituloBarraDeBusca
            // 
            this.tituloBarraDeBusca.AutoSize = true;
            this.tituloBarraDeBusca.BackColor = System.Drawing.Color.Transparent;
            this.tituloBarraDeBusca.Font = new System.Drawing.Font("Poppins Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloBarraDeBusca.ForeColor = System.Drawing.Color.White;
            this.tituloBarraDeBusca.Location = new System.Drawing.Point(24, 4);
            this.tituloBarraDeBusca.Name = "tituloBarraDeBusca";
            this.tituloBarraDeBusca.Size = new System.Drawing.Size(285, 30);
            this.tituloBarraDeBusca.TabIndex = 2;
            this.tituloBarraDeBusca.Text = "Quem você deseja buscar hoje?";
            // 
            // InventarioSecao
            // 
            this.InventarioSecao.AutoSize = true;
            this.InventarioSecao.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventarioSecao.ForeColor = System.Drawing.Color.White;
            this.InventarioSecao.Location = new System.Drawing.Point(213, 89);
            this.InventarioSecao.Name = "InventarioSecao";
            this.InventarioSecao.Size = new System.Drawing.Size(81, 25);
            this.InventarioSecao.TabIndex = 5;
            this.InventarioSecao.Text = "Inventário";
            this.InventarioSecao.Click += new System.EventHandler(this.InventarioSecao_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(929, 133);
            this.Controls.Add(this.InventarioSecao);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theia // Ambiente de Desenvolvimento";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.marginBarraDeBusca.ResumeLayout(false);
            this.marginBarraDeBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barraDeBusca;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel marginBarraDeBusca;
        private System.Windows.Forms.Label ProcuracaoSecao;
        private System.Windows.Forms.Label VendaECompraSecao;
        private System.Windows.Forms.Label TudoSecao;
        private System.Windows.Forms.Label InventarioSecao;
        private System.Windows.Forms.Label TestamentoSecao;
        public System.Windows.Forms.Label tudoIndicador;
        public System.Windows.Forms.Label vendaECompraIndicador;
        private System.Windows.Forms.Label tituloBarraDeBusca;
        private System.Windows.Forms.Label Filtros;
        public System.Windows.Forms.Label procuracaoIndicador;
        public System.Windows.Forms.Label testamentoIndicador;
        public System.Windows.Forms.Label inventarioIndicador;
    }
}

