using SquishIt.Framework;

namespace SquishIt.MsIeHogan
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            Bundle.RegisterScriptPreprocessor(new HoganPreprocessor());
        }
    }
}
