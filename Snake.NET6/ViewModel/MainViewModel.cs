using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows;
using System.Data;
using Snake.NET6.View;
using System.ComponentModel;
using System.Threading;
using Snake.NET6.Model;

namespace Snake.NET6.ViewModel {
    internal class MainViewModel : INotifyPropertyChanged {
        DispatcherTimer gameTimer = new DispatcherTimer();

        private Model.SnakeElement snake;

        public Model.SnakeElement Snake {
            get { return snake; }
            set { snake = value; }
        }

        public ICommand MoveUp { get; set; }
        public ICommand MoveRight { get; set; }
        public ICommand MoveDown { get; set; }
        public ICommand MoveLeft { get; set; }

        public Point Position { get => position; set { position = value; NotifyPropertyChanged(nameof(Position)); } }

        private Point position;

        public event PropertyChangedEventHandler? PropertyChanged;

        private System.Windows.Threading.DispatcherTimer gameTickTimer = new System.Windows.Threading.DispatcherTimer();

        protected void NotifyPropertyChanged(String info) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }


        public MainViewModel() {
            snake = new Model.SnakeElement();
            LaunchSettings();

            Position = new Point(100, 100);
          
            MoveUp = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X, position.Y + 10); });
            MoveRight = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X + 10, position.Y); });
            MoveDown = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X, position.Y - 10); });
            MoveLeft = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X - 10, position.Y); });


            
        }

        private void LaunchSettings() {
           


            bool[,] Matrix = new bool[25, 25];

            foreach (var coordinateMatrix in Matrix) {
                foreach (var coordniateSnake in snake.SnakePos) {
                    if (coordinateMatrix == coordniateSnake) {

                    }
                }
            }
        }
    }
}
