
using Automovel.DAO;
using Automovel.Domain;
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

namespace FabricaAutomoveis
{
    public partial class Automoveis0001mn : NTIForm
    {
        private string _OPERACAO;
        private Automoveis _Dominio;

        public Automoveis0001mn(Automoveis dominio, string operacao)
        {
            InitializeComponent();
            configuraForm();
            _OPERACAO = operacao;
            _Dominio = dominio;
        }

        private void AtualizaTela()
        {
            tbAnoAutomovel.Text = _Dominio.anoAutomovel.ToString(); //<3
            tbModeloAutomovel.Text = _Dominio.modeloAutomovel; 
        }

        private void AtualizarObjeto()
        {
            _Dominio.modeloAutomovel = tbModeloAutomovel.Text; // :(
            _Dominio.anoAutomovel = Convert.ToInt32(tbAnoAutomovel.Text);
        }

        private void LimparTela()
        {
            tbModeloAutomovel.Clear();
            tbAnoAutomovel.Clear();
        }

        private void DTIFormManutencao_Load(object sender, EventArgs e)
        {
            if (_OPERACAO == "a")
            {
                AtualizaTela();
                btnGravarContinuar.Visible = false;
            }

        }


        private string Gravar()
        {
            
            if (_OPERACAO == "a")
            {
                var dao = new AutomovelDAO();
                return dao.update(_Dominio);
            }
            else if (_OPERACAO == "i")
            {
                var dao = new AutomovelDAO();
                return dao.insert(_Dominio);
            }
            return null;

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            
            AtualizarObjeto();

            if (!DTIFormsUtil.ValidarDominio(_Dominio))
                return;

            if (!DTIFormsUtil.TratarRetornoPersistencia(Gravar()))
                return;

            if (sender == btnGravar)
                Close();
            else if (sender == btnGravarContinuar)
            {
                LimparTela();
                tbModeloAutomovel.Focus();
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
