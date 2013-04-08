using SquishIt.Framework.Resolvers;

namespace SquishIt.Framework
{
    public static class Bootstrapper
    {
        public static void Shutdown()
        {
            EmbeddedResourceResolver.ClearTempFiles();
        }
    }
}
