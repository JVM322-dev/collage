namespace collage
{
    partial class FullMainWindow
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
            this.dGVMainWindow = new System.Windows.Forms.DataGridView();
            this.tbCosnusltSearch = new System.Windows.Forms.TabControl();
            this.tpStudent = new System.Windows.Forms.TabPage();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearchStudent = new System.Windows.Forms.TextBox();
            this.btAddStudent = new System.Windows.Forms.Button();
            this.btDeleteInfo = new System.Windows.Forms.Button();
            this.tpTeacher = new System.Windows.Forms.TabPage();
            this.lbSearch1 = new System.Windows.Forms.Label();
            this.tbTeacherSearch = new System.Windows.Forms.TextBox();
            this.btAddTeacher = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dGVTeacher = new System.Windows.Forms.DataGridView();
            this.tpGroup = new System.Windows.Forms.TabPage();
            this.lbSearch2 = new System.Windows.Forms.Label();
            this.tbGroupSearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dGVGroup = new System.Windows.Forms.DataGridView();
            this.tpConsult = new System.Windows.Forms.TabPage();
            this.lbSearch4 = new System.Windows.Forms.Label();
            this.tbConsult = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dGVConsult = new System.Windows.Forms.DataGridView();
            this.tpSpecialization = new System.Windows.Forms.TabPage();
            this.lbSearch5 = new System.Windows.Forms.Label();
            this.tbSpecSearch = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dGVSpecialization = new System.Windows.Forms.DataGridView();
            this.tpTitles = new System.Windows.Forms.TabPage();
            this.lbSearch6 = new System.Windows.Forms.Label();
            this.tbVrkTitleSearch = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dGVVkr_Titles = new System.Windows.Forms.DataGridView();
            this.tpFinalyVKR = new System.Windows.Forms.TabPage();
            this.lbSearch7 = new System.Windows.Forms.Label();
            this.tbJobVKRSearch = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.dGV_VKR_JOBS = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMainWindow)).BeginInit();
            this.tbCosnusltSearch.SuspendLayout();
            this.tpStudent.SuspendLayout();
            this.tpTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTeacher)).BeginInit();
            this.tpGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGroup)).BeginInit();
            this.tpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsult)).BeginInit();
            this.tpSpecialization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSpecialization)).BeginInit();
            this.tpTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVkr_Titles)).BeginInit();
            this.tpFinalyVKR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VKR_JOBS)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVMainWindow
            // 
            this.dGVMainWindow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVMainWindow.ColumnHeadersHeight = 29;
            this.dGVMainWindow.Location = new System.Drawing.Point(2, 2);
            this.dGVMainWindow.Margin = new System.Windows.Forms.Padding(2);
            this.dGVMainWindow.Name = "dGVMainWindow";
            this.dGVMainWindow.RowHeadersWidth = 51;
            this.dGVMainWindow.RowTemplate.Height = 24;
            this.dGVMainWindow.Size = new System.Drawing.Size(637, 298);
            this.dGVMainWindow.TabIndex = 0;
            this.dGVMainWindow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVMainWindow_CellContentClick);
            this.dGVMainWindow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dGVMainWindow_KeyDown);
            // 
            // tbCosnusltSearch
            // 
            this.tbCosnusltSearch.Controls.Add(this.tpStudent);
            this.tbCosnusltSearch.Controls.Add(this.tpTeacher);
            this.tbCosnusltSearch.Controls.Add(this.tpGroup);
            this.tbCosnusltSearch.Controls.Add(this.tpConsult);
            this.tbCosnusltSearch.Controls.Add(this.tpSpecialization);
            this.tbCosnusltSearch.Controls.Add(this.tpTitles);
            this.tbCosnusltSearch.Controls.Add(this.tpFinalyVKR);
            this.tbCosnusltSearch.Location = new System.Drawing.Point(9, 10);
            this.tbCosnusltSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbCosnusltSearch.Name = "tbCosnusltSearch";
            this.tbCosnusltSearch.SelectedIndex = 0;
            this.tbCosnusltSearch.Size = new System.Drawing.Size(666, 377);
            this.tbCosnusltSearch.TabIndex = 1;
            // 
            // tpStudent
            // 
            this.tpStudent.Controls.Add(this.button1);
            this.tpStudent.Controls.Add(this.lbSearch);
            this.tpStudent.Controls.Add(this.tbSearchStudent);
            this.tpStudent.Controls.Add(this.btAddStudent);
            this.tpStudent.Controls.Add(this.btDeleteInfo);
            this.tpStudent.Controls.Add(this.dGVMainWindow);
            this.tpStudent.Location = new System.Drawing.Point(4, 22);
            this.tpStudent.Margin = new System.Windows.Forms.Padding(2);
            this.tpStudent.Name = "tpStudent";
            this.tpStudent.Padding = new System.Windows.Forms.Padding(2);
            this.tpStudent.Size = new System.Drawing.Size(658, 351);
            this.tpStudent.TabIndex = 0;
            this.tpStudent.Text = "Студенты";
            this.tpStudent.UseVisualStyleBackColor = true;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(139, 312);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(104, 13);
            this.lbSearch.TabIndex = 9;
            this.lbSearch.Text = "Поисковая строка:";
            // 
            // tbSearchStudent
            // 
            this.tbSearchStudent.Location = new System.Drawing.Point(248, 309);
            this.tbSearchStudent.Name = "tbSearchStudent";
            this.tbSearchStudent.Size = new System.Drawing.Size(258, 20);
            this.tbSearchStudent.TabIndex = 8;
            this.tbSearchStudent.TextChanged += new System.EventHandler(this.tbSearchStudent_TextChanged);
            // 
            // btAddStudent
            // 
            this.btAddStudent.Location = new System.Drawing.Point(5, 308);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(128, 23);
            this.btAddStudent.TabIndex = 6;
            this.btAddStudent.Text = "Добавить информацию";
            this.btAddStudent.UseVisualStyleBackColor = true;
            this.btAddStudent.Click += new System.EventHandler(this.btAddStudent_Click);
            // 
            // btDeleteInfo
            // 
            this.btDeleteInfo.Location = new System.Drawing.Point(511, 306);
            this.btDeleteInfo.Name = "btDeleteInfo";
            this.btDeleteInfo.Size = new System.Drawing.Size(128, 23);
            this.btDeleteInfo.TabIndex = 7;
            this.btDeleteInfo.Text = "Удалить информацию";
            this.btDeleteInfo.UseVisualStyleBackColor = true;
            // 
            // tpTeacher
            // 
            this.tpTeacher.Controls.Add(this.lbSearch1);
            this.tpTeacher.Controls.Add(this.tbTeacherSearch);
            this.tpTeacher.Controls.Add(this.btAddTeacher);
            this.tpTeacher.Controls.Add(this.button2);
            this.tpTeacher.Controls.Add(this.dGVTeacher);
            this.tpTeacher.Location = new System.Drawing.Point(4, 22);
            this.tpTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.tpTeacher.Name = "tpTeacher";
            this.tpTeacher.Padding = new System.Windows.Forms.Padding(2);
            this.tpTeacher.Size = new System.Drawing.Size(642, 336);
            this.tpTeacher.TabIndex = 1;
            this.tpTeacher.Text = "Преподаватели";
            this.tpTeacher.UseVisualStyleBackColor = true;
            // 
            // lbSearch1
            // 
            this.lbSearch1.AutoSize = true;
            this.lbSearch1.Location = new System.Drawing.Point(139, 313);
            this.lbSearch1.Name = "lbSearch1";
            this.lbSearch1.Size = new System.Drawing.Size(104, 13);
            this.lbSearch1.TabIndex = 13;
            this.lbSearch1.Text = "Поисковая строка:";
            // 
            // tbTeacherSearch
            // 
            this.tbTeacherSearch.Location = new System.Drawing.Point(248, 310);
            this.tbTeacherSearch.Name = "tbTeacherSearch";
            this.tbTeacherSearch.Size = new System.Drawing.Size(258, 20);
            this.tbTeacherSearch.TabIndex = 12;
            this.tbTeacherSearch.TextChanged += new System.EventHandler(this.tbTeacherSearch_TextChanged);
            // 
            // btAddTeacher
            // 
            this.btAddTeacher.Location = new System.Drawing.Point(5, 308);
            this.btAddTeacher.Name = "btAddTeacher";
            this.btAddTeacher.Size = new System.Drawing.Size(128, 23);
            this.btAddTeacher.TabIndex = 10;
            this.btAddTeacher.Text = "Добавить информацию";
            this.btAddTeacher.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить информацию";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dGVTeacher
            // 
            this.dGVTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVTeacher.ColumnHeadersHeight = 29;
            this.dGVTeacher.Location = new System.Drawing.Point(4, 4);
            this.dGVTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.dGVTeacher.Name = "dGVTeacher";
            this.dGVTeacher.RowHeadersWidth = 51;
            this.dGVTeacher.RowTemplate.Height = 24;
            this.dGVTeacher.Size = new System.Drawing.Size(637, 298);
            this.dGVTeacher.TabIndex = 1;
            this.dGVTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTeacher_CellContentClick);
            this.dGVTeacher.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTeacher_CellEndEdit);
            this.dGVTeacher.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dGVTeacher_CellValuePushed);
            // 
            // tpGroup
            // 
            this.tpGroup.Controls.Add(this.lbSearch2);
            this.tpGroup.Controls.Add(this.tbGroupSearch);
            this.tpGroup.Controls.Add(this.button3);
            this.tpGroup.Controls.Add(this.button4);
            this.tpGroup.Controls.Add(this.dGVGroup);
            this.tpGroup.Location = new System.Drawing.Point(4, 22);
            this.tpGroup.Margin = new System.Windows.Forms.Padding(2);
            this.tpGroup.Name = "tpGroup";
            this.tpGroup.Padding = new System.Windows.Forms.Padding(2);
            this.tpGroup.Size = new System.Drawing.Size(642, 336);
            this.tpGroup.TabIndex = 2;
            this.tpGroup.Text = "Группы";
            this.tpGroup.UseVisualStyleBackColor = true;
            // 
            // lbSearch2
            // 
            this.lbSearch2.AutoSize = true;
            this.lbSearch2.Location = new System.Drawing.Point(145, 310);
            this.lbSearch2.Name = "lbSearch2";
            this.lbSearch2.Size = new System.Drawing.Size(104, 13);
            this.lbSearch2.TabIndex = 13;
            this.lbSearch2.Text = "Поисковая строка:";
            // 
            // tbGroupSearch
            // 
            this.tbGroupSearch.Location = new System.Drawing.Point(248, 308);
            this.tbGroupSearch.Name = "tbGroupSearch";
            this.tbGroupSearch.Size = new System.Drawing.Size(258, 20);
            this.tbGroupSearch.TabIndex = 12;
            this.tbGroupSearch.TextChanged += new System.EventHandler(this.tbGroupSearch_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(5, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Добавить информацию";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(511, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Удалить информацию";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dGVGroup
            // 
            this.dGVGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVGroup.ColumnHeadersHeight = 29;
            this.dGVGroup.Location = new System.Drawing.Point(4, 4);
            this.dGVGroup.Margin = new System.Windows.Forms.Padding(2);
            this.dGVGroup.Name = "dGVGroup";
            this.dGVGroup.RowHeadersWidth = 51;
            this.dGVGroup.RowTemplate.Height = 24;
            this.dGVGroup.Size = new System.Drawing.Size(637, 298);
            this.dGVGroup.TabIndex = 2;
            // 
            // tpConsult
            // 
            this.tpConsult.Controls.Add(this.lbSearch4);
            this.tpConsult.Controls.Add(this.tbConsult);
            this.tpConsult.Controls.Add(this.button5);
            this.tpConsult.Controls.Add(this.button6);
            this.tpConsult.Controls.Add(this.dGVConsult);
            this.tpConsult.Location = new System.Drawing.Point(4, 22);
            this.tpConsult.Margin = new System.Windows.Forms.Padding(2);
            this.tpConsult.Name = "tpConsult";
            this.tpConsult.Padding = new System.Windows.Forms.Padding(2);
            this.tpConsult.Size = new System.Drawing.Size(642, 336);
            this.tpConsult.TabIndex = 3;
            this.tpConsult.Text = "Консультанты";
            this.tpConsult.UseVisualStyleBackColor = true;
            // 
            // lbSearch4
            // 
            this.lbSearch4.AutoSize = true;
            this.lbSearch4.Location = new System.Drawing.Point(142, 310);
            this.lbSearch4.Name = "lbSearch4";
            this.lbSearch4.Size = new System.Drawing.Size(104, 13);
            this.lbSearch4.TabIndex = 13;
            this.lbSearch4.Text = "Поисковая строка:";
            // 
            // tbConsult
            // 
            this.tbConsult.Location = new System.Drawing.Point(245, 308);
            this.tbConsult.Name = "tbConsult";
            this.tbConsult.Size = new System.Drawing.Size(258, 20);
            this.tbConsult.TabIndex = 12;
            this.tbConsult.TextChanged += new System.EventHandler(this.tbConsult_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 306);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Добавить информацию";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(508, 306);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Удалить информацию";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dGVConsult
            // 
            this.dGVConsult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVConsult.ColumnHeadersHeight = 29;
            this.dGVConsult.Location = new System.Drawing.Point(4, 4);
            this.dGVConsult.Margin = new System.Windows.Forms.Padding(2);
            this.dGVConsult.Name = "dGVConsult";
            this.dGVConsult.RowHeadersWidth = 51;
            this.dGVConsult.RowTemplate.Height = 24;
            this.dGVConsult.Size = new System.Drawing.Size(637, 298);
            this.dGVConsult.TabIndex = 2;
            // 
            // tpSpecialization
            // 
            this.tpSpecialization.Controls.Add(this.lbSearch5);
            this.tpSpecialization.Controls.Add(this.tbSpecSearch);
            this.tpSpecialization.Controls.Add(this.button7);
            this.tpSpecialization.Controls.Add(this.button8);
            this.tpSpecialization.Controls.Add(this.dGVSpecialization);
            this.tpSpecialization.Location = new System.Drawing.Point(4, 22);
            this.tpSpecialization.Margin = new System.Windows.Forms.Padding(2);
            this.tpSpecialization.Name = "tpSpecialization";
            this.tpSpecialization.Padding = new System.Windows.Forms.Padding(2);
            this.tpSpecialization.Size = new System.Drawing.Size(642, 336);
            this.tpSpecialization.TabIndex = 4;
            this.tpSpecialization.Text = "Специализации";
            this.tpSpecialization.UseVisualStyleBackColor = true;
            // 
            // lbSearch5
            // 
            this.lbSearch5.AutoSize = true;
            this.lbSearch5.Location = new System.Drawing.Point(146, 310);
            this.lbSearch5.Name = "lbSearch5";
            this.lbSearch5.Size = new System.Drawing.Size(104, 13);
            this.lbSearch5.TabIndex = 13;
            this.lbSearch5.Text = "Поисковая строка:";
            // 
            // tbSpecSearch
            // 
            this.tbSpecSearch.Location = new System.Drawing.Point(248, 308);
            this.tbSpecSearch.Name = "tbSpecSearch";
            this.tbSpecSearch.Size = new System.Drawing.Size(258, 20);
            this.tbSpecSearch.TabIndex = 12;
            this.tbSpecSearch.TextChanged += new System.EventHandler(this.tbSpecSearch_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 306);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(128, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "Добавить информацию";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(512, 306);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(128, 23);
            this.button8.TabIndex = 11;
            this.button8.Text = "Удалить информацию";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dGVSpecialization
            // 
            this.dGVSpecialization.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSpecialization.ColumnHeadersHeight = 29;
            this.dGVSpecialization.Location = new System.Drawing.Point(4, 4);
            this.dGVSpecialization.Margin = new System.Windows.Forms.Padding(2);
            this.dGVSpecialization.Name = "dGVSpecialization";
            this.dGVSpecialization.RowHeadersWidth = 51;
            this.dGVSpecialization.RowTemplate.Height = 24;
            this.dGVSpecialization.Size = new System.Drawing.Size(637, 298);
            this.dGVSpecialization.TabIndex = 2;
            // 
            // tpTitles
            // 
            this.tpTitles.Controls.Add(this.lbSearch6);
            this.tpTitles.Controls.Add(this.tbVrkTitleSearch);
            this.tpTitles.Controls.Add(this.button9);
            this.tpTitles.Controls.Add(this.button10);
            this.tpTitles.Controls.Add(this.dGVVkr_Titles);
            this.tpTitles.Location = new System.Drawing.Point(4, 22);
            this.tpTitles.Margin = new System.Windows.Forms.Padding(2);
            this.tpTitles.Name = "tpTitles";
            this.tpTitles.Padding = new System.Windows.Forms.Padding(2);
            this.tpTitles.Size = new System.Drawing.Size(642, 336);
            this.tpTitles.TabIndex = 5;
            this.tpTitles.Text = "ВКР_Темы";
            this.tpTitles.UseVisualStyleBackColor = true;
            // 
            // lbSearch6
            // 
            this.lbSearch6.AutoSize = true;
            this.lbSearch6.Location = new System.Drawing.Point(145, 310);
            this.lbSearch6.Name = "lbSearch6";
            this.lbSearch6.Size = new System.Drawing.Size(104, 13);
            this.lbSearch6.TabIndex = 13;
            this.lbSearch6.Text = "Поисковая строка:";
            // 
            // tbVrkTitleSearch
            // 
            this.tbVrkTitleSearch.Location = new System.Drawing.Point(248, 308);
            this.tbVrkTitleSearch.Name = "tbVrkTitleSearch";
            this.tbVrkTitleSearch.Size = new System.Drawing.Size(258, 20);
            this.tbVrkTitleSearch.TabIndex = 12;
            this.tbVrkTitleSearch.TextChanged += new System.EventHandler(this.tbVrkTitleSearch_TextChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(5, 306);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(128, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "Добавить информацию";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(511, 306);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(128, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "Удалить информацию";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // dGVVkr_Titles
            // 
            this.dGVVkr_Titles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVVkr_Titles.ColumnHeadersHeight = 29;
            this.dGVVkr_Titles.Location = new System.Drawing.Point(4, 4);
            this.dGVVkr_Titles.Margin = new System.Windows.Forms.Padding(2);
            this.dGVVkr_Titles.Name = "dGVVkr_Titles";
            this.dGVVkr_Titles.RowHeadersWidth = 51;
            this.dGVVkr_Titles.RowTemplate.Height = 24;
            this.dGVVkr_Titles.Size = new System.Drawing.Size(637, 298);
            this.dGVVkr_Titles.TabIndex = 2;
            // 
            // tpFinalyVKR
            // 
            this.tpFinalyVKR.Controls.Add(this.lbSearch7);
            this.tpFinalyVKR.Controls.Add(this.tbJobVKRSearch);
            this.tpFinalyVKR.Controls.Add(this.button11);
            this.tpFinalyVKR.Controls.Add(this.button12);
            this.tpFinalyVKR.Controls.Add(this.dGV_VKR_JOBS);
            this.tpFinalyVKR.Location = new System.Drawing.Point(4, 22);
            this.tpFinalyVKR.Margin = new System.Windows.Forms.Padding(2);
            this.tpFinalyVKR.Name = "tpFinalyVKR";
            this.tpFinalyVKR.Padding = new System.Windows.Forms.Padding(2);
            this.tpFinalyVKR.Size = new System.Drawing.Size(642, 336);
            this.tpFinalyVKR.TabIndex = 6;
            this.tpFinalyVKR.Text = "Работы ВКР";
            this.tpFinalyVKR.UseVisualStyleBackColor = true;
            this.tpFinalyVKR.Click += new System.EventHandler(this.tpFinalyVKR_Click);
            // 
            // lbSearch7
            // 
            this.lbSearch7.AutoSize = true;
            this.lbSearch7.Location = new System.Drawing.Point(146, 310);
            this.lbSearch7.Name = "lbSearch7";
            this.lbSearch7.Size = new System.Drawing.Size(104, 13);
            this.lbSearch7.TabIndex = 13;
            this.lbSearch7.Text = "Поисковая строка:";
            // 
            // tbJobVKRSearch
            // 
            this.tbJobVKRSearch.Location = new System.Drawing.Point(249, 308);
            this.tbJobVKRSearch.Name = "tbJobVKRSearch";
            this.tbJobVKRSearch.Size = new System.Drawing.Size(258, 20);
            this.tbJobVKRSearch.TabIndex = 12;
            this.tbJobVKRSearch.TextChanged += new System.EventHandler(this.tbJobVKRSearch_TextChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 306);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(128, 23);
            this.button11.TabIndex = 10;
            this.button11.Text = "Добавить информацию";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(512, 306);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(128, 23);
            this.button12.TabIndex = 11;
            this.button12.Text = "Удалить информацию";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // dGV_VKR_JOBS
            // 
            this.dGV_VKR_JOBS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_VKR_JOBS.ColumnHeadersHeight = 29;
            this.dGV_VKR_JOBS.Location = new System.Drawing.Point(4, 4);
            this.dGV_VKR_JOBS.Margin = new System.Windows.Forms.Padding(2);
            this.dGV_VKR_JOBS.Name = "dGV_VKR_JOBS";
            this.dGV_VKR_JOBS.RowHeadersWidth = 51;
            this.dGV_VKR_JOBS.RowTemplate.Height = 24;
            this.dGV_VKR_JOBS.Size = new System.Drawing.Size(624, 298);
            this.dGV_VKR_JOBS.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FullMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 391);
            this.Controls.Add(this.tbCosnusltSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FullMainWindow";
            this.Load += new System.EventHandler(this.FullMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVMainWindow)).EndInit();
            this.tbCosnusltSearch.ResumeLayout(false);
            this.tpStudent.ResumeLayout(false);
            this.tpStudent.PerformLayout();
            this.tpTeacher.ResumeLayout(false);
            this.tpTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTeacher)).EndInit();
            this.tpGroup.ResumeLayout(false);
            this.tpGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGroup)).EndInit();
            this.tpConsult.ResumeLayout(false);
            this.tpConsult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVConsult)).EndInit();
            this.tpSpecialization.ResumeLayout(false);
            this.tpSpecialization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSpecialization)).EndInit();
            this.tpTitles.ResumeLayout(false);
            this.tpTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVkr_Titles)).EndInit();
            this.tpFinalyVKR.ResumeLayout(false);
            this.tpFinalyVKR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_VKR_JOBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVMainWindow;
        private System.Windows.Forms.TabControl tbCosnusltSearch;
        private System.Windows.Forms.TabPage tpStudent;
        private System.Windows.Forms.TabPage tpTeacher;
        private System.Windows.Forms.DataGridView dGVTeacher;
        private System.Windows.Forms.TabPage tpGroup;
        private System.Windows.Forms.DataGridView dGVGroup;
        private System.Windows.Forms.TabPage tpConsult;
        private System.Windows.Forms.DataGridView dGVConsult;
        private System.Windows.Forms.TabPage tpSpecialization;
        private System.Windows.Forms.DataGridView dGVSpecialization;
        private System.Windows.Forms.TabPage tpTitles;
        private System.Windows.Forms.DataGridView dGVVkr_Titles;
        private System.Windows.Forms.TabPage tpFinalyVKR;
        private System.Windows.Forms.DataGridView dGV_VKR_JOBS;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearchStudent;
        private System.Windows.Forms.Button btAddStudent;
        private System.Windows.Forms.Button btDeleteInfo;
        private System.Windows.Forms.Label lbSearch1;
        private System.Windows.Forms.TextBox tbTeacherSearch;
        private System.Windows.Forms.Button btAddTeacher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbSearch2;
        private System.Windows.Forms.TextBox tbGroupSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbSearch4;
        private System.Windows.Forms.TextBox tbConsult;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lbSearch5;
        private System.Windows.Forms.TextBox tbSpecSearch;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lbSearch6;
        private System.Windows.Forms.TextBox tbVrkTitleSearch;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lbSearch7;
        private System.Windows.Forms.TextBox tbJobVKRSearch;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button1;
    }
}