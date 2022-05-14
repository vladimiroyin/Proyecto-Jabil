namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buildingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDataSet = new Prueba.MaterialsDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buildingsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buildingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClose = new System.Windows.Forms.Button();
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partNumbersDataGridView = new System.Windows.Forms.DataGridView();
            this.partNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPartNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new Prueba.MaterialsDataSetTableAdapters.BuildingsTableAdapter();
            this.tableAdapterManager = new Prueba.MaterialsDataSetTableAdapters.TableAdapterManager();
            this.customersTableAdapter = new Prueba.MaterialsDataSetTableAdapters.CustomersTableAdapter();
            this.partNumbersTableAdapter = new Prueba.MaterialsDataSetTableAdapters.PartNumbersTableAdapter();
            this.CBOBuilding = new System.Windows.Forms.ComboBox();
            this.BtnAltBuil = new System.Windows.Forms.Button();
            this.txtBuild = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtFKBuilding = new System.Windows.Forms.TextBox();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnAltCust = new System.Windows.Forms.Button();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.txtFKCustomer = new System.Windows.Forms.TextBox();
            this.btnPNumber = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.materialsDataSet1 = new Prueba.MaterialsDataSet();
            this.buildingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PKPartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FKCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingNavigator)).BeginInit();
            this.buildingsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumbersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartNumbersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buildingsBindingNavigator
            // 
            this.buildingsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.buildingsBindingNavigator.BindingSource = this.buildingsBindingSource;
            this.buildingsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.buildingsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.buildingsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.buildingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.buildingsBindingNavigatorSaveItem});
            this.buildingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.buildingsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.buildingsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.buildingsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.buildingsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.buildingsBindingNavigator.Name = "buildingsBindingNavigator";
            this.buildingsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.buildingsBindingNavigator.Size = new System.Drawing.Size(1420, 31);
            this.buildingsBindingNavigator.TabIndex = 0;
            this.buildingsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.materialsDataSet;
            // 
            // materialsDataSet
            // 
            this.materialsDataSet.DataSetName = "MaterialsDataSet";
            this.materialsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // buildingsBindingNavigatorSaveItem
            // 
            this.buildingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buildingsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("buildingsBindingNavigatorSaveItem.Image")));
            this.buildingsBindingNavigatorSaveItem.Name = "buildingsBindingNavigatorSaveItem";
            this.buildingsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.buildingsBindingNavigatorSaveItem.Text = "Guardar datos";
            this.buildingsBindingNavigatorSaveItem.Click += new System.EventHandler(this.buildingsBindingNavigatorSaveItem_Click);
            // 
            // buildingsDataGridView
            // 
            this.buildingsDataGridView.AutoGenerateColumns = false;
            this.buildingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buildingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.buildingsDataGridView.DataSource = this.buildingsBindingSource;
            this.buildingsDataGridView.Location = new System.Drawing.Point(42, 55);
            this.buildingsDataGridView.Name = "buildingsDataGridView";
            this.buildingsDataGridView.RowHeadersWidth = 51;
            this.buildingsDataGridView.RowTemplate.Height = 24;
            this.buildingsDataGridView.Size = new System.Drawing.Size(367, 238);
            this.buildingsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PKBuilding";
            this.dataGridViewTextBoxColumn1.HeaderText = "PKBuilding";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Building";
            this.dataGridViewTextBoxColumn2.HeaderText = "Building";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1298, 55);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 33);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(42, 299);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(745, 215);
            this.customersDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PKCustomers";
            this.dataGridViewTextBoxColumn3.HeaderText = "PKCustomers";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Prefix";
            this.dataGridViewTextBoxColumn5.HeaderText = "Prefix";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FKBuilding";
            this.dataGridViewTextBoxColumn6.HeaderText = "FKBuilding";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.materialsDataSet;
            // 
            // partNumbersDataGridView
            // 
            this.partNumbersDataGridView.AutoGenerateColumns = false;
            this.partNumbersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partNumbersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PKPartNumber,
            this.PartNumber,
            this.Available,
            this.FKCustomer});
            this.partNumbersDataGridView.DataSource = this.partNumbersBindingSource;
            this.partNumbersDataGridView.Location = new System.Drawing.Point(42, 520);
            this.partNumbersDataGridView.Name = "partNumbersDataGridView";
            this.partNumbersDataGridView.RowHeadersWidth = 51;
            this.partNumbersDataGridView.RowTemplate.Height = 24;
            this.partNumbersDataGridView.Size = new System.Drawing.Size(745, 220);
            this.partNumbersDataGridView.TabIndex = 4;
            this.partNumbersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partNumbersDataGridView_CellContentClick);
            // 
            // partNumbersBindingSource
            // 
            this.partNumbersBindingSource.DataMember = "PartNumbers";
            this.partNumbersBindingSource.DataSource = this.materialsDataSet;
            // 
            // fKPartNumbersBindingSource
            // 
            this.fKPartNumbersBindingSource.DataMember = "FK_PartNumbers";
            this.fKPartNumbersBindingSource.DataSource = this.customersBindingSource;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BuildingsTableAdapter = this.buildingsTableAdapter;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.PartNumbersTableAdapter = this.partNumbersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Prueba.MaterialsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // partNumbersTableAdapter
            // 
            this.partNumbersTableAdapter.ClearBeforeFill = true;
            // 
            // CBOBuilding
            // 
            this.CBOBuilding.FormattingEnabled = true;
            this.CBOBuilding.Location = new System.Drawing.Point(1214, 345);
            this.CBOBuilding.Name = "CBOBuilding";
            this.CBOBuilding.Size = new System.Drawing.Size(159, 24);
            this.CBOBuilding.TabIndex = 5;
            this.CBOBuilding.SelectedIndexChanged += new System.EventHandler(this.CBOBuilding_SelectedIndexChanged);
            // 
            // BtnAltBuil
            // 
            this.BtnAltBuil.Location = new System.Drawing.Point(522, 151);
            this.BtnAltBuil.Name = "BtnAltBuil";
            this.BtnAltBuil.Size = new System.Drawing.Size(78, 27);
            this.BtnAltBuil.TabIndex = 6;
            this.BtnAltBuil.Text = "Agregar";
            this.BtnAltBuil.UseVisualStyleBackColor = true;
            this.BtnAltBuil.Click += new System.EventHandler(this.BtnAltBuil_Click);
            // 
            // txtBuild
            // 
            this.txtBuild.Location = new System.Drawing.Point(483, 91);
            this.txtBuild.Name = "txtBuild";
            this.txtBuild.Size = new System.Drawing.Size(158, 22);
            this.txtBuild.TabIndex = 7;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(831, 347);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(100, 22);
            this.txtCustomer.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dar Alta Edificios";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(966, 347);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(100, 22);
            this.txtPrefix.TabIndex = 11;
            // 
            // txtFKBuilding
            // 
            this.txtFKBuilding.Location = new System.Drawing.Point(1098, 347);
            this.txtFKBuilding.Name = "txtFKBuilding";
            this.txtFKBuilding.Size = new System.Drawing.Size(100, 22);
            this.txtFKBuilding.TabIndex = 12;
            this.txtFKBuilding.TextChanged += new System.EventHandler(this.txtFKBuilding_TextChanged);
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(794, 709);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(137, 31);
            this.btnEx.TabIndex = 13;
            this.btnEx.Text = "Exportar a Excel";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnAltCust
            // 
            this.btnAltCust.Location = new System.Drawing.Point(979, 389);
            this.btnAltCust.Name = "btnAltCust";
            this.btnAltCust.Size = new System.Drawing.Size(75, 28);
            this.btnAltCust.TabIndex = 14;
            this.btnAltCust.Text = "Agregar";
            this.btnAltCust.UseVisualStyleBackColor = true;
            this.btnAltCust.Click += new System.EventHandler(this.btnAltCust_Click);
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(831, 545);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPNumber.TabIndex = 15;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Location = new System.Drawing.Point(966, 545);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(100, 22);
            this.txtAvailable.TabIndex = 16;
            // 
            // txtFKCustomer
            // 
            this.txtFKCustomer.Location = new System.Drawing.Point(1098, 545);
            this.txtFKCustomer.Name = "txtFKCustomer";
            this.txtFKCustomer.Size = new System.Drawing.Size(100, 22);
            this.txtFKCustomer.TabIndex = 17;
            // 
            // btnPNumber
            // 
            this.btnPNumber.Location = new System.Drawing.Point(979, 613);
            this.btnPNumber.Name = "btnPNumber";
            this.btnPNumber.Size = new System.Drawing.Size(75, 29);
            this.btnPNumber.TabIndex = 18;
            this.btnPNumber.Text = "Agregar";
            this.btnPNumber.UseVisualStyleBackColor = true;
            this.btnPNumber.Click += new System.EventHandler(this.btnPNumber_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Part Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(972, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Disponibilidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1121, 498);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(856, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(995, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Prefijo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1121, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Edificio";
            // 
            // materialsDataSet1
            // 
            this.materialsDataSet1.DataSetName = "MaterialsDataSet";
            this.materialsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingsBindingSource1
            // 
            this.buildingsBindingSource1.DataMember = "Buildings";
            this.buildingsBindingSource1.DataSource = this.materialsDataSet1;
            // 
            // buildingsBindingSource2
            // 
            this.buildingsBindingSource2.DataMember = "Buildings";
            this.buildingsBindingSource2.DataSource = this.materialsDataSet;
            // 
            // materialsDataSetBindingSource
            // 
            this.materialsDataSetBindingSource.DataSource = this.materialsDataSet;
            this.materialsDataSetBindingSource.Position = 0;
            // 
            // PKPartNumber
            // 
            this.PKPartNumber.DataPropertyName = "PKPartNumber";
            this.PKPartNumber.HeaderText = "PKPartNumber";
            this.PKPartNumber.MinimumWidth = 6;
            this.PKPartNumber.Name = "PKPartNumber";
            this.PKPartNumber.ReadOnly = true;
            this.PKPartNumber.Width = 125;
            // 
            // PartNumber
            // 
            this.PartNumber.DataPropertyName = "PartNumber";
            this.PartNumber.HeaderText = "PartNumber";
            this.PartNumber.MinimumWidth = 6;
            this.PartNumber.Name = "PartNumber";
            this.PartNumber.Width = 125;
            // 
            // Available
            // 
            this.Available.DataPropertyName = "Available";
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            this.Available.Width = 125;
            // 
            // FKCustomer
            // 
            this.FKCustomer.DataPropertyName = "FKCustomer";
            this.FKCustomer.HeaderText = "FKCustomer";
            this.FKCustomer.MinimumWidth = 6;
            this.FKCustomer.Name = "FKCustomer";
            this.FKCustomer.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 759);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPNumber);
            this.Controls.Add(this.txtFKCustomer);
            this.Controls.Add(this.txtAvailable);
            this.Controls.Add(this.txtPNumber);
            this.Controls.Add(this.btnAltCust);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.txtFKBuilding);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtBuild);
            this.Controls.Add(this.BtnAltBuil);
            this.Controls.Add(this.CBOBuilding);
            this.Controls.Add(this.partNumbersDataGridView);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buildingsDataGridView);
            this.Controls.Add(this.buildingsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingNavigator)).EndInit();
            this.buildingsBindingNavigator.ResumeLayout(false);
            this.buildingsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumbersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPartNumbersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialsDataSet materialsDataSet;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private MaterialsDataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
        private MaterialsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator buildingsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton buildingsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView buildingsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonClose;
        private MaterialsDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MaterialsDataSetTableAdapters.PartNumbersTableAdapter partNumbersTableAdapter;
        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource partNumbersBindingSource;
        private System.Windows.Forms.DataGridView partNumbersDataGridView;
        private System.Windows.Forms.BindingSource fKPartNumbersBindingSource;
        private System.Windows.Forms.ComboBox CBOBuilding;
        private System.Windows.Forms.Button BtnAltBuil;
        private System.Windows.Forms.TextBox txtBuild;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtFKBuilding;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnAltCust;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.TextBox txtFKCustomer;
        private System.Windows.Forms.Button btnPNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialsDataSet materialsDataSet1;
        private System.Windows.Forms.BindingSource buildingsBindingSource1;
        private System.Windows.Forms.BindingSource buildingsBindingSource2;
        private System.Windows.Forms.BindingSource materialsDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PKPartNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Available;
        private System.Windows.Forms.DataGridViewTextBoxColumn FKCustomer;
    }
}

