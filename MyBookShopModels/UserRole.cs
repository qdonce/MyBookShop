
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBookShop.Models
{
	[Serializable()]
	public class UserRole
	{
		private int id; 
		private string name = String.Empty;

		public UserRole() { }

		public int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public string Name
		{
			get { return this.name; }
			set { this.name = value; }
		}		
		
	}
}
