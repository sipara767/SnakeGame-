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
    
    public partial class MainWindow : Window
    {
        int _elementSize = 20;
        DispatcherTimer _gameLoopTimer;
        
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            DrawGameWorld();
        }

        private void DrawGameWorld() {
            var numberOfColums = this.Width / _elementSize;
            var numberOfRows = this.Height / _elementSize;

            for (int i = 0; i < numberOfRows; i++) {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = 0;
                line.Y1 = i * _elementSize;
                line.X2 = Width;
                line.Y2 = i * _elementSize;
                GameWorld.Children.Add(line);
            }
            for (int i = 0; i < numberOfColums; i++) {
                Line line = new Line();
                line.Stroke = Brushes.Black;
                line.X1 = i * _elementSize;
                line.Y1 = 0;
                line.X2 = i * _elementSize  ;
                line.Y2 = Height;
                GameWorld.Children.Add(line);
            }

        }

        public void InitializeTimer() {
            _gameLoopTimer = new DispatcherTimer();
            _gameLoopTimer.Interval = TimeSpan.FromSeconds(0.5);
            //_gameLoopTimer.Tick += MainGameLoop();
            _gameLoopTimer.Start();
        }

      
    }
}
