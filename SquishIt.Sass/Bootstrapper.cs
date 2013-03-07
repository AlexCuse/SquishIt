using SquishIt.Framework;

namespace SquishIt.Sass
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            Bundle.RegisterStylePreprocessor(new SassPreprocessor());
        }
    }
}
