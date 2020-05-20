namespace Handbook_of_numismatis
{
    partial class MainForm
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
            this.tadble = new System.Windows.Forms.TabControl();
            this.Coin = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allcoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Handbook_of_numismatis.DatabaseDataSet();
            this.Collector = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наличиеРедкихМонетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сollectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Own_collection = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.myCollection = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.названиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сплавDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.информацияПроПредыдущихDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infCollector = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.местоУчёбыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infCollectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxValueToSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Comment = new System.Windows.Forms.DataGridView();
            this.имяDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.комментарийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allcoinTableAdapter = new Handbook_of_numismatis.DatabaseDataSetTableAdapters.AllcoinTableAdapter();
            this.tableAdapterManager = new Handbook_of_numismatis.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.infCollectorTableAdapter = new Handbook_of_numismatis.DatabaseDataSetTableAdapters.infCollectorTableAdapter();
            this.myCollectionTableAdapter = new Handbook_of_numismatis.DatabaseDataSetTableAdapters.myCollectionTableAdapter();
            this.сollectorTableAdapter = new Handbook_of_numismatis.DatabaseDataSetTableAdapters.СollectorTableAdapter();
            this.commentTableAdapter = new Handbook_of_numismatis.DatabaseDataSetTableAdapters.CommentTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номиналDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сплавDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоВыпущенныхМонетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.особенностиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изображениеDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tadble.SuspendLayout();
            this.Coin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allcoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.Collector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сollectorBindingSource)).BeginInit();
            this.Own_collection.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.myCollection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCollectionBindingSource)).BeginInit();
            this.infCollector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infCollectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tadble
            // 
            this.tadble.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.tadble.Controls.Add(this.Coin);
            this.tadble.Controls.Add(this.Collector);
            this.tadble.Controls.Add(this.Own_collection);
            this.tadble.Location = new System.Drawing.Point(282, 100);
            this.tadble.Name = "tadble";
            this.tadble.SelectedIndex = 0;
            this.tadble.Size = new System.Drawing.Size(611, 189);
            this.tadble.TabIndex = 0;
            // 
            // Coin
            // 
            this.Coin.Controls.Add(this.dataGridView1);
            this.Coin.Location = new System.Drawing.Point(4, 22);
            this.Coin.Name = "Coin";
            this.Coin.Padding = new System.Windows.Forms.Padding(3);
            this.Coin.Size = new System.Drawing.Size(603, 163);
            this.Coin.TabIndex = 0;
            this.Coin.Text = "Монеты";
            this.Coin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn,
            this.номиналDataGridViewTextBoxColumn,
            this.годВыпускаDataGridViewTextBoxColumn,
            this.сплавDataGridViewTextBoxColumn,
            this.количествоВыпущенныхМонетDataGridViewTextBoxColumn,
            this.особенностиDataGridViewTextBoxColumn,
            this.изображениеDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.allcoinBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(594, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // allcoinBindingSource
            // 
            this.allcoinBindingSource.DataMember = "Allcoin";
            this.allcoinBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Collector
            // 
            this.Collector.Controls.Add(this.dataGridView2);
            this.Collector.Location = new System.Drawing.Point(4, 22);
            this.Collector.Name = "Collector";
            this.Collector.Padding = new System.Windows.Forms.Padding(3);
            this.Collector.Size = new System.Drawing.Size(603, 163);
            this.Collector.TabIndex = 1;
            this.Collector.Text = "Коллекционеры";
            this.Collector.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имяDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn1,
            this.контактыDataGridViewTextBoxColumn,
            this.наличиеРедкихМонетDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.сollectorBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(590, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn1
            // 
            this.странаDataGridViewTextBoxColumn1.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn1.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn1.Name = "странаDataGridViewTextBoxColumn1";
            // 
            // контактыDataGridViewTextBoxColumn
            // 
            this.контактыDataGridViewTextBoxColumn.DataPropertyName = "Контакты";
            this.контактыDataGridViewTextBoxColumn.HeaderText = "Контакты";
            this.контактыDataGridViewTextBoxColumn.Name = "контактыDataGridViewTextBoxColumn";
            // 
            // наличиеРедкихМонетDataGridViewTextBoxColumn
            // 
            this.наличиеРедкихМонетDataGridViewTextBoxColumn.DataPropertyName = "Наличие редких монет";
            this.наличиеРедкихМонетDataGridViewTextBoxColumn.HeaderText = "Наличие редких монет";
            this.наличиеРедкихМонетDataGridViewTextBoxColumn.Name = "наличиеРедкихМонетDataGridViewTextBoxColumn";
            // 
            // сollectorBindingSource
            // 
            this.сollectorBindingSource.DataMember = "Сollector";
            this.сollectorBindingSource.DataSource = this.databaseDataSet;
            // 
            // Own_collection
            // 
            this.Own_collection.Controls.Add(this.tabControl1);
            this.Own_collection.Location = new System.Drawing.Point(4, 22);
            this.Own_collection.Name = "Own_collection";
            this.Own_collection.Padding = new System.Windows.Forms.Padding(3);
            this.Own_collection.Size = new System.Drawing.Size(603, 163);
            this.Own_collection.TabIndex = 2;
            this.Own_collection.Text = "Собственная коллекция";
            this.Own_collection.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.myCollection);
            this.tabControl1.Controls.Add(this.infCollector);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 167);
            this.tabControl1.TabIndex = 0;
            // 
            // myCollection
            // 
            this.myCollection.Controls.Add(this.dataGridView3);
            this.myCollection.Location = new System.Drawing.Point(4, 22);
            this.myCollection.Name = "myCollection";
            this.myCollection.Padding = new System.Windows.Forms.Padding(3);
            this.myCollection.Size = new System.Drawing.Size(599, 141);
            this.myCollection.TabIndex = 0;
            this.myCollection.Text = "Коллекция";
            this.myCollection.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.названиеDataGridViewTextBoxColumn1,
            this.странаDataGridViewTextBoxColumn2,
            this.годВыпускаDataGridViewTextBoxColumn1,
            this.сплавDataGridViewTextBoxColumn1,
            this.информацияПроПредыдущихDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.myCollectionBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(593, 131);
            this.dataGridView3.TabIndex = 0;
            // 
            // названиеDataGridViewTextBoxColumn1
            // 
            this.названиеDataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn1.Name = "названиеDataGridViewTextBoxColumn1";
            // 
            // странаDataGridViewTextBoxColumn2
            // 
            this.странаDataGridViewTextBoxColumn2.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn2.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn2.Name = "странаDataGridViewTextBoxColumn2";
            // 
            // годВыпускаDataGridViewTextBoxColumn1
            // 
            this.годВыпускаDataGridViewTextBoxColumn1.DataPropertyName = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn1.HeaderText = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn1.Name = "годВыпускаDataGridViewTextBoxColumn1";
            // 
            // сплавDataGridViewTextBoxColumn1
            // 
            this.сплавDataGridViewTextBoxColumn1.DataPropertyName = "Сплав";
            this.сплавDataGridViewTextBoxColumn1.HeaderText = "Сплав";
            this.сплавDataGridViewTextBoxColumn1.Name = "сплавDataGridViewTextBoxColumn1";
            // 
            // информацияПроПредыдущихDataGridViewTextBoxColumn
            // 
            this.информацияПроПредыдущихDataGridViewTextBoxColumn.DataPropertyName = "Информация про предыдущих ";
            this.информацияПроПредыдущихDataGridViewTextBoxColumn.HeaderText = "Информация про предыдущих ";
            this.информацияПроПредыдущихDataGridViewTextBoxColumn.MinimumWidth = 20;
            this.информацияПроПредыдущихDataGridViewTextBoxColumn.Name = "информацияПроПредыдущихDataGridViewTextBoxColumn";
            // 
            // myCollectionBindingSource
            // 
            this.myCollectionBindingSource.DataMember = "myCollection";
            this.myCollectionBindingSource.DataSource = this.databaseDataSet;
            // 
            // infCollector
            // 
            this.infCollector.Controls.Add(this.dataGridView5);
            this.infCollector.Location = new System.Drawing.Point(4, 22);
            this.infCollector.Name = "infCollector";
            this.infCollector.Padding = new System.Windows.Forms.Padding(3);
            this.infCollector.Size = new System.Drawing.Size(599, 141);
            this.infCollector.TabIndex = 1;
            this.infCollector.Text = "О владельце";
            this.infCollector.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имяDataGridViewTextBoxColumn1,
            this.странаDataGridViewTextBoxColumn3,
            this.контактыDataGridViewTextBoxColumn1,
            this.местоУчёбыDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.infCollectorBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(590, 129);
            this.dataGridView5.TabIndex = 0;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            // 
            // странаDataGridViewTextBoxColumn3
            // 
            this.странаDataGridViewTextBoxColumn3.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn3.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn3.Name = "странаDataGridViewTextBoxColumn3";
            // 
            // контактыDataGridViewTextBoxColumn1
            // 
            this.контактыDataGridViewTextBoxColumn1.DataPropertyName = "Контакты";
            this.контактыDataGridViewTextBoxColumn1.HeaderText = "Контакты";
            this.контактыDataGridViewTextBoxColumn1.Name = "контактыDataGridViewTextBoxColumn1";
            // 
            // местоУчёбыDataGridViewTextBoxColumn
            // 
            this.местоУчёбыDataGridViewTextBoxColumn.DataPropertyName = "Место учёбы";
            this.местоУчёбыDataGridViewTextBoxColumn.HeaderText = "Место учёбы";
            this.местоУчёбыDataGridViewTextBoxColumn.Name = "местоУчёбыDataGridViewTextBoxColumn";
            // 
            // infCollectorBindingSource
            // 
            this.infCollectorBindingSource.DataMember = "infCollector";
            this.infCollectorBindingSource.DataSource = this.databaseDataSet;
            // 
            // textBoxValueToSearch
            // 
            this.textBoxValueToSearch.Location = new System.Drawing.Point(42, 70);
            this.textBoxValueToSearch.Name = "textBoxValueToSearch";
            this.textBoxValueToSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxValueToSearch.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(160, 67);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Comment
            // 
            this.Comment.AutoGenerateColumns = false;
            this.Comment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Comment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.имяDataGridViewTextBoxColumn2,
            this.комментарийDataGridViewTextBoxColumn});
            this.Comment.DataSource = this.commentBindingSource;
            this.Comment.Location = new System.Drawing.Point(289, 326);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(586, 81);
            this.Comment.TabIndex = 5;
            this.Comment.TabStop = false;
            this.Comment.Tag = "4";
            // 
            // имяDataGridViewTextBoxColumn2
            // 
            this.имяDataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn2.Name = "имяDataGridViewTextBoxColumn2";
            // 
            // комментарийDataGridViewTextBoxColumn
            // 
            this.комментарийDataGridViewTextBoxColumn.DataPropertyName = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.комментарийDataGridViewTextBoxColumn.Name = "комментарийDataGridViewTextBoxColumn";
            this.комментарийDataGridViewTextBoxColumn.Width = 450;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataMember = "Comment";
            this.commentBindingSource.DataSource = this.databaseDataSet;
            // 
            // allcoinTableAdapter
            // 
            this.allcoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AllcoinTableAdapter = this.allcoinTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CommentTableAdapter = null;
            this.tableAdapterManager.infCollectorTableAdapter = this.infCollectorTableAdapter;
            this.tableAdapterManager.myCollectionTableAdapter = this.myCollectionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Handbook_of_numismatis.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.СollectorTableAdapter = this.сollectorTableAdapter;
            // 
            // infCollectorTableAdapter
            // 
            this.infCollectorTableAdapter.ClearBeforeFill = true;
            // 
            // myCollectionTableAdapter
            // 
            this.myCollectionTableAdapter.ClearBeforeFill = true;
            // 
            // сollectorTableAdapter
            // 
            this.сollectorTableAdapter.ClearBeforeFill = true;
            // 
            // commentTableAdapter
            // 
            this.commentTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(345, 449);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(465, 449);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(27, 454);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            // 
            // номиналDataGridViewTextBoxColumn
            // 
            this.номиналDataGridViewTextBoxColumn.DataPropertyName = "Номинал";
            this.номиналDataGridViewTextBoxColumn.HeaderText = "Номинал";
            this.номиналDataGridViewTextBoxColumn.Name = "номиналDataGridViewTextBoxColumn";
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = " Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            // 
            // сплавDataGridViewTextBoxColumn
            // 
            this.сплавDataGridViewTextBoxColumn.DataPropertyName = "Сплав";
            this.сплавDataGridViewTextBoxColumn.HeaderText = "Сплав";
            this.сплавDataGridViewTextBoxColumn.Name = "сплавDataGridViewTextBoxColumn";
            // 
            // количествоВыпущенныхМонетDataGridViewTextBoxColumn
            // 
            this.количествоВыпущенныхМонетDataGridViewTextBoxColumn.DataPropertyName = "Количество выпущенных монет";
            this.количествоВыпущенныхМонетDataGridViewTextBoxColumn.HeaderText = "Количество выпущенных монет";
            this.количествоВыпущенныхМонетDataGridViewTextBoxColumn.Name = "количествоВыпущенныхМонетDataGridViewTextBoxColumn";
            // 
            // особенностиDataGridViewTextBoxColumn
            // 
            this.особенностиDataGridViewTextBoxColumn.DataPropertyName = "Особенности";
            this.особенностиDataGridViewTextBoxColumn.HeaderText = "Особенности";
            this.особенностиDataGridViewTextBoxColumn.Name = "особенностиDataGridViewTextBoxColumn";
            // 
            // изображениеDataGridViewImageColumn
            // 
            this.изображениеDataGridViewImageColumn.DataPropertyName = "Изображение";
            this.изображениеDataGridViewImageColumn.HeaderText = "Изображение";
            this.изображениеDataGridViewImageColumn.Name = "изображениеDataGridViewImageColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 489);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBoxValueToSearch);
            this.Controls.Add(this.tadble);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tadble.ResumeLayout(false);
            this.Coin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allcoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.Collector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сollectorBindingSource)).EndInit();
            this.Own_collection.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.myCollection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCollectionBindingSource)).EndInit();
            this.infCollector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infCollectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tadble;
        private System.Windows.Forms.TabPage Coin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage Collector;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage Own_collection;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage myCollection;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage infCollector;
        private System.Windows.Forms.DataGridView dataGridView5;
        public DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource allcoinBindingSource;
        private DatabaseDataSetTableAdapters.AllcoinTableAdapter allcoinTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.СollectorTableAdapter сollectorTableAdapter;
        private System.Windows.Forms.BindingSource сollectorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наличиеРедкихМонетDataGridViewTextBoxColumn;
        private DatabaseDataSetTableAdapters.myCollectionTableAdapter myCollectionTableAdapter;
        private System.Windows.Forms.BindingSource myCollectionBindingSource;
        private DatabaseDataSetTableAdapters.infCollectorTableAdapter infCollectorTableAdapter;
        private System.Windows.Forms.BindingSource infCollectorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоУчёбыDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxValueToSearch;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn сплавDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn информацияПроПредыдущихDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView Comment;
        public System.Windows.Forms.BindingSource commentBindingSource;
        public DatabaseDataSetTableAdapters.CommentTableAdapter commentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn комментарийDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номиналDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сплавDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоВыпущенныхМонетDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn особенностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn изображениеDataGridViewImageColumn;
    }
}