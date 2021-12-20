using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(ModTag.BuildInfo.Description)]
[assembly: AssemblyDescription(ModTag.BuildInfo.Description)]
[assembly: AssemblyCompany(ModTag.BuildInfo.Company)]
[assembly: AssemblyProduct(ModTag.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + ModTag.BuildInfo.Author)]
[assembly: AssemblyTrademark(ModTag.BuildInfo.Company)]
[assembly: AssemblyVersion(ModTag.BuildInfo.Version)]
[assembly: AssemblyFileVersion(ModTag.BuildInfo.Version)]
[assembly: MelonInfo(typeof(ModTag.ApplyTag), ModTag.BuildInfo.Name, ModTag.BuildInfo.Version, ModTag.BuildInfo.Author, ModTag.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("BricksVR", "BricksVR")]