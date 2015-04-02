using System;
using System.Linq;
using Gtk;
using MaterialIcons.UI;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using MonoDevelop.Ide;
using MonoDevelop.Projects;

namespace MaterialIconsGenerator
{
	public partial class MainDialog : Gtk.Dialog
	{
		public MainDialog ()
		{
			this.Build ();
			this.LoadColors ();
		}

		#region Init

		private void LoadColors ()
		{
			foreach (var color in IconColors.Colors.Keys.OrderByDescending(x=> x).ToList()) {
				this.comboColor.PrependText (color);
			}
			foreach (var color in IconColors.KnownColors) {
				this.comboColor.PrependText (color);
			}
			this.comboColor.Active = 0;
		}

		private void SetPreview ()
		{

			try {
				var icon = this.comboIcon.ActiveText;
				if (string.IsNullOrEmpty (icon))
					return;
				// start waiting
				this.GdkWindow.Cursor = new Gdk.Cursor (Gdk.CursorType.Watch);

				var folder = IconLocation.DRAWABLE_HDPI_FOLDER;
				var color = this.comboColor.ActiveText;
				var size = this.comboSize.ActiveText;
				var data = IconDownloader.DownloadIcon (icon, 
					           folder, 
					           IconColors.FixColor (IconColors.NormalizeColor (color)), 
					           size);
				if (!IconColors.IsKnownColor (color))
					data = IconColors.ReplaceColor (data, IconColors.GetColor (color));
				this.imagePreview.Pixbuf = new Gdk.Pixbuf (data);
			} catch {

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
					var fullPath = System.IO.Path.Combine (baseDir, IconLocation.RESOURCES_FOLDER, folder, name + IconLocation.ICON_EXTENSION);
					// save to folder
					IconLocation.SaveIcon (data, fullPath);
					// add to project
					this.AddFileToProject (fullPath);
				}
			} catch {

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
	}
}

