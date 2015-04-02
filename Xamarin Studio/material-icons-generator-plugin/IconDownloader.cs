using System;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace MaterialIcons.UI
{
	public static class IconDownloader
	{
		public static string GetIconUrl (string iconFull, string folder, string color, string size)
		{
			const string urlFormat = "https://raw.githubusercontent.com/google/material-design-icons/master/{0}/{1}/{2}_{3}_{4}.png";

			var iconFullArr = iconFull.Split ('/');
			var icon = iconFullArr [1];
			var category = iconFullArr [0];

			var url = string.Format (urlFormat,
				          category.ToLower (),
				          folder.ToLower (),
				          icon.ToLower (),
				          color.ToLower ().Replace (" ", ""),
				          size.ToLower ()
			          );
			return url;
		}

		public static byte[] DownloadIcon (string icon, string folder, string color, string size)
		{
			using (var webCl = new System.Net.WebClient ()) {
				return webCl.DownloadData (IconDownloader.GetIconUrl (icon, 
					folder, 
					IconColors.FixColor (IconColors.NormalizeColor (color)), 
					size));
			}
		}
	}
}

