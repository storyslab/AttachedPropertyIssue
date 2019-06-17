using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace PassingAttachedPropertyInControlTemplater
{
    class Translation
    {
        public static int GetTranslationModelID(DependencyObject obj)
        {
            return (int)obj.GetValue(TranslationModelIDProperty);
        }

        public static void SetTranslationModelID(DependencyObject obj, int value)
        {
            obj.SetValue(TranslationModelIDProperty, value);
        }

        public static readonly DependencyProperty TranslationModelIDProperty =
            DependencyProperty.RegisterAttached("TranslationModelID", typeof(int), typeof(FrameworkElement), new PropertyMetadata(0));

    }
}
