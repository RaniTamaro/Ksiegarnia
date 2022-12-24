using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Firma.Views
{
    public class WszystkieSlownikoweViewBase : UserControl
    {
        static WszystkieSlownikoweViewBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(WszystkieSlownikoweViewBase), new FrameworkPropertyMetadata(typeof(WszystkieSlownikoweViewBase)));
        }
    }
}
