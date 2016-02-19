using System;
using System.Linq;
using Gtk;
using MaterialIcons.UI;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using MonoDevelop.Ide;
using MonoDevelop.Projects;
using MonoDevelop.Core.ProgressMonitoring;

namespace MaterialIconsGenerator
{
	public partial class MainDialog : Gtk.Dialog
	{
		public MainDialog ()
		{
			this.Build ();

			this.LoadIcons ();
			this.LoadColors ();
			this.LoadSizes ();

			this.comboSize.Changed += this.OnComboSizeChanged;
			this.comboIcon.Changed += this.OnComboIconChanged;
			this.comboColor.Changed += this.OnComboColorChanged;
			this.buttonSource.Clicked += this.OnButtonSourceClicked;
			this.buttonOk.Clicked += this.OnButtonAddClicked;
		}

		#region Init

		private void LoadIcons ()
		{
			foreach (var icon in IconDownloader.DownloadIconsFromRepo()) {
				this.comboIcon.AppendText (icon);
			}
		}

		private void LoadColors ()
		{
			foreach (var color in IconColors.KnownColors) {
				this.comboColor.AppendText (color);
			}
			foreach (var color in IconColors.Colors.Keys) {
				this.comboColor.AppendText (color);
			}
			this.comboColor.Active = 0;
		}

		private void LoadSizes ()
		{
			foreach (var color in IconDownloader.KnownSizes) {
				this.comboSize.AppendText (color);
			}
			this.comboSize.Active = 1;
		}

		private void SetPreview ()
		{
			try {
				var icon = this.comboIcon.ActiveText;
				if (string.IsNullOrEmpty (icon))
					return;
				// start waiting
				this.GdkWindow.Cursor = new Gdk.Cursor (Gdk.CursorType.Watch);

				var color = this.comboColor.ActiveText;
				var size = this.comboSize.ActiveText;
				var data = IconDownloader.DownloadIcon (icon, 
					           IconLocation.DRAWABLE_HDPI_FOLDER, 
					           IconColors.FixColor (IconColors.NormalizeColor (color)), 
					           size);
				if (!IconColors.IsKnownColor (color))
					data = IconColors.ReplaceColor (data, IconColors.GetColor (color));
				this.imagePreview.Pixbuf = new Gdk.Pixbuf (data);
			} finally {
				this.GdkWindow.Cursor = new Gdk.Cursor (Gdk.CursorType.LeftPtr);
			}
		}

		private void SetName ()
		{
			this.entryName.Text = this.GetName ();
		}

		private string GetName ()
		{
			var icon = this.comboIcon.ActiveText;
			if (string.IsNullOrEmpty (icon))
				return "";
			var color = this.comboColor.ActiveText;
			var size = this.comboSize.ActiveText;
			return IconLocation.NormalizeFileName (icon, color, size);
		}

		#endregion

		#region Events

		protected void OnComboIconChanged (object sender, EventArgs e)
		{
			this.SetPreview ();
			this.SetName ();
		}

		protected void OnComboSizeChanged (object sender, EventArgs e)
		{
			this.SetPreview ();
			this.SetName ();
		}

		protected void OnComboColorChanged (object sender, EventArgs e)
		{
			this.SetPreview ();
			this.SetName ();
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			this.StartDownloading ();
		}

		protected void OnButtonSourceClicked (object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start ("https://github.com/google/material-design-icons");
		}

		#endregion

		private void StartDownloading ()
		{
			try {
				var icon = this.comboIcon.ActiveText;
				if (string.IsNullOrEmpty (icon))
					return;

				// start waiting
				this.GdkWindow.Cursor = new Gdk.Cursor (Gdk.CursorType.Watch);

				var folders = new List<string> ();
				if (this.checkhdpi.Active)
					folders.Add (IconLocation.DRAWABLE_HDPI_FOLDER);
				if (this.checkmdpi.Active)
					folders.Add (IconLocation.DRAWABLE_MDPI_FOLDER);
				if (this.checkxhdpi.Active)
					folders.Add (IconLocation.DRAWABLE_XHDPI_FOLDER);
				if (this.checkxxhdpi.Active)
					folders.Add (IconLocation.DRAWABLE_XXHDPI_FOLDER);
				if (this.checkxxxhdpi.Active)
					folders.Add (IconLocation.DRAWABLE_XXXHDPI_FOLDER);
				var color = this.comboColor.ActiveText;
				var size = this.comboSize.ActiveText;
				var name = this.entryName.Text;
				if (string.IsNullOrEmpty (name))
					name = IconLocation.NormalizeFileName (icon, color, size);

				foreach (var folder in folders) {
					var data = IconDownloader.DownloadIcon (icon, folder, 
						           IconColors.FixColor (IconColors.NormalizeColor (color)), size);
					if (!IconColors.IsKnownColor (color))
						data = IconColors.ReplaceColor (data, IconColors.GetColor (color));
					// save
					var baseDir = this.GetProjectDir ();
					var fullPath = System.IO.Path.Combine (baseDir, IconLocation.RESOURCES_FOLDER, folder, 
						               name + IconLocation.ICON_EXTENSION);
					// save to folder
					IconLocation.SaveIcon (data, fullPath);
					// add to project
					this.AddFileToProject (fullPath);
				}

				this.SaveProject ();
			} finally {
				this.GdkWindow.Cursor = new Gdk.Cursor (Gdk.CursorType.LeftPtr);
			}
		}

		private string GetProjectDir ()
		{
			return IdeApp.ProjectOperations.CurrentSelectedProject.BaseDirectory.ToString ();
		}

		private void AddFileToProject (string filename)
		{
			var file = IdeApp.ProjectOperations.CurrentSelectedProject.AddFile (filename, "AndroidResource");
		}

		private void SaveProject ()
		{
			IdeApp.ProjectOperations.CurrentSelectedProject.Save (new NullProgressMonitor ());
		}
	}
}
