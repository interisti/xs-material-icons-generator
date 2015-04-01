using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;

namespace MaterialIconsGenerator.Commands
{
	public class AddIconHandler : CommandHandler
	{
		protected override void Run ()
		{
			try {
//				var viewModels = new PackageManagementViewModels ();
//				IPackageManagementEvents packageEvents = PackageManagementServices.PackageManagementEvents;
//				var dialog = new ManagePackagesDialog (viewModels.ManagePackagesViewModel, packageEvents);
//				MessageService.ShowCustomDialog (dialog);
			} catch (Exception ex) {
				MessageService.ShowException (ex);
			}
		}

		protected override void Update (CommandInfo info)
		{
			base.Update (info);

		}
	}
}

