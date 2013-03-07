using SquishIt.Framework;

namespace SquishIt.Less
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            Bundle.RegisterStylePreprocessor(new LessPreprocessor());
        }
    }
}
