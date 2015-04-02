using System;
using System.Linq;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;

namespace MaterialIconsGenerator.Commands
{
	public class AddIconHandler : CommandHandler
	{
		protected override void Run ()
		{
			try {
				var dialog = new MainDialog ();
				MessageService.ShowCustomDialog (dialog);
			} catch (Exception ex) {
				MessageService.ShowException (ex);
			}
		}

		protected override void Update (CommandInfo info)
		{
			base.Update (info);

			info.Visible = IdeApp.ProjectOperations.CurrentSelectedProject
				.GetProjectTypes ().ToList ().Contains ("MonoDroid");
		}
	}
}

