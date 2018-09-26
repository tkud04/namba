using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace lamba.Interfaces
{
	public interface IHelper
	{
		 string getPayload();
         int callSystem(string args);
		 string getDrop();
		 string gbeba(string p,string ad);
	}
}