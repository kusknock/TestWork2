namespace TestWork2
{
    partial class EditForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenDb = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.btnAcceptDb = new System.Windows.Forms.ToolStripButton();
            this.btnCancelDb = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefreshDb = new System.Windows.Forms.ToolStripButton();
            this.cmbTables = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.checkApartNum = new System.Windows.Forms.CheckBox();
            this.btnAcceptFilter = new System.Windows.Forms.Button();
            this.comboCities = new System.Windows.Forms.ComboBox();
            this.btnResetFilter = new System.Windows.Forms.Button();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblNumApart = new System.Windows.Forms.Label();
            this.lblCityFilter = new System.Windows.Forms.Label();
            this.linkSort = new System.Windows.Forms.LinkLabel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditOwners = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddHouse = new System.Windows.Forms.ToolStripMenuItem();
            this.tabEditDb = new System.Windows.Forms.TabPage();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnContextRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteHouse = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabEditDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 480);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenDb,
            this.toolStripMenuItem1,
            this.выйтиToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.менюToolStripMenuItem.Text = "Файл";
            // 
            // btnOpenDb
            // 
            this.btnOpenDb.Name = "btnOpenDb";
            this.btnOpenDb.Size = new System.Drawing.Size(185, 26);
            this.btnOpenDb.Text = "Открыть базу";
            this.btnOpenDb.Click += new System.EventHandler(this.btnOpenDb_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 26);
            this.toolStripMenuItem1.Text = "Закрыть базу";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.CountItemFormat = "{0} записей";
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Enabled = false;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorCountItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btnAcceptDb,
            this.btnCancelDb,
            this.toolStripSeparator3,
            this.btnRefreshDb,
            this.cmbTables});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1026, 28);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorAddNewItem.Text = "Добавить запись";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(88, 25);
            this.bindingNavigatorCountItem.Text = "{0} записей";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 25);
            this.bindingNavigatorDeleteItem.Text = "Удалить запись";
            // 
            // btnAcceptDb
            // 
            this.btnAcceptDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAcceptDb.Image = ((System.Drawing.Image)(resources.GetObject("btnAcceptDb.Image")));
            this.btnAcceptDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAcceptDb.Name = "btnAcceptDb";
            this.btnAcceptDb.Size = new System.Drawing.Size(29, 25);
            this.btnAcceptDb.Text = "Применить изменения";
            this.btnAcceptDb.Click += new System.EventHandler(this.btnAcceptDb_Click);
            // 
            // btnCancelDb
            // 
            this.btnCancelDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelDb.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDb.Image")));
            this.btnCancelDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelDb.Name = "btnCancelDb";
            this.btnCancelDb.Size = new System.Drawing.Size(29, 25);
            this.btnCancelDb.Text = "Отменить изменения";
            this.btnCancelDb.Click += new System.EventHandler(this.btnCancelDb_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // btnRefreshDb
            // 
            this.btnRefreshDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshDb.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshDb.Image")));
            this.btnRefreshDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshDb.Name = "btnRefreshDb";
            this.btnRefreshDb.Size = new System.Drawing.Size(29, 25);
            this.btnRefreshDb.Text = "Обновить таблицу";
            this.btnRefreshDb.Click += new System.EventHandler(this.btnRefreshDb_Click);
            // 
            // cmbTables
            // 
            this.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTables.Items.AddRange(new object[] {
            "Регионы",
            "Населенные пункты",
            "Улицы",
            "Дома",
            "Собственники"});
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(121, 28);
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 20);
            this.statusLabel.Text = "Готово";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabEditDb);
            this.tabControl.Location = new System.Drawing.Point(12, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1040, 555);
            this.tabControl.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupFilter);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Основная вкладка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupFilter
            // 
            this.groupFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFilter.Controls.Add(this.checkApartNum);
            this.groupFilter.Controls.Add(this.btnAcceptFilter);
            this.groupFilter.Controls.Add(this.comboCities);
            this.groupFilter.Controls.Add(this.btnResetFilter);
            this.groupFilter.Controls.Add(this.numTo);
            this.groupFilter.Controls.Add(this.numFrom);
            this.groupFilter.Controls.Add(this.lblTo);
            this.groupFilter.Controls.Add(this.lblFrom);
            this.groupFilter.Controls.Add(this.lblNumApart);
            this.groupFilter.Controls.Add(this.lblCityFilter);
            this.groupFilter.Controls.Add(this.linkSort);
            this.groupFilter.Enabled = false;
            this.groupFilter.Location = new System.Drawing.Point(790, 6);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(236, 204);
            this.groupFilter.TabIndex = 2;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Фильтрация";
            // 
            // checkApartNum
            // 
            this.checkApartNum.AutoSize = true;
            this.checkApartNum.Location = new System.Drawing.Point(202, 111);
            this.checkApartNum.Name = "checkApartNum";
            this.checkApartNum.Size = new System.Drawing.Size(18, 17);
            this.checkApartNum.TabIndex = 3;
            this.checkApartNum.UseVisualStyleBackColor = true;
            // 
            // btnAcceptFilter
            // 
            this.btnAcceptFilter.Location = new System.Drawing.Point(13, 172);
            this.btnAcceptFilter.Name = "btnAcceptFilter";
            this.btnAcceptFilter.Size = new System.Drawing.Size(162, 26);
            this.btnAcceptFilter.TabIndex = 12;
            this.btnAcceptFilter.Text = "Показать";
            this.btnAcceptFilter.UseVisualStyleBackColor = true;
            this.btnAcceptFilter.Click += new System.EventHandler(this.btnAcceptFilter_Click);
            // 
            // comboCities
            // 
            this.comboCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCities.FormattingEnabled = true;
            this.comboCities.Location = new System.Drawing.Point(13, 84);
            this.comboCities.Name = "comboCities";
            this.comboCities.Size = new System.Drawing.Size(217, 24);
            this.comboCities.TabIndex = 11;
            // 
            // btnResetFilter
            // 
            this.btnResetFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnResetFilter.Image")));
            this.btnResetFilter.Location = new System.Drawing.Point(181, 172);
            this.btnResetFilter.Name = "btnResetFilter";
            this.btnResetFilter.Size = new System.Drawing.Size(49, 26);
            this.btnResetFilter.TabIndex = 10;
            this.btnResetFilter.UseVisualStyleBackColor = true;
            this.btnResetFilter.Click += new System.EventHandler(this.btnResetFilter_Click);
            // 
            // numTo
            // 
            this.numTo.Location = new System.Drawing.Point(146, 135);
            this.numTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(50, 22);
            this.numTo.TabIndex = 8;
            this.numTo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numFrom
            // 
            this.numFrom.Location = new System.Drawing.Point(46, 135);
            this.numFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(50, 22);
            this.numFrom.TabIndex = 7;
            this.numFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(110, 137);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(31, 17);
            this.lblTo.TabIndex = 6;
            this.lblTo.Text = "До:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(10, 137);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 17);
            this.lblFrom.TabIndex = 5;
            this.lblFrom.Text = "От:";
            // 
            // lblNumApart
            // 
            this.lblNumApart.AutoSize = true;
            this.lblNumApart.Location = new System.Drawing.Point(10, 111);
            this.lblNumApart.Name = "lblNumApart";
            this.lblNumApart.Size = new System.Drawing.Size(186, 17);
            this.lblNumApart.TabIndex = 4;
            this.lblNumApart.Text = "Фильтр по кол-ву квартир:";
            // 
            // lblCityFilter
            // 
            this.lblCityFilter.AutoSize = true;
            this.lblCityFilter.Location = new System.Drawing.Point(10, 63);
            this.lblCityFilter.Name = "lblCityFilter";
            this.lblCityFilter.Size = new System.Drawing.Size(162, 17);
            this.lblCityFilter.TabIndex = 3;
            this.lblCityFilter.Text = "Фильтр по нас. пункту:";
            // 
            // linkSort
            // 
            this.linkSort.Location = new System.Drawing.Point(7, 22);
            this.linkSort.Name = "linkSort";
            this.linkSort.Size = new System.Drawing.Size(201, 42);
            this.linkSort.TabIndex = 0;
            this.linkSort.TabStop = true;
            this.linkSort.Text = "Сортировать по количеству квартир ↓ ";
            this.linkSort.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSort_LinkClicked);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(778, 514);
            this.dataGridView2.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditOwners,
            this.btnAddHouse,
            this.btnDeleteHouse,
            this.btnContextRefresh});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(257, 128);
            // 
            // btnEditOwners
            // 
            this.btnEditOwners.Name = "btnEditOwners";
            this.btnEditOwners.Size = new System.Drawing.Size(256, 24);
            this.btnEditOwners.Text = "Изменить собственников";
            this.btnEditOwners.Click += new System.EventHandler(this.btnEditOwners_Click);
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(256, 24);
            this.btnAddHouse.Text = "Добавить дом";
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // tabEditDb
            // 
            this.tabEditDb.Controls.Add(this.dataGridView1);
            this.tabEditDb.Controls.Add(this.bindingNavigator1);
            this.tabEditDb.Location = new System.Drawing.Point(4, 25);
            this.tabEditDb.Name = "tabEditDb";
            this.tabEditDb.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditDb.Size = new System.Drawing.Size(1032, 526);
            this.tabEditDb.TabIndex = 0;
            this.tabEditDb.Text = "Редактирование элементов";
            this.tabEditDb.UseVisualStyleBackColor = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.AllowNew = true;
            // 
            // btnContextRefresh
            // 
            this.btnContextRefresh.Name = "btnContextRefresh";
            this.btnContextRefresh.Size = new System.Drawing.Size(256, 24);
            this.btnContextRefresh.Text = "Обновить таблицу";
            this.btnContextRefresh.Click += new System.EventHandler(this.btnRefreshDb_Click);
            // 
            // btnDeleteHouse
            // 
            this.btnDeleteHouse.Name = "btnDeleteHouse";
            this.btnDeleteHouse.Size = new System.Drawing.Size(256, 24);
            this.btnDeleteHouse.Text = "Удалить дом";
            this.btnDeleteHouse.Click += new System.EventHandler(this.btnDeleteHouse_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 615);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditForm";
            this.Text = "Редактирование элементов базы данных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabEditDb.ResumeLayout(false);
            this.tabEditDb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenDb;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton btnAcceptDb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRefreshDb;
        private System.Windows.Forms.ToolStripButton btnCancelDb;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripComboBox cmbTables;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEditDb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Label lblCityFilter;
        private System.Windows.Forms.LinkLabel linkSort;
        private System.Windows.Forms.NumericUpDown numTo;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnResetFilter;
        private System.Windows.Forms.ComboBox comboCities;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEditOwners;
        private System.Windows.Forms.Button btnAcceptFilter;
        private System.Windows.Forms.CheckBox checkApartNum;
        private System.Windows.Forms.Label lblNumApart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btnAddHouse;
        private System.Windows.Forms.ToolStripMenuItem btnContextRefresh;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteHouse;
    }
}

