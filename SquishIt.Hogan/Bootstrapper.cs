using SquishIt.Framework;

namespace SquishIt.Hogan
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            Bundle.RegisterScriptPreprocessor(new HoganPreprocessor());
        }
    }
}
