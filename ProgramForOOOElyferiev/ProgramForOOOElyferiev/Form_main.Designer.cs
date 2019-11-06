namespace ProgramForOOOElyferiev
{
    partial class Main_program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_program));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh_table = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseBase = new System.Windows.Forms.ToolStripMenuItem();
            this.Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.picture_start = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.text_result_count = new System.Windows.Forms.TextBox();
            this.linkLabel_site = new System.Windows.Forms.LinkLabel();
            this.label_order = new System.Windows.Forms.Label();
            this.button_check_result = new System.Windows.Forms.Button();
            this.text_result = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.text_refresh_name = new System.Windows.Forms.TextBox();
            this.label_refresh_name = new System.Windows.Forms.Label();
            this.text_refresh_count = new System.Windows.Forms.TextBox();
            this.text_refresh_price = new System.Windows.Forms.TextBox();
            this.text_refresh_id = new System.Windows.Forms.TextBox();
            this.label_refresh_count = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.label_refresh_price = new System.Windows.Forms.Label();
            this.label_refresh_id = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.text_remove_id = new System.Windows.Forms.TextBox();
            this.label_remove_id = new System.Windows.Forms.Label();
            this.button_remove = new System.Windows.Forms.Button();
            this.label_remove_name = new System.Windows.Forms.Label();
            this.text_remove_name = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.text_add_count = new System.Windows.Forms.TextBox();
            this.text_add_country = new System.Windows.Forms.TextBox();
            this.text_add_price = new System.Windows.Forms.TextBox();
            this.text_add_name = new System.Windows.Forms.TextBox();
            this.label_add_count = new System.Windows.Forms.Label();
            this.label_add_country = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_add_price = new System.Windows.Forms.Label();
            this.label_add_name = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.text_log_operation_time = new System.Windows.Forms.TextBox();
            this.text_log_product_name = new System.Windows.Forms.TextBox();
            this.text_log_operation_name = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refresh_table,
            this.ChooseBase,
            this.Quit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // Refresh_table
            // 
            this.Refresh_table.Name = "Refresh_table";
            this.Refresh_table.Size = new System.Drawing.Size(200, 22);
            this.Refresh_table.Text = "Обновить таблицу";
            this.Refresh_table.Click += new System.EventHandler(this.Refresh_table_Click);
            // 
            // ChooseBase
            // 
            this.ChooseBase.Name = "ChooseBase";
            this.ChooseBase.Size = new System.Drawing.Size(200, 22);
            this.ChooseBase.Text = "Выбрать базу данных...";
            this.ChooseBase.Click += new System.EventHandler(this.ChooseBase_Click);
            // 
            // Quit
            // 
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(200, 22);
            this.Quit.Text = "Выход";
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(149, 22);
            this.AboutProgram.Text = "О программе";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // picture_start
            // 
            this.picture_start.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture_start.BackgroundImage")));
            this.picture_start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_start.Location = new System.Drawing.Point(0, 0);
            this.picture_start.Name = "picture_start";
            this.picture_start.Size = new System.Drawing.Size(884, 561);
            this.picture_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_start.TabIndex = 2;
            this.picture_start.TabStop = false;
            this.picture_start.Visible = false;
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(534, 283);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(159, 56);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "Начать работу";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Visible = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::ProgramForOOOElyferiev.Properties.Resources.imgonline_com_ua_Resize_vAeiN8stDFv9;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.text_result_count);
            this.tabPage5.Controls.Add(this.linkLabel_site);
            this.tabPage5.Controls.Add(this.label_order);
            this.tabPage5.Controls.Add(this.button_check_result);
            this.tabPage5.Controls.Add(this.text_result);
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(876, 510);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Заказ продукции";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // text_result_count
            // 
            this.text_result_count.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_result_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_result_count.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_result_count.Location = new System.Drawing.Point(440, 53);
            this.text_result_count.Multiline = true;
            this.text_result_count.Name = "text_result_count";
            this.text_result_count.ReadOnly = true;
            this.text_result_count.Size = new System.Drawing.Size(127, 349);
            this.text_result_count.TabIndex = 13;
            // 
            // linkLabel_site
            // 
            this.linkLabel_site.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_site.Location = new System.Drawing.Point(613, 405);
            this.linkLabel_site.Name = "linkLabel_site";
            this.linkLabel_site.Size = new System.Drawing.Size(235, 25);
            this.linkLabel_site.TabIndex = 12;
            this.linkLabel_site.TabStop = true;
            this.linkLabel_site.Text = "Перейти на сайт заказчика";
            this.linkLabel_site.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_site_LinkClicked);
            // 
            // label_order
            // 
            this.label_order.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_order.Location = new System.Drawing.Point(54, 405);
            this.label_order.Name = "label_order";
            this.label_order.Size = new System.Drawing.Size(775, 30);
            this.label_order.TabIndex = 11;
            this.label_order.Text = "Произвести заказ можно по телефону (8-921-369-02-35) или через сайт :";
            // 
            // button_check_result
            // 
            this.button_check_result.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_check_result.Location = new System.Drawing.Point(573, 352);
            this.button_check_result.Name = "button_check_result";
            this.button_check_result.Size = new System.Drawing.Size(142, 50);
            this.button_check_result.TabIndex = 10;
            this.button_check_result.Text = "Проверить информацию";
            this.button_check_result.UseVisualStyleBackColor = true;
            this.button_check_result.Click += new System.EventHandler(this.Button_check_result_Click);
            // 
            // text_result
            // 
            this.text_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_result.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_result.Location = new System.Drawing.Point(144, 53);
            this.text_result.Multiline = true;
            this.text_result.Name = "text_result";
            this.text_result.ReadOnly = true;
            this.text_result.Size = new System.Drawing.Size(301, 349);
            this.text_result.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::ProgramForOOOElyferiev.Properties.Resources.imgonline_com_ua_Resize_vAeiN8stDFv9;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.text_refresh_name);
            this.tabPage4.Controls.Add(this.label_refresh_name);
            this.tabPage4.Controls.Add(this.text_refresh_count);
            this.tabPage4.Controls.Add(this.text_refresh_price);
            this.tabPage4.Controls.Add(this.text_refresh_id);
            this.tabPage4.Controls.Add(this.label_refresh_count);
            this.tabPage4.Controls.Add(this.button_refresh);
            this.tabPage4.Controls.Add(this.label_refresh_price);
            this.tabPage4.Controls.Add(this.label_refresh_id);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(876, 510);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Обновить информацию";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // text_refresh_name
            // 
            this.text_refresh_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_refresh_name.Location = new System.Drawing.Point(622, 65);
            this.text_refresh_name.Multiline = true;
            this.text_refresh_name.Name = "text_refresh_name";
            this.text_refresh_name.Size = new System.Drawing.Size(189, 37);
            this.text_refresh_name.TabIndex = 13;
            // 
            // label_refresh_name
            // 
            this.label_refresh_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_refresh_name.Location = new System.Drawing.Point(487, 71);
            this.label_refresh_name.Name = "label_refresh_name";
            this.label_refresh_name.Size = new System.Drawing.Size(129, 34);
            this.label_refresh_name.TabIndex = 12;
            this.label_refresh_name.Text = "Наименование продукции ";
            // 
            // text_refresh_count
            // 
            this.text_refresh_count.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_refresh_count.Location = new System.Drawing.Point(272, 171);
            this.text_refresh_count.Multiline = true;
            this.text_refresh_count.Name = "text_refresh_count";
            this.text_refresh_count.Size = new System.Drawing.Size(189, 37);
            this.text_refresh_count.TabIndex = 11;
            // 
            // text_refresh_price
            // 
            this.text_refresh_price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_refresh_price.Location = new System.Drawing.Point(622, 171);
            this.text_refresh_price.Multiline = true;
            this.text_refresh_price.Name = "text_refresh_price";
            this.text_refresh_price.Size = new System.Drawing.Size(189, 37);
            this.text_refresh_price.TabIndex = 6;
            // 
            // text_refresh_id
            // 
            this.text_refresh_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_refresh_id.Location = new System.Drawing.Point(272, 68);
            this.text_refresh_id.Multiline = true;
            this.text_refresh_id.Name = "text_refresh_id";
            this.text_refresh_id.Size = new System.Drawing.Size(189, 37);
            this.text_refresh_id.TabIndex = 5;
            // 
            // label_refresh_count
            // 
            this.label_refresh_count.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_refresh_count.Location = new System.Drawing.Point(122, 171);
            this.label_refresh_count.Name = "label_refresh_count";
            this.label_refresh_count.Size = new System.Drawing.Size(144, 34);
            this.label_refresh_count.TabIndex = 10;
            this.label_refresh_count.Text = "Количество(в кг)";
            // 
            // button_refresh
            // 
            this.button_refresh.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.Location = new System.Drawing.Point(376, 328);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(142, 35);
            this.button_refresh.TabIndex = 9;
            this.button_refresh.Text = "Изменить";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // label_refresh_price
            // 
            this.label_refresh_price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_refresh_price.Location = new System.Drawing.Point(487, 171);
            this.label_refresh_price.Name = "label_refresh_price";
            this.label_refresh_price.Size = new System.Drawing.Size(129, 34);
            this.label_refresh_price.TabIndex = 8;
            this.label_refresh_price.Text = "Цена продукции";
            // 
            // label_refresh_id
            // 
            this.label_refresh_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_refresh_id.Location = new System.Drawing.Point(122, 68);
            this.label_refresh_id.Name = "label_refresh_id";
            this.label_refresh_id.Size = new System.Drawing.Size(144, 37);
            this.label_refresh_id.TabIndex = 7;
            this.label_refresh_id.Text = "Идентификатор продукции";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ProgramForOOOElyferiev.Properties.Resources.imgonline_com_ua_Resize_vAeiN8stDFv9;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.text_remove_id);
            this.tabPage3.Controls.Add(this.label_remove_id);
            this.tabPage3.Controls.Add(this.button_remove);
            this.tabPage3.Controls.Add(this.label_remove_name);
            this.tabPage3.Controls.Add(this.text_remove_name);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить продукцию";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // text_remove_id
            // 
            this.text_remove_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_remove_id.Location = new System.Drawing.Point(615, 79);
            this.text_remove_id.Multiline = true;
            this.text_remove_id.Name = "text_remove_id";
            this.text_remove_id.Size = new System.Drawing.Size(189, 37);
            this.text_remove_id.TabIndex = 11;
            // 
            // label_remove_id
            // 
            this.label_remove_id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_remove_id.Location = new System.Drawing.Point(465, 79);
            this.label_remove_id.Name = "label_remove_id";
            this.label_remove_id.Size = new System.Drawing.Size(144, 35);
            this.label_remove_id.TabIndex = 10;
            this.label_remove_id.Text = "Идентификатор продукции";
            // 
            // button_remove
            // 
            this.button_remove.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_remove.Location = new System.Drawing.Point(347, 199);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(142, 35);
            this.button_remove.TabIndex = 9;
            this.button_remove.Text = "Удалить";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.Button_remove_Click);
            // 
            // label_remove_name
            // 
            this.label_remove_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_remove_name.Location = new System.Drawing.Point(120, 76);
            this.label_remove_name.Name = "label_remove_name";
            this.label_remove_name.Size = new System.Drawing.Size(144, 34);
            this.label_remove_name.TabIndex = 7;
            this.label_remove_name.Text = "Наименование продукции";
            // 
            // text_remove_name
            // 
            this.text_remove_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_remove_name.Location = new System.Drawing.Point(270, 76);
            this.text_remove_name.Multiline = true;
            this.text_remove_name.Name = "text_remove_name";
            this.text_remove_name.Size = new System.Drawing.Size(189, 37);
            this.text_remove_name.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Найти продукцию";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(870, 504);
            this.dataGridView.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наимнование";
            this.Column1.Name = "Column1";
            this.Column1.Width = 300;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Цена(руб/кг)";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Страна производитель";
            this.Column3.Name = "Column3";
            this.Column3.Width = 290;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество товара на складе(кг)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 88;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::ProgramForOOOElyferiev.Properties.Resources.imgonline_com_ua_Resize_vAeiN8stDFv9;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.text_add_count);
            this.tabPage2.Controls.Add(this.text_add_country);
            this.tabPage2.Controls.Add(this.text_add_price);
            this.tabPage2.Controls.Add(this.text_add_name);
            this.tabPage2.Controls.Add(this.label_add_count);
            this.tabPage2.Controls.Add(this.label_add_country);
            this.tabPage2.Controls.Add(this.button_add);
            this.tabPage2.Controls.Add(this.label_add_price);
            this.tabPage2.Controls.Add(this.label_add_name);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить продукцию ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // text_add_count
            // 
            this.text_add_count.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_add_count.Location = new System.Drawing.Point(634, 144);
            this.text_add_count.Multiline = true;
            this.text_add_count.Name = "text_add_count";
            this.text_add_count.Size = new System.Drawing.Size(189, 34);
            this.text_add_count.TabIndex = 8;
            // 
            // text_add_country
            // 
            this.text_add_country.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_add_country.Location = new System.Drawing.Point(264, 141);
            this.text_add_country.Multiline = true;
            this.text_add_country.Name = "text_add_country";
            this.text_add_country.Size = new System.Drawing.Size(189, 37);
            this.text_add_country.TabIndex = 6;
            // 
            // text_add_price
            // 
            this.text_add_price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_add_price.Location = new System.Drawing.Point(634, 61);
            this.text_add_price.Multiline = true;
            this.text_add_price.Name = "text_add_price";
            this.text_add_price.Size = new System.Drawing.Size(189, 34);
            this.text_add_price.TabIndex = 1;
            // 
            // text_add_name
            // 
            this.text_add_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_add_name.Location = new System.Drawing.Point(264, 61);
            this.text_add_name.Multiline = true;
            this.text_add_name.Name = "text_add_name";
            this.text_add_name.Size = new System.Drawing.Size(189, 34);
            this.text_add_name.TabIndex = 0;
            // 
            // label_add_count
            // 
            this.label_add_count.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_count.Location = new System.Drawing.Point(459, 144);
            this.label_add_count.Name = "label_add_count";
            this.label_add_count.Size = new System.Drawing.Size(169, 34);
            this.label_add_count.TabIndex = 7;
            this.label_add_count.Text = "Количество(в кг)";
            // 
            // label_add_country
            // 
            this.label_add_country.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_country.Location = new System.Drawing.Point(114, 141);
            this.label_add_country.Name = "label_add_country";
            this.label_add_country.Size = new System.Drawing.Size(144, 34);
            this.label_add_country.TabIndex = 5;
            this.label_add_country.Text = "Страна производитель";
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(335, 236);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(142, 35);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label_add_price
            // 
            this.label_add_price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_price.Location = new System.Drawing.Point(459, 61);
            this.label_add_price.Name = "label_add_price";
            this.label_add_price.Size = new System.Drawing.Size(169, 34);
            this.label_add_price.TabIndex = 3;
            this.label_add_price.Text = "Цена продукции";
            // 
            // label_add_name
            // 
            this.label_add_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_name.Location = new System.Drawing.Point(114, 61);
            this.label_add_name.Name = "label_add_name";
            this.label_add_name.Size = new System.Drawing.Size(144, 34);
            this.label_add_name.TabIndex = 2;
            this.label_add_name.Text = "Наименование продукции";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 537);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackgroundImage = global::ProgramForOOOElyferiev.Properties.Resources.imgonline_com_ua_Resize_vAeiN8stDFv9;
            this.tabPage6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage6.Controls.Add(this.text_log_operation_time);
            this.tabPage6.Controls.Add(this.text_log_product_name);
            this.tabPage6.Controls.Add(this.text_log_operation_name);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(876, 510);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Лог операций";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // text_log_operation_time
            // 
            this.text_log_operation_time.Location = new System.Drawing.Point(619, 56);
            this.text_log_operation_time.Multiline = true;
            this.text_log_operation_time.Name = "text_log_operation_time";
            this.text_log_operation_time.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_log_operation_time.Size = new System.Drawing.Size(173, 410);
            this.text_log_operation_time.TabIndex = 2;
            this.text_log_operation_time.Text = "Время операции";
            // 
            // text_log_product_name
            // 
            this.text_log_product_name.Location = new System.Drawing.Point(325, 56);
            this.text_log_product_name.Multiline = true;
            this.text_log_product_name.Name = "text_log_product_name";
            this.text_log_product_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_log_product_name.Size = new System.Drawing.Size(299, 410);
            this.text_log_product_name.TabIndex = 1;
            this.text_log_product_name.Text = "Наименование продукции";
            // 
            // text_log_operation_name
            // 
            this.text_log_operation_name.Location = new System.Drawing.Point(98, 56);
            this.text_log_operation_name.Multiline = true;
            this.text_log_operation_name.Name = "text_log_operation_name";
            this.text_log_operation_name.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_log_operation_name.Size = new System.Drawing.Size(231, 410);
            this.text_log_operation_name.TabIndex = 0;
            this.text_log_operation_name.Text = "Название операции";
            // 
            // Main_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picture_start);
            this.Controls.Add(this.button_start);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_program";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для продуктового магазина ООО \"Елуферьев\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_start)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChooseBase;
        private System.Windows.Forms.ToolStripMenuItem Quit;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox picture_start;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.LinkLabel linkLabel_site;
        private System.Windows.Forms.Label label_order;
        private System.Windows.Forms.Button button_check_result;
        private System.Windows.Forms.TextBox text_result;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox text_refresh_count;
        private System.Windows.Forms.TextBox text_refresh_price;
        private System.Windows.Forms.TextBox text_refresh_id;
        private System.Windows.Forms.Label label_refresh_count;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.Label label_refresh_price;
        private System.Windows.Forms.Label label_refresh_id;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Label label_remove_name;
        private System.Windows.Forms.TextBox text_remove_name;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox text_add_count;
        private System.Windows.Forms.TextBox text_add_country;
        private System.Windows.Forms.TextBox text_add_price;
        private System.Windows.Forms.TextBox text_add_name;
        private System.Windows.Forms.Label label_add_count;
        private System.Windows.Forms.Label label_add_country;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_add_price;
        private System.Windows.Forms.Label label_add_name;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem Refresh_table;
        private System.Windows.Forms.TextBox text_refresh_name;
        private System.Windows.Forms.Label label_refresh_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox text_remove_id;
        private System.Windows.Forms.Label label_remove_id;
        private System.Windows.Forms.TextBox text_result_count;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox text_log_operation_time;
        private System.Windows.Forms.TextBox text_log_product_name;
        private System.Windows.Forms.TextBox text_log_operation_name;
    }
}

