using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CustomControlTest.Controls
{
    public class BgLabelControl : Control
    {
        public BgLabelControl()
        {
            DefaultStyleKey = typeof(BgLabelControl);
        }


        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }


        DependencyProperty LabelProperty = DependencyProperty.Register(
            nameof(Label),
            typeof(string),
            typeof(BgLabelControl),
            new PropertyMetadata(default(string), new PropertyChangedCallback(OnLabelChanged)));

        public bool HasLabelValue { get; set; }

        private static void OnLabelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            BgLabelControl labelControl = d as BgLabelControl; //null checks omitted
            string s = e.NewValue as string; //null checks omitted
            if (s == string.Empty)
            {
                labelControl.HasLabelValue = false;
            }
            else
            {
                labelControl.HasLabelValue = true;
            }
        }

    }


}
