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
		public async Task<IActionResult> Index()
		{
			string value = await APICall();

			ListObject mainObject = new ListObject();
			
			return View();
			
		}

		public async Task<string> APICall()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://todoapi20180628081232.azurewebsites.net");

				var response = client.GetAsync("api/todo").Result;

				if (response.EnsureSuccessStatusCode().IsSuccessStatusCode)
				{
					
					var stringResult = await response.Content.ReadAsStringAsync();
					
					//ListObject mainObject = JsonConvert.DeserializeObject<ListObject>(stringResult);

					
					
					return stringResult;
				}
			}

			return "";
		}
	}
}
