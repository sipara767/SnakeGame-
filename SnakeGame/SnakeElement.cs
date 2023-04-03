﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace SnakeGame
{
    internal class SnakeElement
    {
            public SnakeElement(int size)
            {
                Rectangle rect = new Rectangle();
                rect.Width = size;
                rect.Height = size;
                rect.Fill = Brushes.Green;
                UIElement = rect;
            }
            public UIElement UIElement { get; set; }
            public bool IsHead { get; set; }
            public int X { get; set; }
            public int Y { get; set; }

       
    }
}
