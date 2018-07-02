using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace UsingAPI.Models
{
	/// <summary>
	/// todo list class
	/// </summary>
	public class ToDoList
	{

		public int ID { get; set; }
		public string Name { get; set; }
		public List<ToDoItem> ItemList { get; set; }

	}
}


