namespace EntityFrameworkDemo
{
	partial class StudentManagementForm
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
			this.btnDefault = new System.Windows.Forms.Button();
			this.lbClass = new System.Windows.Forms.Label();
			this.lbID = new System.Windows.Forms.Label();
			this.lbFullName = new System.Windows.Forms.Label();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbbClass = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.gbStudentList = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lvStudentList = new System.Windows.Forms.ListView();
			this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.gbStudentList.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnDefault
			// 
			this.btnDefault.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDefault.Location = new System.Drawing.Point(215, 192);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(75, 23);
			this.btnDefault.TabIndex = 0;
			this.btnDefault.Text = "Mặc định";
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// lbClass
			// 
			this.lbClass.AutoSize = true;
			this.lbClass.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbClass.Location = new System.Drawing.Point(87, 49);
			this.lbClass.Name = "lbClass";
			this.lbClass.Size = new System.Drawing.Size(42, 18);
			this.lbClass.TabIndex = 1;
			this.lbClass.Text = "Lớp :";
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbID.Location = new System.Drawing.Point(87, 97);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(32, 18);
			this.lbID.TabIndex = 1;
			this.lbID.Text = "ID :";
			// 
			// lbFullName
			// 
			this.lbFullName.AutoSize = true;
			this.lbFullName.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.lbFullName.Location = new System.Drawing.Point(87, 146);
			this.lbFullName.Name = "lbFullName";
			this.lbFullName.Size = new System.Drawing.Size(83, 18);
			this.lbFullName.TabIndex = 1;
			this.lbFullName.Text = "Họ tên SV :";
			// 
			// btnReload
			// 
			this.btnReload.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReload.Location = new System.Drawing.Point(317, 192);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 23);
			this.btnReload.TabIndex = 0;
			this.btnReload.Text = "Tải lại";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnSave
			// 
			this.btnSave.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.Location = new System.Drawing.Point(421, 192);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbbClass
			// 
			this.cbbClass.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbbClass.FormattingEnabled = true;
			this.cbbClass.Items.AddRange(new object[] {
            "CTK42",
            "CTK43",
            "CTK44",
            "CTK45"});
			this.cbbClass.Location = new System.Drawing.Point(215, 45);
			this.cbbClass.Name = "cbbClass";
			this.cbbClass.Size = new System.Drawing.Size(281, 23);
			this.cbbClass.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.gbStudentList);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(20, 257);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 392);
			this.panel1.TabIndex = 3;
			// 
			// gbStudentList
			// 
			this.gbStudentList.Controls.Add(this.txtSearch);
			this.gbStudentList.Controls.Add(this.lvStudentList);
			this.gbStudentList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbStudentList.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbStudentList.Location = new System.Drawing.Point(0, 0);
			this.gbStudentList.Margin = new System.Windows.Forms.Padding(0);
			this.gbStudentList.Name = "gbStudentList";
			this.gbStudentList.Padding = new System.Windows.Forms.Padding(8);
			this.gbStudentList.Size = new System.Drawing.Size(544, 392);
			this.gbStudentList.TabIndex = 0;
			this.gbStudentList.TabStop = false;
			this.gbStudentList.Text = "Danh sách sinh viên";
			// 
			// txtSearch
			// 
			this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
			this.txtSearch.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(360, 27);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(176, 23);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
			this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
			// 
			// lvStudentList
			// 
			this.lvStudentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FullName,
            this.Class});
			this.lvStudentList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lvStudentList.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvStudentList.GridLines = true;
			this.lvStudentList.HideSelection = false;
			this.lvStudentList.Location = new System.Drawing.Point(8, 67);
			this.lvStudentList.Name = "lvStudentList";
			this.lvStudentList.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lvStudentList.Size = new System.Drawing.Size(528, 317);
			this.lvStudentList.TabIndex = 0;
			this.lvStudentList.UseCompatibleStateImageBehavior = false;
			this.lvStudentList.View = System.Windows.Forms.View.Details;
			// 
			// ID
			// 
			this.ID.Text = "MSSV";
			this.ID.Width = 100;
			// 
			// FullName
			// 
			this.FullName.Text = "Họ tên";
			this.FullName.Width = 200;
			// 
			// Class
			// 
			this.Class.Text = "Lớp";
			this.Class.Width = 90;
			// 
			// txtFullName
			// 
			this.txtFullName.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtFullName.Location = new System.Drawing.Point(215, 142);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(281, 23);
			this.txtFullName.TabIndex = 4;
			// 
			// txtID
			// 
			this.txtID.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.txtID.Location = new System.Drawing.Point(215, 93);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(281, 23);
			this.txtID.TabIndex = 4;
			// 
			// StudentManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 661);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.cbbClass);
			this.Controls.Add(this.lbFullName);
			this.Controls.Add(this.lbID);
			this.Controls.Add(this.lbClass);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.btnDefault);
			this.Name = "StudentManagementForm";
			this.Padding = new System.Windows.Forms.Padding(20, 8, 20, 12);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý sinh viên";
			this.Load += new System.EventHandler(this.StudentManagementForm_Load);
			this.panel1.ResumeLayout(false);
			this.gbStudentList.ResumeLayout(false);
			this.gbStudentList.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDefault;
		private System.Windows.Forms.Label lbClass;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.Label lbFullName;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbbClass;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbStudentList;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ListView lvStudentList;
		private System.Windows.Forms.ColumnHeader ID;
		private System.Windows.Forms.ColumnHeader FullName;
		private System.Windows.Forms.ColumnHeader Class;
		private System.Windows.Forms.TextBox txtFullName;
		private System.Windows.Forms.TextBox txtID;
	}
}

