namespace P008_LearningFileSystem
{
    public static class StringExtensions
    {
        public static string Args(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}
