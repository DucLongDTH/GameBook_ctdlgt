namespace GameBook
{
    partial class MainBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainBoard));
            this.pnMain = new System.Windows.Forms.Panel();
            this.lstTypeSort = new System.Windows.Forms.ListBox();
            this.lstFilter = new System.Windows.Forms.ListBox();
            this.lstSort = new System.Windows.Forms.ListBox();
            this.pnListControl = new System.Windows.Forms.Panel();
            this.lbListPrice = new System.Windows.Forms.Label();
            this.lbListCategory = new System.Windows.Forms.Label();
            this.lbListVer = new System.Windows.Forms.Label();
            this.lbListRlDate = new System.Windows.Forms.Label();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.lbListTitle = new System.Windows.Forms.Label();
            this.borderTop = new System.Windows.Forms.Panel();
            this.btnListView = new System.Windows.Forms.PictureBox();
            this.btnGridView = new System.Windows.Forms.PictureBox();
            this.pnDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTool = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecSort = new System.Windows.Forms.Button();
            this.btnType = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbCountGame = new System.Windows.Forms.Label();
            this.lbTabChoosen = new System.Windows.Forms.Label();
            this.pnControl = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.icoNews = new System.Windows.Forms.PictureBox();
            this.btnNews = new System.Windows.Forms.Button();
            this.icoSetting = new System.Windows.Forms.PictureBox();
            this.btnSetting = new System.Windows.Forms.Button();
            this.icoUser = new System.Windows.Forms.PictureBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.icoFriend = new System.Windows.Forms.PictureBox();
            this.btnFriend = new System.Windows.Forms.Button();
            this.icoLib = new System.Windows.Forms.PictureBox();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.icoStore = new System.Windows.Forms.PictureBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.pnMain.SuspendLayout();
            this.pnListControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGridView)).BeginInit();
            this.pnTool.SuspendLayout();
            this.pnSearch.SuspendLayout();
            this.pnControl.SuspendLayout();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.pnLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoNews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoLib)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoStore)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.pnMain.Controls.Add(this.lstTypeSort);
            this.pnMain.Controls.Add(this.lstFilter);
            this.pnMain.Controls.Add(this.lstSort);
            this.pnMain.Controls.Add(this.pnListControl);
            this.pnMain.Controls.Add(this.btnListView);
            this.pnMain.Controls.Add(this.btnGridView);
            this.pnMain.Controls.Add(this.pnDisplay);
            this.pnMain.Controls.Add(this.pnTool);
            this.pnMain.Controls.Add(this.lbCountGame);
            this.pnMain.Controls.Add(this.lbTabChoosen);
            this.pnMain.Controls.Add(this.pnControl);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(191, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1169, 749);
            this.pnMain.TabIndex = 1;
            // 
            // lstTypeSort
            // 
            this.lstTypeSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.lstTypeSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTypeSort.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTypeSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lstTypeSort.FormattingEnabled = true;
            this.lstTypeSort.ItemHeight = 21;
            this.lstTypeSort.Location = new System.Drawing.Point(693, 144);
            this.lstTypeSort.Name = "lstTypeSort";
            this.lstTypeSort.Size = new System.Drawing.Size(133, 63);
            this.lstTypeSort.TabIndex = 6;
            this.lstTypeSort.SelectedIndexChanged += new System.EventHandler(this.lstTypeSort_SelectedIndexChanged);
            // 
            // lstFilter
            // 
            this.lstFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.lstFilter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstFilter.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lstFilter.FormattingEnabled = true;
            this.lstFilter.ItemHeight = 21;
            this.lstFilter.Items.AddRange(new object[] {
            "AAA & Indie",
            "AAA Only",
            "Indie Only"});
            this.lstFilter.Location = new System.Drawing.Point(834, 144);
            this.lstFilter.Name = "lstFilter";
            this.lstFilter.Size = new System.Drawing.Size(170, 63);
            this.lstFilter.TabIndex = 6;
            this.lstFilter.SelectedIndexChanged += new System.EventHandler(this.lstFilter_SelectedIndexChanged);
            // 
            // lstSort
            // 
            this.lstSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.lstSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSort.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lstSort.FormattingEnabled = true;
            this.lstSort.ItemHeight = 21;
            this.lstSort.Items.AddRange(new object[] {
            "Name",
            "Release Date",
            "Price"});
            this.lstSort.Location = new System.Drawing.Point(484, 144);
            this.lstSort.Name = "lstSort";
            this.lstSort.Size = new System.Drawing.Size(200, 63);
            this.lstSort.TabIndex = 6;
            this.lstSort.SelectedIndexChanged += new System.EventHandler(this.lstSort_SelectedIndexChanged);
            // 
            // pnListControl
            // 
            this.pnListControl.Controls.Add(this.lbListPrice);
            this.pnListControl.Controls.Add(this.lbListCategory);
            this.pnListControl.Controls.Add(this.lbListVer);
            this.pnListControl.Controls.Add(this.lbListRlDate);
            this.pnListControl.Controls.Add(this.borderBottom);
            this.pnListControl.Controls.Add(this.lbListTitle);
            this.pnListControl.Controls.Add(this.borderTop);
            this.pnListControl.Location = new System.Drawing.Point(13, 171);
            this.pnListControl.Name = "pnListControl";
            this.pnListControl.Size = new System.Drawing.Size(1142, 24);
            this.pnListControl.TabIndex = 15;
            // 
            // lbListPrice
            // 
            this.lbListPrice.AutoSize = true;
            this.lbListPrice.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lbListPrice.Location = new System.Drawing.Point(954, 2);
            this.lbListPrice.Name = "lbListPrice";
            this.lbListPrice.Size = new System.Drawing.Size(56, 21);
            this.lbListPrice.TabIndex = 8;
            this.lbListPrice.Text = "PRICE";
            // 
            // lbListCategory
            // 
            this.lbListCategory.AutoSize = true;
            this.lbListCategory.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lbListCategory.Location = new System.Drawing.Point(779, 2);
            this.lbListCategory.Name = "lbListCategory";
            this.lbListCategory.Size = new System.Drawing.Size(97, 21);
            this.lbListCategory.TabIndex = 7;
            this.lbListCategory.Text = "CATEGORY";
            // 
            // lbListVer
            // 
            this.lbListVer.AutoSize = true;
            this.lbListVer.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListVer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lbListVer.Location = new System.Drawing.Point(635, 2);
            this.lbListVer.Name = "lbListVer";
            this.lbListVer.Size = new System.Drawing.Size(79, 21);
            this.lbListVer.TabIndex = 6;
            this.lbListVer.Text = "VERSION";
            // 
            // lbListRlDate
            // 
            this.lbListRlDate.AutoSize = true;
            this.lbListRlDate.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListRlDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lbListRlDate.Location = new System.Drawing.Point(449, 2);
            this.lbListRlDate.Name = "lbListRlDate";
            this.lbListRlDate.Size = new System.Drawing.Size(122, 21);
            this.lbListRlDate.TabIndex = 5;
            this.lbListRlDate.Text = "RELEASE DATE";
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom.Location = new System.Drawing.Point(0, 23);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(1142, 1);
            this.borderBottom.TabIndex = 1;
            // 
            // lbListTitle
            // 
            this.lbListTitle.AutoSize = true;
            this.lbListTitle.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.lbListTitle.Location = new System.Drawing.Point(123, 2);
            this.lbListTitle.Name = "lbListTitle";
            this.lbListTitle.Size = new System.Drawing.Size(103, 21);
            this.lbListTitle.TabIndex = 3;
            this.lbListTitle.Text = "GAME TITLE";
            // 
            // borderTop
            // 
            this.borderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(74)))), ((int)(((byte)(79)))));
            this.borderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTop.Location = new System.Drawing.Point(0, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(1142, 1);
            this.borderTop.TabIndex = 0;
            // 
            // btnListView
            // 
            this.btnListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListView.Image = global::GameBook.Properties.Resources.list_view;
            this.btnListView.Location = new System.Drawing.Point(1123, 54);
            this.btnListView.Name = "btnListView";
            this.btnListView.Size = new System.Drawing.Size(30, 30);
            this.btnListView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnListView.TabIndex = 14;
            this.btnListView.TabStop = false;
            this.btnListView.Click += new System.EventHandler(this.btnListView_Click);
            // 
            // btnGridView
            // 
            this.btnGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGridView.Image = global::GameBook.Properties.Resources.grid_view;
            this.btnGridView.Location = new System.Drawing.Point(1076, 54);
            this.btnGridView.Name = "btnGridView";
            this.btnGridView.Size = new System.Drawing.Size(30, 30);
            this.btnGridView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnGridView.TabIndex = 13;
            this.btnGridView.TabStop = false;
            this.btnGridView.Click += new System.EventHandler(this.btnGridView_Click);
            // 
            // pnDisplay
            // 
            this.pnDisplay.AutoScroll = true;
            this.pnDisplay.Location = new System.Drawing.Point(13, 213);
            this.pnDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(1177, 536);
            this.pnDisplay.TabIndex = 4;
            // 
            // pnTool
            // 
            this.pnTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.pnTool.Controls.Add(this.label3);
            this.pnTool.Controls.Add(this.label2);
            this.pnTool.Controls.Add(this.label1);
            this.pnTool.Controls.Add(this.btnExecSort);
            this.pnTool.Controls.Add(this.btnType);
            this.pnTool.Controls.Add(this.btnSort);
            this.pnTool.Controls.Add(this.btnFilter);
            this.pnTool.Controls.Add(this.btnSearch);
            this.pnTool.Controls.Add(this.pnSearch);
            this.pnTool.Location = new System.Drawing.Point(13, 101);
            this.pnTool.Margin = new System.Windows.Forms.Padding(0);
            this.pnTool.Name = "pnTool";
            this.pnTool.Size = new System.Drawing.Size(1142, 54);
            this.pnTool.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(966, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "⯆";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.label2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(789, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "⯆";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.label1.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(646, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "⯆";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExecSort
            // 
            this.btnExecSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.btnExecSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecSort.FlatAppearance.BorderSize = 0;
            this.btnExecSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnExecSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecSort.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnExecSort.Location = new System.Drawing.Point(1000, 9);
            this.btnExecSort.Margin = new System.Windows.Forms.Padding(0);
            this.btnExecSort.Name = "btnExecSort";
            this.btnExecSort.Size = new System.Drawing.Size(128, 34);
            this.btnExecSort.TabIndex = 5;
            this.btnExecSort.Text = "Sort";
            this.btnExecSort.UseVisualStyleBackColor = false;
            this.btnExecSort.Click += new System.EventHandler(this.btnExecSort_Click);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnType.FlatAppearance.BorderSize = 0;
            this.btnType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnType.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnType.Location = new System.Drawing.Point(680, 9);
            this.btnType.Name = "btnType";
            this.btnType.Size = new System.Drawing.Size(133, 34);
            this.btnType.TabIndex = 4;
            this.btnType.UseVisualStyleBackColor = false;
            this.btnType.Click += new System.EventHandler(this.btnType_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnSort.Location = new System.Drawing.Point(471, 9);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(200, 34);
            this.btnSort.TabIndex = 0;
            this.btnSort.Text = "Sort by";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnFilter.Location = new System.Drawing.Point(821, 9);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(170, 34);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.Text = "Filter by";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnSearch.Location = new System.Drawing.Point(335, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 34);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Location = new System.Drawing.Point(12, 9);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(315, 34);
            this.pnSearch.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.tbSearch.Location = new System.Drawing.Point(13, 7);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(289, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search Game Title...";
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lbCountGame
            // 
            this.lbCountGame.AutoSize = true;
            this.lbCountGame.Font = new System.Drawing.Font("Google Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountGame.ForeColor = System.Drawing.Color.White;
            this.lbCountGame.Location = new System.Drawing.Point(84, 49);
            this.lbCountGame.Name = "lbCountGame";
            this.lbCountGame.Size = new System.Drawing.Size(53, 35);
            this.lbCountGame.TabIndex = 2;
            this.lbCountGame.Text = "(0)";
            // 
            // lbTabChoosen
            // 
            this.lbTabChoosen.AutoSize = true;
            this.lbTabChoosen.Font = new System.Drawing.Font("Google Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabChoosen.ForeColor = System.Drawing.Color.White;
            this.lbTabChoosen.Location = new System.Drawing.Point(7, 49);
            this.lbTabChoosen.Name = "lbTabChoosen";
            this.lbTabChoosen.Size = new System.Drawing.Size(85, 35);
            this.lbTabChoosen.TabIndex = 1;
            this.lbTabChoosen.Text = "Store";
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btnMinimize);
            this.pnControl.Controls.Add(this.btnExit);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControl.Location = new System.Drawing.Point(0, 0);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(1169, 38);
            this.pnControl.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(223)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(142)))), ((int)(((byte)(203)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnMinimize.Location = new System.Drawing.Point(1093, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 38);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "🗕";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(46)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Google Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnExit.Location = new System.Drawing.Point(1131, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "×";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.pnLogo.Controls.Add(this.picbLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(191, 121);
            this.pnLogo.TabIndex = 0;
            // 
            // picbLogo
            // 
            this.picbLogo.Image = global::GameBook.Properties.Resources.gamebook;
            this.picbLogo.Location = new System.Drawing.Point(54, 18);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(85, 85);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbLogo.TabIndex = 0;
            this.picbLogo.TabStop = false;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.pnLeft.Controls.Add(this.icoNews);
            this.pnLeft.Controls.Add(this.btnNews);
            this.pnLeft.Controls.Add(this.icoSetting);
            this.pnLeft.Controls.Add(this.btnSetting);
            this.pnLeft.Controls.Add(this.icoUser);
            this.pnLeft.Controls.Add(this.btnUser);
            this.pnLeft.Controls.Add(this.icoFriend);
            this.pnLeft.Controls.Add(this.btnFriend);
            this.pnLeft.Controls.Add(this.icoLib);
            this.pnLeft.Controls.Add(this.btnLibrary);
            this.pnLeft.Controls.Add(this.icoStore);
            this.pnLeft.Controls.Add(this.btnStore);
            this.pnLeft.Controls.Add(this.pnLogo);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(191, 749);
            this.pnLeft.TabIndex = 0;
            // 
            // icoNews
            // 
            this.icoNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.icoNews.Image = global::GameBook.Properties.Resources.new_ico;
            this.icoNews.Location = new System.Drawing.Point(36, 284);
            this.icoNews.Name = "icoNews";
            this.icoNews.Size = new System.Drawing.Size(22, 22);
            this.icoNews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoNews.TabIndex = 18;
            this.icoNews.TabStop = false;
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNews.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnNews.FlatAppearance.BorderSize = 0;
            this.btnNews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnNews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNews.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnNews.Location = new System.Drawing.Point(0, 271);
            this.btnNews.Margin = new System.Windows.Forms.Padding(0);
            this.btnNews.Name = "btnNews";
            this.btnNews.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.btnNews.Size = new System.Drawing.Size(191, 50);
            this.btnNews.TabIndex = 17;
            this.btnNews.Text = "News";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.UseVisualStyleBackColor = false;
            // 
            // icoSetting
            // 
            this.icoSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.icoSetting.Image = global::GameBook.Properties.Resources.setting_ico;
            this.icoSetting.Location = new System.Drawing.Point(36, 664);
            this.icoSetting.Name = "icoSetting";
            this.icoSetting.Size = new System.Drawing.Size(22, 22);
            this.icoSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoSetting.TabIndex = 16;
            this.icoSetting.TabStop = false;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnSetting.Location = new System.Drawing.Point(0, 649);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(191, 50);
            this.btnSetting.TabIndex = 15;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // icoUser
            // 
            this.icoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.icoUser.Image = global::GameBook.Properties.Resources.user_ico;
            this.icoUser.Location = new System.Drawing.Point(36, 711);
            this.icoUser.Name = "icoUser";
            this.icoUser.Size = new System.Drawing.Size(22, 22);
            this.icoUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoUser.TabIndex = 14;
            this.icoUser.TabStop = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnUser.Location = new System.Drawing.Point(0, 699);
            this.btnUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(191, 50);
            this.btnUser.TabIndex = 13;
            this.btnUser.Text = "User Name";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // icoFriend
            // 
            this.icoFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.icoFriend.Image = global::GameBook.Properties.Resources.friend_ico;
            this.icoFriend.Location = new System.Drawing.Point(36, 234);
            this.icoFriend.Name = "icoFriend";
            this.icoFriend.Size = new System.Drawing.Size(22, 22);
            this.icoFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoFriend.TabIndex = 12;
            this.icoFriend.TabStop = false;
            // 
            // btnFriend
            // 
            this.btnFriend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFriend.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFriend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnFriend.FlatAppearance.BorderSize = 0;
            this.btnFriend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnFriend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriend.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnFriend.Location = new System.Drawing.Point(0, 221);
            this.btnFriend.Margin = new System.Windows.Forms.Padding(0);
            this.btnFriend.Name = "btnFriend";
            this.btnFriend.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.btnFriend.Size = new System.Drawing.Size(191, 50);
            this.btnFriend.TabIndex = 11;
            this.btnFriend.Text = "Friends";
            this.btnFriend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFriend.UseVisualStyleBackColor = false;
            // 
            // icoLib
            // 
            this.icoLib.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.icoLib.Image = global::GameBook.Properties.Resources.lib3_ico;
            this.icoLib.Location = new System.Drawing.Point(36, 184);
            this.icoLib.Name = "icoLib";
            this.icoLib.Size = new System.Drawing.Size(22, 22);
            this.icoLib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoLib.TabIndex = 10;
            this.icoLib.TabStop = false;
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnLibrary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnLibrary.Location = new System.Drawing.Point(0, 171);
            this.btnLibrary.Margin = new System.Windows.Forms.Padding(0);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.btnLibrary.Size = new System.Drawing.Size(191, 50);
            this.btnLibrary.TabIndex = 9;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.UseVisualStyleBackColor = false;
            // 
            // icoStore
            // 
            this.icoStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.icoStore.Image = global::GameBook.Properties.Resources.store2_ico;
            this.icoStore.Location = new System.Drawing.Point(36, 133);
            this.icoStore.Name = "icoStore";
            this.icoStore.Size = new System.Drawing.Size(22, 22);
            this.icoStore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoStore.TabIndex = 8;
            this.icoStore.TabStop = false;
            // 
            // btnStore
            // 
            this.btnStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.btnStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.btnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(17)))), ((int)(((byte)(6)))));
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(229)))), ((int)(((byte)(224)))));
            this.btnStore.Location = new System.Drawing.Point(0, 121);
            this.btnStore.Margin = new System.Windows.Forms.Padding(0);
            this.btnStore.Name = "btnStore";
            this.btnStore.Padding = new System.Windows.Forms.Padding(67, 0, 0, 0);
            this.btnStore.Size = new System.Drawing.Size(191, 50);
            this.btnStore.TabIndex = 7;
            this.btnStore.Text = "Store";
            this.btnStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.UseVisualStyleBackColor = false;
            // 
            // MainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 749);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnLeft);
            this.Font = new System.Drawing.Font("Google Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnListControl.ResumeLayout(false);
            this.pnListControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGridView)).EndInit();
            this.pnTool.ResumeLayout(false);
            this.pnTool.PerformLayout();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.pnControl.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.pnLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoNews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoLib)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Label lbTabChoosen;
        private System.Windows.Forms.Panel pnTool;
        private System.Windows.Forms.Label lbCountGame;
        private System.Windows.Forms.FlowLayoutPanel pnDisplay;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.PictureBox icoStore;
        private System.Windows.Forms.PictureBox icoLib;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnFriend;
        private System.Windows.Forms.PictureBox icoFriend;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.PictureBox icoUser;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox icoSetting;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.PictureBox icoNews;
        private System.Windows.Forms.PictureBox btnGridView;
        private System.Windows.Forms.PictureBox btnListView;
        private System.Windows.Forms.Button btnType;
        private System.Windows.Forms.Button btnExecSort;
        private System.Windows.Forms.Panel pnListControl;
        private System.Windows.Forms.Panel borderBottom;
        private System.Windows.Forms.Panel borderTop;
        private System.Windows.Forms.Label lbListTitle;
        private System.Windows.Forms.Label lbListRlDate;
        private System.Windows.Forms.Label lbListVer;
        private System.Windows.Forms.Label lbListCategory;
        private System.Windows.Forms.Label lbListPrice;
        private System.Windows.Forms.ListBox lstSort;
        private System.Windows.Forms.ListBox lstFilter;
        private System.Windows.Forms.ListBox lstTypeSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

