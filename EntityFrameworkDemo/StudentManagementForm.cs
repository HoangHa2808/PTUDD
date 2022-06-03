using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EntityFrameworkDemo
{
	public partial class StudentManagementForm : Form
	{
		private List<Student> students;
		private List<Class> classes;
		string connectionString = ConfigurationManager.ConnectionStrings["StudentManagement"].ConnectionString;
		public StudentManagementForm()
		{
			InitializeComponent();
		}

		#region Hàm
		public void GetAllStudent()
		{
			students = new List<Student>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT SinhVien.ID, HoTen, TenLop FROM SinhVien , Lop WHERE MaLop = Lop.ID";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();

			sqlConnection.Open();
			sqlDataAdapter.Fill(dataTable);
			sqlConnection.Close();
			foreach (DataRow row in dataTable.Rows)
			{
				Student student = new Student(row);
				students.Add(student);
			}
		}

		public void GetAllClass()
		{
			classes = new List<Class>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "SELECT * FROM Lop";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable Table = new DataTable();

			sqlConnection.Open();
			sqlDataAdapter.Fill(Table);
			sqlConnection.Close();
			foreach (DataRow row in Table.Rows)
			{
				Class @class = new Class(row);
				classes.Add(@class);
			}
		}

		public Student GetStudent()
		{
			Student student = new Student();
			student.Class = cbbClass.Text;
			student.Name = txtFullName.Text;
			return student;
		}

		public void AddStudent(Student student)
		{
			ListViewItem item = new ListViewItem(student.Id.ToString());
			item.SubItems.Add(student.Name);
			item.SubItems.Add(student.Class);
			lvStudentList.Items.Add(item);
		}

		public int SearchClassID(string className)
		{
			int result = 0;
			foreach (Class c in classes)
			{
				if (c.ClassName.CompareTo(className) == 0)
				{
					result = c.Id;
				}
			}
			return result;
		}

		public void AddStudentToDatabase(Student student)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "INSERT INTO SinhVien VALUES (N'" + student.Name + "', " + SearchClassID(student.Class) + ")";

			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
		}

		private void ExitStudent(int studentID, Student newStudent)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = "UPDATE SinhVien" + "SET HoTen = N'" + this.txtFullName.Text + "', MaLop =  " + SearchClassID(this.cbbClass.Text) + " WHERE ID =" + this.txtID.Text;

			sqlConnection.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();

		}

		public void LoadClass()
		{
			foreach (Class @class in classes)
			{
				cbbClass.Items.Add(@class.ClassName);
			}
		}

		public void LoadListView(List<Student> students)
		{
			lvStudentList.Items.Clear();
			foreach (Student student in students)
			{
				AddStudent(student);
			}
		}


		#endregion


		#region Các sự kiện
		private void StudentManagementForm_Load(object sender, EventArgs e)
		{
			GetAllClass();
			LoadClass();
			GetAllStudent();
			LoadListView(students);
			this.txtSearch.Text = "Nhập tên sinh viên";
		}
		private void btnDefault_Click(object sender, EventArgs e)
		{
			this.txtID.Text = "";
			this.txtFullName.Text = "";
			this.txtSearch.Text = "";
		}

		// Tải lại danh sách sinh viên
		private void btnReload_Click(object sender, EventArgs e)
		{
			GetAllStudent();
			LoadListView(students);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			Student student = GetStudent();
			if (student == null)
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
			}
			else
			{
				AddStudentToDatabase(student);
				btnReload.PerformClick();
			}
		}


		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
	
		}
		private void txtSearch_Enter(object sender, EventArgs e)
		{
			this.txtSearch.Text = "";
		}

		private void txtSearch_Leave(object sender, EventArgs e)
		{
			this.txtSearch.Text = "Nhập tên sinh viên";
		}
		#endregion

	}
}
