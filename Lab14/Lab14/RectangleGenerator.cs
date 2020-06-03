using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace Lab14
{
    public class RectangleGenerator : IControlGenerator
    {
        public UIElement Generate(string parameter)
        {
            return new Button()
            {
                Content = parameter
            };
        }
    }
}
