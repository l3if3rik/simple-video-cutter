using System.Runtime.Versioning;

namespace SimpleVideoCutter
{
    [SupportedOSPlatform("windows")]
    internal class Globals
    {
        private static PlaceholderFiller? PlaceholderFillerSingleton;
        public static PlaceholderFiller PlaceholderFiller
        {
            get
            {
                return PlaceholderFillerSingleton ??= new PlaceholderFiller();
            }
        }
    }
}
