using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace namba.Interfaces
{
	public interface IHelper
	{
		 string getPayload();
         int callSystem(string args);
		 string getDrop();
		 string gbeba(string p,string ad);
	}
}