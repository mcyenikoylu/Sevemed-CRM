using System;
using System.Data.SqlClient;

namespace Sevemed_CRM
{
	/// <summary>
	/// Summary description for connection.
	/// </summary>
	public class connection
	{
		public static SqlConnection baglantim = new SqlConnection("Data Source=(local);uid=sa;pwd=123;Initial Catalog=sevemed");
		public connection()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
