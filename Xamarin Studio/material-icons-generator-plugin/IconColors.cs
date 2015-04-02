using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace MaterialIcons.UI
{
	public static class IconColors
	{
		public static byte[] ReplaceColor (byte[] data, Color replacementColor)
		{
			using (var ms = new MemoryStream (data)) {
				var bitmap = new Bitmap (ms);
				for (var y = 0; y < bitmap.Height; y++) {
					for (var x = 0; x < bitmap.Width; x++) {
						var originalPixel = bitmap.GetPixel (x, y);
						if (originalPixel != Color.Transparent) {
							bitmap.SetPixel (x, y, Color.FromArgb (originalPixel.A, replacementColor));
						}
					}
				}
				var converter = new ImageConverter ();
				return (byte[])converter.ConvertTo (bitmap, typeof(byte[]));
			}
		}

		public static string NormalizeColor (string color)
		{
			return color.ToLower ().Replace (" ", "");
		}

		public static string FixColor (string color)
		{
			return IsKnownColor (color) ? color : "black";
		}

		public static bool IsKnownColor (string color)
		{
			color = NormalizeColor (color);
			return (color == "black" || color == "white" || color == "grey600");
		}

		public static Color GetColor (string name)
		{
			var colorName = NormalizeColor (name);
			return Colors.ContainsKey (colorName) ? Colors [colorName] : Color.Black;
		}

		public static List<string> KnownColors = new List<string> () {
			"white",
			"grey600",
			"black"
		};

		public static Dictionary<string, Color> Colors = new Dictionary<string, Color> () {
			{ "blue_dark", Color.FromArgb (0, 153, 204) },
			{ "blue_light", Color.FromArgb (51, 181, 229) },
			{ "green_dark", Color.FromArgb (102, 153, 0) },
			{ "green_light", Color.FromArgb (153, 204, 0) },
			{ "purple_dark", Color.FromArgb (153, 51, 204) },
			{ "purple_light", Color.FromArgb (170, 102, 204) },
			{ "red_dark", Color.FromArgb (204, 0, 0) },
			{ "red_light", Color.FromArgb (255, 68, 68) },
			{ "yellow_dark", Color.FromArgb (255, 136, 0) },
			{ "yellow_light", Color.FromArgb (255, 187, 51) },
			{ "red_50", ColorTranslator.FromHtml ("#fde0dc") },
			{ "red_100", ColorTranslator.FromHtml ("#f9bdbb") }
		};
	}
}

