using SquishIt.Framework;

namespace SquishIt.MsIeCoffeeScript
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            Bundle.RegisterScriptPreprocessor(new CoffeeScriptPreprocessor());
        }
    }
}
