using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
	public class Student
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Class { get; set; }

		public Student()
		{

		}

		public Student(DataRow dtRow)
		{
			Id = Convert.ToInt32(dtRow["ID"]);
			Name = dtRow["HoTen"].ToString();
			Class = dtRow["TenLop"].ToString();
		} 
	}
}
