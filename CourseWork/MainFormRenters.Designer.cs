﻿namespace CourseWork
{
    partial class MainFormRenters
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormRenters));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.RequestsGridView = new System.Windows.Forms.DataGridView();
            this.id_a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_own = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_perMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accept = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.areasDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpaceOfArea_squareMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Describe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new CourseWork.DatabaseDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.areasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.areasTableAdapter = new CourseWork.DatabaseDataSetTableAdapters.AreasTableAdapter();
            this.tableAdapterManager = new CourseWork.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.Contract = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.areasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingNavigator)).BeginInit();
            this.areasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(146, 378);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(174, 62);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(146, 287);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(234, 44);
            this.passField.TabIndex = 10;
            this.passField.UseSystemPasswordChar = true;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(146, 180);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(234, 56);
            this.loginField.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.Contract);
            this.panel1.Controls.Add(this.buttonAddRequest);
            this.panel1.Controls.Add(this.RequestsGridView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.areasDataGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 634);
            this.panel1.TabIndex = 12;
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.buttonAddRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddRequest.FlatAppearance.BorderSize = 0;
            this.buttonAddRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.buttonAddRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.buttonAddRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRequest.ForeColor = System.Drawing.Color.White;
            this.buttonAddRequest.Location = new System.Drawing.Point(474, 545);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(331, 47);
            this.buttonAddRequest.TabIndex = 10;
            this.buttonAddRequest.Text = "Добавить заявку";
            this.buttonAddRequest.UseVisualStyleBackColor = false;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click);
            // 
            // RequestsGridView
            // 
            this.RequestsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_a,
            this.id_own,
            this.Area_Name,
            this.roomsAmount,
            this.square,
            this.price_perMonth,
            this.Accept,
            this.descr});
            this.RequestsGridView.Location = new System.Drawing.Point(0, 162);
            this.RequestsGridView.Name = "RequestsGridView";
            this.RequestsGridView.Size = new System.Drawing.Size(416, 239);
            this.RequestsGridView.TabIndex = 6;
            this.RequestsGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestsGridView_CellDoubleClick);
            // 
            // id_a
            // 
            this.id_a.HeaderText = "id_a";
            this.id_a.Name = "id_a";
            this.id_a.Visible = false;
            // 
            // id_own
            // 
            this.id_own.HeaderText = "id_own";
            this.id_own.Name = "id_own";
            this.id_own.Visible = false;
            // 
            // Area_Name
            // 
            this.Area_Name.HeaderText = "Area_Name";
            this.Area_Name.Name = "Area_Name";
            // 
            // roomsAmount
            // 
            this.roomsAmount.HeaderText = "roomsAmount";
            this.roomsAmount.Name = "roomsAmount";
            // 
            // square
            // 
            this.square.HeaderText = "square";
            this.square.Name = "square";
            // 
            // price_perMonth
            // 
            this.price_perMonth.HeaderText = "price_perMonth";
            this.price_perMonth.Name = "price_perMonth";
            // 
            // Accept
            // 
            this.Accept.HeaderText = "Accept";
            this.Accept.Name = "Accept";
            this.Accept.ReadOnly = true;
            this.Accept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // descr
            // 
            this.descr.HeaderText = "descr";
            this.descr.Name = "descr";
            this.descr.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Состояние моих заявок";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(422, 423);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(216, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Показать заявки, отправленные мне";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(417, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сдаваемые помещения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Нажмите на строку, чтобы рассмотреть предложение подробнее";
            // 
            // areasDataGridView
            // 
            this.areasDataGridView.AutoGenerateColumns = false;
            this.areasDataGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.areasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.areasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Owner_id,
            this.AreaName,
            this.SpaceOfArea_squareMeter,
            this.Rooms,
            this.PricePerMonth,
            this.Describe});
            this.areasDataGridView.DataSource = this.areasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.areasDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.areasDataGridView.Location = new System.Drawing.Point(422, 162);
            this.areasDataGridView.Name = "areasDataGridView";
            this.areasDataGridView.Size = new System.Drawing.Size(418, 239);
            this.areasDataGridView.TabIndex = 1;
            this.areasDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.areasDataGridView_CellDoubleClick);
            this.areasDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.areasDataGridView_ColumnHeaderMouseClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Owner_id
            // 
            this.Owner_id.DataPropertyName = "Owner_id";
            this.Owner_id.HeaderText = "Owner_id";
            this.Owner_id.Name = "Owner_id";
            this.Owner_id.Visible = false;
            // 
            // AreaName
            // 
            this.AreaName.DataPropertyName = "AreaName";
            this.AreaName.HeaderText = "AreaName";
            this.AreaName.Name = "AreaName";
            // 
            // SpaceOfArea_squareMeter
            // 
            this.SpaceOfArea_squareMeter.DataPropertyName = "SpaceOfArea_squareMeter";
            this.SpaceOfArea_squareMeter.HeaderText = "SpaceOfArea_squareMeter";
            this.SpaceOfArea_squareMeter.Name = "SpaceOfArea_squareMeter";
            // 
            // Rooms
            // 
            this.Rooms.DataPropertyName = "Rooms";
            this.Rooms.HeaderText = "Rooms";
            this.Rooms.Name = "Rooms";
            // 
            // PricePerMonth
            // 
            this.PricePerMonth.DataPropertyName = "PricePerMonth";
            this.PricePerMonth.HeaderText = "PricePerMonth";
            this.PricePerMonth.Name = "PricePerMonth";
            // 
            // Describe
            // 
            this.Describe.DataPropertyName = "Describe";
            this.Describe.HeaderText = "Describe";
            this.Describe.Name = "Describe";
            this.Describe.Visible = false;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "Areas";
            this.areasBindingSource.DataSource = this.DataSet;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DatabaseDataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.closeButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 107);
            this.panel3.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(810, 29);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(813, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(843, 107);
            this.label3.TabIndex = 0;
            this.label3.Text = "Главный экран";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // areasBindingNavigator
            // 
            this.areasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.areasBindingNavigator.BindingSource = this.areasBindingSource;
            this.areasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.areasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.areasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.areasBindingNavigatorSaveItem});
            this.areasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.areasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.areasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.areasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.areasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.areasBindingNavigator.Name = "areasBindingNavigator";
            this.areasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.areasBindingNavigator.Size = new System.Drawing.Size(843, 25);
            this.areasBindingNavigator.TabIndex = 13;
            this.areasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AreasTableAdapter = this.areasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.LeasingAppIDTableAdapter = null;
            this.tableAdapterManager.OwnersTableAdapter = null;
            this.tableAdapterManager.RentersTableAdapter = null;
            this.tableAdapterManager.RequestsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CourseWork.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Contract
            // 
            this.Contract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.Contract.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Contract.FlatAppearance.BorderSize = 0;
            this.Contract.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(136)))), ((int)(((byte)(0)))));
            this.Contract.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(164)))), ((int)(((byte)(0)))));
            this.Contract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contract.ForeColor = System.Drawing.Color.White;
            this.Contract.Location = new System.Drawing.Point(61, 545);
            this.Contract.Name = "Contract";
            this.Contract.Size = new System.Drawing.Size(331, 47);
            this.Contract.TabIndex = 11;
            this.Contract.Text = "Ваши контракты";
            this.Contract.UseVisualStyleBackColor = false;
            this.Contract.Click += new System.EventHandler(this.Contract_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // areasBindingNavigatorSaveItem
            // 
            this.areasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.areasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("areasBindingNavigatorSaveItem.Image")));
            this.areasBindingNavigatorSaveItem.Name = "areasBindingNavigatorSaveItem";
            this.areasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.areasBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.areasBindingNavigatorSaveItem.Click += new System.EventHandler(this.areasBindingNavigatorSaveItem_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CourseWork.Properties.Resources.y1;
            this.pictureBox3.Location = new System.Drawing.Point(3, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseWork.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(61, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.user3;
            this.pictureBox1.Location = new System.Drawing.Point(61, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainFormRenters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 634);
            this.Controls.Add(this.areasBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFormRenters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainFormRenters_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingNavigator)).EndInit();
            this.areasBindingNavigator.ResumeLayout(false);
            this.areasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DatabaseDataSet DataSet;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DatabaseDataSetTableAdapters.AreasTableAdapter areasTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator areasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton areasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView areasDataGridView;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpaceOfArea_squareMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Describe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView RequestsGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_a;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_own;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn square;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_perMonth;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Button Contract;
    }
}