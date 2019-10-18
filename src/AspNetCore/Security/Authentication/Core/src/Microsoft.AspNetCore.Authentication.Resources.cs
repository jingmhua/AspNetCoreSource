// <auto-generated>
using System.Reflection;


namespace Microsoft.AspNetCore.Authentication
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

        /// <summary>The default data protection provider may only be used when the IApplicationBuilder.Properties contains an appropriate 'host.AppName' key.</summary>
        internal static string Exception_DefaultDpapiRequiresAppNameKey => GetResourceString("Exception_DefaultDpapiRequiresAppNameKey");
        /// <summary>The state passed to UnhookAuthentication may only be the return value from HookAuthentication.</summary>
        internal static string Exception_UnhookAuthenticationStateType => GetResourceString("Exception_UnhookAuthenticationStateType");
        /// <summary>The AuthenticationTokenProvider's required synchronous events have not been registered.</summary>
        internal static string Exception_AuthenticationTokenDoesNotProvideSyncMethods => GetResourceString("Exception_AuthenticationTokenDoesNotProvideSyncMethods");
        /// <summary>The '{0}' option must be provided.</summary>
        internal static string Exception_OptionMustBeProvided => GetResourceString("Exception_OptionMustBeProvided");
        /// <summary>The '{0}' option must be provided.</summary>
        internal static string FormatException_OptionMustBeProvided(object p0)
           => string.Format(Culture, GetResourceString("Exception_OptionMustBeProvided"), p0);

        /// <summary>The SignInScheme for a remote authentication handler cannot be set to itself.  If it was not explicitly set, the AuthenticationOptions.DefaultSignInScheme or DefaultScheme is used.</summary>
        internal static string Exception_RemoteSignInSchemeCannotBeSelf => GetResourceString("Exception_RemoteSignInSchemeCannotBeSelf");

    }
}