using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace PrismApp3
{
    // https://social.msdn.microsoft.com/Forums/ja-JP/5aae0981-34e8-47d8-b6a2-bba47ace327b/problem-in-winrt-items-control-with-itemspaneltemplate-as-canvas
    class CanvasPositionBindableItemsControl : ItemsControl
    {
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            base.PrepareContainerForItemOverride(element, item);
            FrameworkElement source = element as FrameworkElement;
            source.SetBinding(Canvas.TopProperty, new Binding { Path = new PropertyPath("Top") });
            source.SetBinding(Canvas.LeftProperty, new Binding { Path = new PropertyPath("Left") });
        }
    }
}
