using System;
using System.Windows.Forms;

namespace Theia
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static void EsconderTudo()
        {
            var indicadores = Theia.Main.ActiveForm as Main;
            indicadores.tudoIndicador.Visible = false;
            indicadores.procuracaoIndicador.Visible = false;
            indicadores.NotasIndicador.Visible = false;
            indicadores.inventarioIndicador.Visible = false;
            indicadores.testamentoIndicador.Visible = false;
            return;

        }
        

        private void TudoSecao_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            tudoIndicador.Visible = true;
        }

        private void VendaECompraSecao_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            NotasIndicador.Visible = true;
        }

        private void InventarioSecao_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            inventarioIndicador.Visible = true;
        }

        private void ProcuracaoSecao_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            procuracaoIndicador.Visible = true;
        }

        private void TestamentoSecao_Click(object sender, EventArgs e)
        {
            EsconderTudo();
            testamentoIndicador.Visible = true;
        }

        private void Filtros_Click(object sender, EventArgs e)
        {
            Filters formPesquisa = new Filters();
            formPesquisa.ShowDialog();

        }
    }
}
