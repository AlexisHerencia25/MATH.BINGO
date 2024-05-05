using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Bingo
{
    public class Estructura : Window
    {
        public struct Controles
        {
            public TextBox rndN { get; set; }
            public Controles()
            {
                rndN = new TextBox();              
            }
        }
    }
}
