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
	/// todo item class
	/// </summary>
    public class ToDoItem
    {
		public int ID { get; set; }
		public string Name { get; set; }
		public bool IsComplete { get; set; }
		public int ListID { get; set; }
		public string ListName { get; set; }
	}
}
