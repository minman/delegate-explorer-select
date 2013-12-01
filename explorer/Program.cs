/*
 * User: mm
 * Date: 01.12.2013
 * Time: 12:13
 */
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace explorer {
	
	// Class with program entry point.
	internal sealed class Program {
		
		const string select = "/select,";
		const string root = "/root,";
		
		// Program entry point.
		[STAThread]
		private static void Main(string[] args) {
			// execute select path
			int index = Environment.CommandLine.IndexOf(select);
			if (index > 0) {
				Execute(Environment.CommandLine.Substring(index + select.Length));
			}
			// execute root path
			index = Environment.CommandLine.IndexOf(root);
			if (index > 0) {
				Execute(Environment.CommandLine.Substring(index + root.Length));
			}
			// ?
			MessageBox.Show(String.Format("Could not delegate '{0}'.", Environment.CommandLine), Application.ProductName);
			Environment.Exit(1);
		}
		
		private static void Execute(String path) {
			String fileName = ConfigurationManager.AppSettings["fileName"];
			String arguments = String.Format(ConfigurationManager.AppSettings["arguments"], path);
			Process.Start(fileName, arguments);
			Environment.Exit(0);
		}
		
	}
}
