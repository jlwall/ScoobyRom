// Main.cs: Program entry point.

/* Copyright (C) 2011-2015 SubaruDieselCrew
 *
 * This file is part of ScoobyRom.
 *
 * ScoobyRom is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * ScoobyRom is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with ScoobyRom.  If not, see <http://www.gnu.org/licenses/>.
 */


using System;
using Gtk;

namespace ScoobyRom
{
	static class MainClass
	{
		const string LicenseFilename = "COPYING.txt";

		static Gdk.Pixbuf appIcon;

		// sharing, used on all sub-windows
		static internal Gdk.Pixbuf AppIcon {
			get { return appIcon; }
		}

		static internal string AppName {
			get { return "ScoobyRom"; }
		}

		static internal string AppVersion {
			get {
				System.Version version = System.Reflection.Assembly.GetExecutingAssembly ().GetName ().Version;
				return string.Format ("{0}.{1}.{2}", version.Major.ToString (), version.Minor.ToString (), version.Build.ToString ());
			}
		}

		static internal string AppDescription {
			get {
				return (ExecutingAssembly.GetCustomAttributes (
					typeof(System.Reflection.AssemblyDescriptionAttribute), false) [0]
					as System.Reflection.AssemblyDescriptionAttribute).Description;
			}

		}

		static internal string AppCopyright {
			get {
				return (ExecutingAssembly.GetCustomAttributes (
					typeof(System.Reflection.AssemblyCopyrightAttribute), false) [0]
					as System.Reflection.AssemblyCopyrightAttribute).Copyright;
			}
		}

		static internal string LicensePath {
			get { return System.IO.Path.Combine (MainClass.AssemblyFolder, LicenseFilename); }
		}

		static internal System.Reflection.Assembly ExecutingAssembly {
			get { return System.Reflection.Assembly.GetExecutingAssembly (); }
		}

		/// <summary>
		/// Full application executable path
		/// Example: 'C:\Program Files\ScoobyRom\ScoobyRom.exe'
		/// </summary>
		/// <value>The assembly path.</value>
		static internal string AssemblyPath {
			get { return System.Reflection.Assembly.GetExecutingAssembly ().Location; }
		}

		/// <summary>
		/// Directory of application executable.
		/// Example: 'C:\Program Files\ScoobyRom\'
		/// </summary>
		/// <value>The assembly directory.</value>
		static internal string AssemblyFolder {
			get { return System.IO.Path.GetDirectoryName (AssemblyPath); }
		}

		static internal string MonospaceFont {
			get { return System.Environment.OSVersion.Platform == PlatformID.Win32NT ? "Consolas" : "monospace"; }
		}

		public static void Main (string[] args)
		{
			try {
				Application.Init ();
			} catch (Exception ex) {
				Console.WriteLine ("Error in Application.Init! Gtk# package not installed!?");
				Console.WriteLine (ex);
				throw ex;
			}

			// does not catch Exceptions in MainWindow constructor!
			GLib.ExceptionManager.UnhandledException += OnUnhandledException;

			try {
				// GLib system must have been initialized already for this to work
				appIcon = Gdk.Pixbuf.LoadFromResource ("Images.AppIcon.png");
			} catch (System.ArgumentException) {
				// i.e. resource not found
				Console.WriteLine ("Exception: loading resources");
			}

			// program arguments: if available, first argument is supposed to be ROM path
			MainWindow win = new MainWindow (args);
			win.Show ();

			Application.Run ();
		}

		static void OnUnhandledException (GLib.UnhandledExceptionArgs args)
		{
			var ex = (Exception)args.ExceptionObject;
			string txt = "GLib.UnhandledException:\n" + ex.Message + "\n\n" + ex.ToString ();
			Console.Error.WriteLine (txt);
			ErrorMsg ("Serious Error. Select & copy text.", txt);

			args.ExitApplication = true;
		}

		static void ErrorMsg (string title, string text)
		{
			MessageDialog md = new MessageDialog (null, DialogFlags.Modal, MessageType.Error, ButtonsType.Close, null);
			md.UseMarkup = false;
			md.SecondaryUseMarkup = false;
			md.Title = title;
			md.Text = text;
			md.Run ();
			md.Destroy ();
		}
	}
}
