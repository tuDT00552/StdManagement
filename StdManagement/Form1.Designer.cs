namespace StdManagement
{
    partial class Form1
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
            this.tableStudent = new System.Windows.Forms.DataGridView();
            this.titleLop = new System.Windows.Forms.Label();
            this.className = new System.Windows.Forms.Label();
            this.classAddress = new System.Windows.Forms.Label();
            this.tenlopTxt = new System.Windows.Forms.TextBox();
            this.diachiTxt = new System.Windows.Forms.TextBox();
            this.classAdd = new System.Windows.Forms.Button();
            this.classEdit = new System.Windows.Forms.Button();
            this.classDelete = new System.Windows.Forms.Button();
            this.tableClass = new System.Windows.Forms.DataGridView();
            this.titleStudent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.masvTxt = new System.Windows.Forms.TextBox();
            this.tensvTxt = new System.Windows.Forms.TextBox();
            this.tuoiTxt = new System.Windows.Forms.TextBox();
            this.diachisvTxt = new System.Windows.Forms.TextBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.studentSearch = new System.Windows.Forms.Button();
            this.studentAdd = new System.Windows.Forms.Button();
            this.studentEdit = new System.Windows.Forms.Button();
            this.studentDelete = new System.Windows.Forms.Button();
            this.viewAllStudent = new System.Windows.Forms.Button();
            this.reloadStd = new System.Windows.Forms.Button();
            this.reloadCls = new System.Windows.Forms.Button();
            this.tenlopsvTxt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tableStudent
            // 
            this.tableStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableStudent.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStudent.Location = new System.Drawing.Point(217, 207);
            this.tableStudent.Name = "tableStudent";
            this.tableStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableStudent.Size = new System.Drawing.Size(571, 231);
            this.tableStudent.TabIndex = 1;
            this.tableStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getInfoStudent);
            this.tableStudent.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.deleteStudent);
            // 
            // titleLop
            // 
            this.titleLop.AutoSize = true;
            this.titleLop.BackColor = System.Drawing.SystemColors.Highlight;
            this.titleLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLop.Location = new System.Drawing.Point(55, 24);
            this.titleLop.Name = "titleLop";
            this.titleLop.Size = new System.Drawing.Size(90, 13);
            this.titleLop.TabIndex = 2;
            this.titleLop.Text = "Quản Lí Lớp Học";
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Location = new System.Drawing.Point(14, 62);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(50, 13);
            this.className.TabIndex = 3;
            this.className.Text = "Tên Lớp:";
            // 
            // classAddress
            // 
            this.classAddress.AutoSize = true;
            this.classAddress.Location = new System.Drawing.Point(14, 96);
            this.classAddress.Name = "classAddress";
            this.classAddress.Size = new System.Drawing.Size(44, 13);
            this.classAddress.TabIndex = 4;
            this.classAddress.Text = "Địa Chỉ:";
            // 
            // tenlopTxt
            // 
            this.tenlopTxt.Location = new System.Drawing.Point(65, 59);
            this.tenlopTxt.Name = "tenlopTxt";
            this.tenlopTxt.Size = new System.Drawing.Size(134, 20);
            this.tenlopTxt.TabIndex = 5;
            // 
            // diachiTxt
            // 
            this.diachiTxt.Location = new System.Drawing.Point(65, 96);
            this.diachiTxt.Name = "diachiTxt";
            this.diachiTxt.Size = new System.Drawing.Size(134, 20);
            this.diachiTxt.TabIndex = 6;
            // 
            // classAdd
            // 
            this.classAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classAdd.Location = new System.Drawing.Point(17, 141);
            this.classAdd.Name = "classAdd";
            this.classAdd.Size = new System.Drawing.Size(55, 23);
            this.classAdd.TabIndex = 7;
            this.classAdd.Text = "Thêm";
            this.classAdd.UseVisualStyleBackColor = false;
            this.classAdd.Click += new System.EventHandler(this.classAdd_Click);
            // 
            // classEdit
            // 
            this.classEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classEdit.Location = new System.Drawing.Point(78, 141);
            this.classEdit.Name = "classEdit";
            this.classEdit.Size = new System.Drawing.Size(58, 23);
            this.classEdit.TabIndex = 8;
            this.classEdit.Text = "Sửa";
            this.classEdit.UseVisualStyleBackColor = false;
            this.classEdit.Click += new System.EventHandler(this.classEdit_Click);
            // 
            // classDelete
            // 
            this.classDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classDelete.Location = new System.Drawing.Point(142, 141);
            this.classDelete.Name = "classDelete";
            this.classDelete.Size = new System.Drawing.Size(57, 23);
            this.classDelete.TabIndex = 9;
            this.classDelete.Text = "Xoá";
            this.classDelete.UseVisualStyleBackColor = false;
            this.classDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableClass
            // 
            this.tableClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableClass.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableClass.Location = new System.Drawing.Point(217, 12);
            this.tableClass.Name = "tableClass";
            this.tableClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableClass.Size = new System.Drawing.Size(490, 159);
            this.tableClass.TabIndex = 10;
            this.tableClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getInfoClass);
            this.tableClass.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.deleteClass);
            // 
            // titleStudent
            // 
            this.titleStudent.AutoSize = true;
            this.titleStudent.BackColor = System.Drawing.SystemColors.Highlight;
            this.titleStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleStudent.Location = new System.Drawing.Point(53, 186);
            this.titleStudent.Name = "titleStudent";
            this.titleStudent.Size = new System.Drawing.Size(94, 13);
            this.titleStudent.TabIndex = 11;
            this.titleStudent.Text = "Quản Lí Sinh Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "MãSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "TênSV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tuổi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Địa Chỉ:";
            // 
            // masvTxt
            // 
            this.masvTxt.Location = new System.Drawing.Point(65, 219);
            this.masvTxt.Name = "masvTxt";
            this.masvTxt.Size = new System.Drawing.Size(134, 20);
            this.masvTxt.TabIndex = 17;
            // 
            // tensvTxt
            // 
            this.tensvTxt.Location = new System.Drawing.Point(65, 258);
            this.tensvTxt.Name = "tensvTxt";
            this.tensvTxt.Size = new System.Drawing.Size(134, 20);
            this.tensvTxt.TabIndex = 18;
            // 
            // tuoiTxt
            // 
            this.tuoiTxt.Location = new System.Drawing.Point(65, 329);
            this.tuoiTxt.Name = "tuoiTxt";
            this.tuoiTxt.Size = new System.Drawing.Size(134, 20);
            this.tuoiTxt.TabIndex = 20;
            // 
            // diachisvTxt
            // 
            this.diachisvTxt.Location = new System.Drawing.Point(65, 368);
            this.diachisvTxt.Name = "diachisvTxt";
            this.diachisvTxt.Size = new System.Drawing.Size(134, 20);
            this.diachisvTxt.TabIndex = 21;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(217, 179);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(409, 20);
            this.searchTxt.TabIndex = 24;
            // 
            // studentSearch
            // 
            this.studentSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.studentSearch.Location = new System.Drawing.Point(632, 177);
            this.studentSearch.Name = "studentSearch";
            this.studentSearch.Size = new System.Drawing.Size(75, 23);
            this.studentSearch.TabIndex = 25;
            this.studentSearch.Text = "Tìm Kiếm";
            this.studentSearch.UseVisualStyleBackColor = false;
            this.studentSearch.Click += new System.EventHandler(this.studentSearch_Click);
            // 
            // studentAdd
            // 
            this.studentAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentAdd.Location = new System.Drawing.Point(15, 409);
            this.studentAdd.Name = "studentAdd";
            this.studentAdd.Size = new System.Drawing.Size(57, 23);
            this.studentAdd.TabIndex = 26;
            this.studentAdd.Text = "Thêm";
            this.studentAdd.UseVisualStyleBackColor = false;
            this.studentAdd.Click += new System.EventHandler(this.studentAdd_Click);
            // 
            // studentEdit
            // 
            this.studentEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentEdit.Location = new System.Drawing.Point(78, 409);
            this.studentEdit.Name = "studentEdit";
            this.studentEdit.Size = new System.Drawing.Size(58, 23);
            this.studentEdit.TabIndex = 27;
            this.studentEdit.Text = "Sửa";
            this.studentEdit.UseVisualStyleBackColor = false;
            this.studentEdit.Click += new System.EventHandler(this.studentEdit_Click);
            // 
            // studentDelete
            // 
            this.studentDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.studentDelete.Location = new System.Drawing.Point(142, 409);
            this.studentDelete.Name = "studentDelete";
            this.studentDelete.Size = new System.Drawing.Size(57, 23);
            this.studentDelete.TabIndex = 28;
            this.studentDelete.Text = "Xoá";
            this.studentDelete.UseVisualStyleBackColor = false;
            this.studentDelete.Click += new System.EventHandler(this.studentDelete_Click);
            // 
            // viewAllStudent
            // 
            this.viewAllStudent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.viewAllStudent.Location = new System.Drawing.Point(713, 38);
            this.viewAllStudent.Name = "viewAllStudent";
            this.viewAllStudent.Size = new System.Drawing.Size(75, 133);
            this.viewAllStudent.TabIndex = 29;
            this.viewAllStudent.Text = "Xem Thông Tin Học Viên";
            this.viewAllStudent.UseVisualStyleBackColor = false;
            this.viewAllStudent.Click += new System.EventHandler(this.viewAllStudent_Click);
            // 
            // reloadStd
            // 
            this.reloadStd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reloadStd.Location = new System.Drawing.Point(713, 177);
            this.reloadStd.Name = "reloadStd";
            this.reloadStd.Size = new System.Drawing.Size(75, 23);
            this.reloadStd.TabIndex = 30;
            this.reloadStd.Text = "Reload";
            this.reloadStd.UseVisualStyleBackColor = false;
            this.reloadStd.Click += new System.EventHandler(this.reloadStd_Click);
            // 
            // reloadCls
            // 
            this.reloadCls.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reloadCls.Location = new System.Drawing.Point(713, 12);
            this.reloadCls.Name = "reloadCls";
            this.reloadCls.Size = new System.Drawing.Size(75, 23);
            this.reloadCls.TabIndex = 31;
            this.reloadCls.Text = "Reload";
            this.reloadCls.UseVisualStyleBackColor = false;
            this.reloadCls.Click += new System.EventHandler(this.reloadCls_Click);
            // 
            // tenlopsvTxt
            // 
            this.tenlopsvTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenlopsvTxt.FormattingEnabled = true;
            this.tenlopsvTxt.Location = new System.Drawing.Point(65, 293);
            this.tenlopsvTxt.Name = "tenlopsvTxt";
            this.tenlopsvTxt.Size = new System.Drawing.Size(134, 21);
            this.tenlopsvTxt.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tenlopsvTxt);
            this.Controls.Add(this.reloadCls);
            this.Controls.Add(this.reloadStd);
            this.Controls.Add(this.viewAllStudent);
            this.Controls.Add(this.studentDelete);
            this.Controls.Add(this.studentEdit);
            this.Controls.Add(this.studentAdd);
            this.Controls.Add(this.studentSearch);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.diachisvTxt);
            this.Controls.Add(this.tuoiTxt);
            this.Controls.Add(this.tensvTxt);
            this.Controls.Add(this.masvTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleStudent);
            this.Controls.Add(this.tableClass);
            this.Controls.Add(this.classDelete);
            this.Controls.Add(this.classEdit);
            this.Controls.Add(this.classAdd);
            this.Controls.Add(this.diachiTxt);
            this.Controls.Add(this.tenlopTxt);
            this.Controls.Add(this.classAddress);
            this.Controls.Add(this.className);
            this.Controls.Add(this.titleLop);
            this.Controls.Add(this.tableStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tableStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableStudent;
        private System.Windows.Forms.Label titleLop;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.Label classAddress;
        private System.Windows.Forms.TextBox tenlopTxt;
        private System.Windows.Forms.TextBox diachiTxt;
        private System.Windows.Forms.Button classAdd;
        private System.Windows.Forms.Button classEdit;
        private System.Windows.Forms.Button classDelete;
        private System.Windows.Forms.DataGridView tableClass;
        private System.Windows.Forms.Label titleStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox masvTxt;
        private System.Windows.Forms.TextBox tensvTxt;
        private System.Windows.Forms.TextBox tuoiTxt;
        private System.Windows.Forms.TextBox diachisvTxt;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button studentSearch;
        private System.Windows.Forms.Button studentAdd;
        private System.Windows.Forms.Button studentEdit;
        private System.Windows.Forms.Button studentDelete;
        private System.Windows.Forms.Button viewAllStudent;
        private System.Windows.Forms.Button reloadStd;
        private System.Windows.Forms.Button reloadCls;
        private System.Windows.Forms.ComboBox tenlopsvTxt;
    }
}

