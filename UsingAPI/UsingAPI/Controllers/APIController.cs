using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using UsingAPI.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace UsingAPI.Controllers
{
    public class APIController: Controller
    {

		/// <summary>
		/// default index view
		/// </summary>
		/// <returns>view</returns>
		public async Task<IActionResult>Index()
		{
	
			return View();	
		}

		/// <summary>
		/// method to get all lists
		/// </summary>
		/// <returns>result from api call in a string</returns>
		public async Task<string> GetAllLists()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://todoapi20180628081232.azurewebsites.net");

				var response = client.GetAsync("api/todolist").Result;

				if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
				{
					
					var stringResult = await response.Content.ReadAsStringAsync();
					
					//ListObject mainObject = JsonConvert.DeserializeObject<ListObject>(stringResult);

					return stringResult;
				}
			}

			return "";
		}

		/// <summary>
		/// method to get one todo list
		/// </summary>
		/// <returns>api call list by id number</returns>
		public async Task<string> GetOneList()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://todoapi20180628081232.azurewebsites.net");

				var response = client.GetAsync("api/todolist/2").Result;

				if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
				{

					var stringResult = await response.Content.ReadAsStringAsync();

					return stringResult;
				}
			}

			return "";
		}

		/// <summary>
		/// method to get all items
		/// </summary>
		/// <returns>api call of all to do items</returns>
		public async Task<string> GetAllItems()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://todoapi20180628081232.azurewebsites.net");

				var response = client.GetAsync("api/todo").Result;

				if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
				{

					var stringResult = await response.Content.ReadAsStringAsync();

					return stringResult;
				}
			}

			return "";
		}

		/// <summary>
		/// method to get one item
		/// </summary>
		/// <returns>api call to return one list item</returns>
		public async Task<string> GetOneItem()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://todoapi20180628081232.azurewebsites.net");

				var response = client.GetAsync("api/todo/1").Result;

				if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
				{

					var stringResult = await response.Content.ReadAsStringAsync();

					return stringResult;
				}
			}

			return "";
		}
	}
}
