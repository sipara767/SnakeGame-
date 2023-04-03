using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace SnakeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int _elementSize = 20;
        DispatcherTimer _gameLoopTimer;
        List<SnakeElement> _snakeElements;
        private int _numberOfColumns;
        private int _numberOfRows;

        public MainWindow()
        {
            InitializeComponent();
            //InitializeTimer();
            DrawGameWorld();
            InitializeSnake();
            DrawSnake();
        }

        private void DrawSnake()
        {
            foreach (var snakeElement in _snakeElements)
            {
                if (!GameWorld.Children.Contains(snakeElement.UIElement))
                    GameWorld.Children.Add(snakeElement.UIElement);
                Canvas.SetLeft(snakeElement.UIElement, snakeElement.Y);
                Canvas.SetTop(snakeElement.UIElement, snakeElement.X);
            }
        }

        private void InitializeSnake()
        {
            _snakeElements = new List<SnakeElement>();
            _snakeElements.Add(new SnakeElement(_elementSize)
            {
                X = (_numberOfRows / 2) * _elementSize,
                Y = (_numberOfColumns / 2) * _elementSize
            });
        }

        private void DrawGameWorld()
        {
            _numberOfColumns = (int)this.Width / _elementSize;
            _numberOfRows = (int)this.Height / _elementSize;

            for (int i = 0; i < _numberOfRows; i++)
            {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = 0;
                line.Y1 = i * _elementSize;
                line.X2 = Width;
                line.Y2 = i * _elementSize;
                GameWorld.Children.Add(line);
            }
            for (int i = 0; i < _numberOfColumns; i++)
            {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = i * _elementSize;
                line.Y1 = 0;
                line.X2 = i * _elementSize;
                line.Y2 = Height;
                GameWorld.Children.Add(line);
            }

        }


    }
}
