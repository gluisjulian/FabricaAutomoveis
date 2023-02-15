using Automovel.Domain;
using DeskUtilDLL;
using Automovel.DAO;
using DTIForms.Util;
using NTIComponentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilDLL;

namespace FabricaAutomoveis
{
    public partial class Automoveis0001 : NTIForm
    {

        #region INICIALIZACAO
        public Automoveis0001()
        {
            InitializeComponent();
            configuraForm();
        }
        private void DTIFormPadrao_Load(object sender, EventArgs e)
        {
            Consultar();
        }
        #endregion

        #region METODOS
        private void Consultar()
        {
            var filtros = new NTIFiltro();

            if (!String.IsNullOrEmpty(tbmodeloAutomovel.Text))
                filtros.adiciona("modelo_automovel",
                                 tbmodeloAutomovel.Text,
                                 typeof(string),
                                 NTIFiltro._igual);

            if (!String.IsNullOrEmpty(tbanoAutomovel.Text))
                filtros.adiciona("ano_automovel",
                                 Convert.ToInt32(tbanoAutomovel.Text),
                                 typeof(int),
                                 NTIFiltro._igual);

            dgvPrincipal.DataSource = new AutomovelDAO().Listar(filtros);
            dgvPrincipal.Refresh();
        }

        private void Incluir()
        {
            var Manutencao = new Automoveis0001mn(new Automoveis(), "i");
            Manutencao.ShowDialog();
            Consultar();
        }

        private void Editar()
        {
            
            var lista = dgvPrincipal.DataSource as List<AutomovelDTO>;

            int indiceSelecionado = gridViewPrincipal.GetDataSourceRowIndex(gridViewPrincipal.FocusedRowHandle);

            var automovelselecionado = lista[indiceSelecionado];

            var automovel = new AutomovelDAO().Get(automovelselecionado.id_automovel);

            var form = new Automoveis0001mn(automovel, "a");
            form.ShowDialog();
            Consultar();
            

        }

        private void Excluir()
        {
         
            if (!DeskUtil.getResposta("Deseja realmente excluir?"))
                return;

            var lista = dgvPrincipal.DataSource as List<AutomovelDTO>;

            int indiceSelecionado = gridViewPrincipal.GetDataSourceRowIndex(gridViewPrincipal.FocusedRowHandle);

            var automovelselecionado = lista[indiceSelecionado];

            var automovel = new AutomovelDAO().Get(automovelselecionado.id_automovel);

            if (DTIFormsUtil.TratarRetornoPersistencia(new AutomovelDAO().delete(automovel)))
                Consultar();
             

        }

        private void MenuClick(object sender, EventArgs e)
        {
           
        }

        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void repositoryEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void repositoryExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
