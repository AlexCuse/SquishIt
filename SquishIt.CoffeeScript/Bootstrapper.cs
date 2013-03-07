using SquishIt.Framework;

namespace SquishIt.CoffeeScript
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            Bundle.RegisterScriptPreprocessor(new CoffeeScriptPreprocessor());
        }
    }
}
