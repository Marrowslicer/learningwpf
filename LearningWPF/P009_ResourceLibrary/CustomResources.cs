using System.Windows;

namespace P009_ResourceLibrary
{
    public class CustomResources
    {
        public static ComponentResourceKey RedSolidBrush
        {
            get
            {
                return new ComponentResourceKey(typeof(CustomResources), "RedSolidBrush");
            }
        }

        public static ComponentResourceKey GreenSolidBrush
        {
            get
            {
                return new ComponentResourceKey(typeof(CustomResources), "GreenSolidBrush");
            }
        }
    }
}
