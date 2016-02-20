using System;
using Mono.Addins;
using Mono.Addins.Description;

[assembly:Addin (
	"material-icons-generator-plugin", 
	Namespace = "MaterialIconsGenerator",
	Version = "1.4",
	Url = "https://github.com/interisti/material-icons-generator-plugin"
)]

[assembly:AddinName ("Material icons generator")]
[assembly:AddinCategory ("IDE extensions")]
[assembly:AddinDescription ("This plugin help you to set material design icons to your Android project.")]
[assembly:AddinAuthor ("Nika Nikabadze")]

[assembly:AddinDependency ("::MonoDevelop.Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("::MonoDevelop.Ide", MonoDevelop.BuildInfo.Version)]