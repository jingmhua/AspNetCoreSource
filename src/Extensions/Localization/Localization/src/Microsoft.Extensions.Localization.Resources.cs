// <auto-generated>
using System.Reflection;


namespace Microsoft.Extensions.Localization
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>The manifest '{0}' was not found.</summary>
        internal static string Localization_MissingManifest => GetResourceString("Localization_MissingManifest");
        /// <summary>The manifest '{0}' was not found.</summary>
        internal static string FormatLocalization_MissingManifest(object p0)
           => string.Format(Culture, GetResourceString("Localization_MissingManifest"), p0);

        /// <summary>No manifests exist for the current culture.</summary>
        internal static string Localization_MissingManifest_Parent => GetResourceString("Localization_MissingManifest_Parent");

    }
}
