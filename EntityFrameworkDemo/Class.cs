using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
	public class Class
	{
		public int Id { get; set; }
		public string ClassName { get; set; }

		public Class(DataRow dtRow)
		{
			Id = Convert.ToInt32(dtRow["ID"]);
			ClassName = dtRow["TenLop"].ToString();
		}
	}
}
