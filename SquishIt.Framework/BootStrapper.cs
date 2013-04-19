using SquishIt.Framework.Utilities;

namespace SquishIt.Framework
{
    public static class Bootstrapper
    {
        public static void Shutdown()
        {
            TempFileResolutionCache.Clear();
        }
    }
}
