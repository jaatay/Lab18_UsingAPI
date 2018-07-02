using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingAPI.Models
{
	public class ListObject
	{
		public NewList[] Property1 { get; set; }
	}

	public class NewList
	{
		public int id { get; set; }
		public string name { get; set; }
		public bool isComplete { get; set; }
		public int listID { get; set; }
		public object listName { get; set; }
	}
}
