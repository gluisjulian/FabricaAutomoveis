
namespace FabricaAutomoveis
{
    partial class Automoveis0001
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.tbmodeloAutomovel = new System.Windows.Forms.TextBox();
            this.tbanoAutomovel = new System.Windows.Forms.TextBox();
            this.lblanoAutomovel = new System.Windows.Forms.Label();
            this.lblmodeloAutomovel = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnIncluir = new DevExpress.XtraEditors.SimpleButton();
            this.gridViewPrincipal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_automovel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modelo_automovel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ano_automovel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEditar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryEditar = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnExcluir = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryExcluir = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.dgvPrincipal = new DevExpress.XtraGrid.GridControl();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.Controls.Add(this.tbmodeloAutomovel);
            this.pnlFiltros.Controls.Add(this.tbanoAutomovel);
            this.pnlFiltros.Controls.Add(this.lblanoAutomovel);
            this.pnlFiltros.Controls.Add(this.lblmodeloAutomovel);
            this.pnlFiltros.Controls.Add(this.btnPesquisar);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(800, 63);
            this.pnlFiltros.TabIndex = 8;
            // 
            // tbmodeloAutomovel
            // 
            this.tbmodeloAutomovel.Location = new System.Drawing.Point(9, 35);
            this.tbmodeloAutomovel.Name = "tbmodeloAutomovel";
            this.tbmodeloAutomovel.Size = new System.Drawing.Size(185, 20);
            this.tbmodeloAutomovel.TabIndex = 4;
            // 
            // tbanoAutomovel
            // 
            this.tbanoAutomovel.Location = new System.Drawing.Point(217, 35);
            this.tbanoAutomovel.Name = "tbanoAutomovel";
            this.tbanoAutomovel.Size = new System.Drawing.Size(185, 20);
            this.tbanoAutomovel.TabIndex = 3;
            // 
            // lblanoAutomovel
            // 
            this.lblanoAutomovel.AutoSize = true;
            this.lblanoAutomovel.Location = new System.Drawing.Point(214, 21);
            this.lblanoAutomovel.Name = "lblanoAutomovel";
            this.lblanoAutomovel.Size = new System.Drawing.Size(94, 13);
            this.lblanoAutomovel.TabIndex = 2;
            this.lblanoAutomovel.Text = "Ano do Automovel";
            this.lblanoAutomovel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmodeloAutomovel
            // 
            this.lblmodeloAutomovel.AutoSize = true;
            this.lblmodeloAutomovel.Location = new System.Drawing.Point(6, 21);
            this.lblmodeloAutomovel.Name = "lblmodeloAutomovel";
            this.lblmodeloAutomovel.Size = new System.Drawing.Size(95, 13);
            this.lblmodeloAutomovel.TabIndex = 2;
            this.lblmodeloAutomovel.Text = "Modelo Automovel";
            this.lblmodeloAutomovel.Click += new System.EventHandler(this.lblData_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::FabricaAutomoveis.Properties.Resources.ic_search_black_18dp;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(427, 33);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(81, 22);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIncluir.Appearance.Image = global::FabricaAutomoveis.Properties.Resources.ic_add_black_24dp;
            this.btnIncluir.Appearance.Options.UseBackColor = true;
            this.btnIncluir.Appearance.Options.UseImage = true;
            this.btnIncluir.BackgroundImage = global::FabricaAutomoveis.Properties.Resources.ic_add_black_18dp;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncluir.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnIncluir.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnIncluir.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(753, 503);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(35, 36);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // gridViewPrincipal
            // 
            this.gridViewPrincipal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_automovel,
            this.modelo_automovel,
            this.ano_automovel,
            this.btnEditar,
            this.btnExcluir});
            this.gridViewPrincipal.GridControl = this.dgvPrincipal;
            this.gridViewPrincipal.Name = "gridViewPrincipal";
            // 
            // id_automovel
            // 
            this.id_automovel.Caption = "ID";
            this.id_automovel.FieldName = "id_automovel";
            this.id_automovel.Name = "id_automovel";
            this.id_automovel.OptionsColumn.AllowEdit = false;
            this.id_automovel.Visible = true;
            this.id_automovel.VisibleIndex = 0;
            this.id_automovel.Width = 177;
            // 
            // modelo_automovel
            // 
            this.modelo_automovel.Caption = "Modelo do Automovel";
            this.modelo_automovel.FieldName = "modelo_automovel";
            this.modelo_automovel.Name = "modelo_automovel";
            this.modelo_automovel.OptionsColumn.AllowEdit = false;
            this.modelo_automovel.Visible = true;
            this.modelo_automovel.VisibleIndex = 1;
            this.modelo_automovel.Width = 309;
            // 
            // ano_automovel
            // 
            this.ano_automovel.Caption = "Ano do Automovel";
            this.ano_automovel.FieldName = "ano_automovel";
            this.ano_automovel.Name = "ano_automovel";
            this.ano_automovel.OptionsColumn.AllowEdit = false;
            this.ano_automovel.Visible = true;
            this.ano_automovel.VisibleIndex = 2;
            this.ano_automovel.Width = 118;
            // 
            // btnEditar
            // 
            this.btnEditar.Caption = "Editar";
            this.btnEditar.ColumnEdit = this.repositoryEditar;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Visible = true;
            this.btnEditar.VisibleIndex = 3;
            this.btnEditar.Width = 104;
            // 
            // repositoryEditar
            // 
            this.repositoryEditar.AutoHeight = false;
            editorButtonImageOptions1.Image = global::FabricaAutomoveis.Properties.Resources.ic_create_black_18dp;
            this.repositoryEditar.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryEditar.Name = "repositoryEditar";
            this.repositoryEditar.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryEditar.Click += new System.EventHandler(this.repositoryEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Caption = "Excluir";
            this.btnExcluir.ColumnEdit = this.repositoryExcluir;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Visible = true;
            this.btnExcluir.VisibleIndex = 4;
            this.btnExcluir.Width = 74;
            // 
            // repositoryExcluir
            // 
            this.repositoryExcluir.AutoHeight = false;
            editorButtonImageOptions2.Image = global::FabricaAutomoveis.Properties.Resources.ic_remove_circle_outline_black_18dp;
            this.repositoryExcluir.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryExcluir.Name = "repositoryExcluir";
            this.repositoryExcluir.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryExcluir.Click += new System.EventHandler(this.repositoryExcluir_Click);
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.Location = new System.Drawing.Point(0, 63);
            this.dgvPrincipal.MainView = this.gridViewPrincipal;
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryEditar,
            this.repositoryExcluir});
            this.dgvPrincipal.Size = new System.Drawing.Size(800, 488);
            this.dgvPrincipal.TabIndex = 9;
            this.dgvPrincipal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrincipal});
            // 
            // Automoveis0001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvPrincipal);
            this.Controls.Add(this.pnlFiltros);
            this.Name = "Automoveis0001";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DTIFormPadrao_Load);
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlFiltros;
        private DevExpress.XtraEditors.SimpleButton btnIncluir;
        private System.Windows.Forms.Button btnPesquisar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrincipal;
        private DevExpress.XtraGrid.GridControl dgvPrincipal;
        private System.Windows.Forms.TextBox tbanoAutomovel;
        private System.Windows.Forms.Label lblanoAutomovel;
        private System.Windows.Forms.Label lblmodeloAutomovel;
        private DevExpress.XtraGrid.Columns.GridColumn id_automovel;
        private DevExpress.XtraGrid.Columns.GridColumn modelo_automovel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryEditar;
        private DevExpress.XtraGrid.Columns.GridColumn btnExcluir;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryExcluir;
        private System.Windows.Forms.TextBox tbmodeloAutomovel;
        private DevExpress.XtraGrid.Columns.GridColumn ano_automovel;
        public DevExpress.XtraGrid.Columns.GridColumn btnEditar;
    }
}

