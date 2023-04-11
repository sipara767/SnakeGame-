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
using SnakeNet6.Model;

namespace SnakeNet6.ViewModel {
    internal class MainViewModel : INotifyPropertyChanged {
        DispatcherTimer gameTimer = new DispatcherTimer();

        private Model.SnakeElement snake;
        private Model.FoodElement food;

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
            food = new Model.FoodElement();

            LaunchSettings();

            



            Position = new Point(100, 100);
          
            MoveUp = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X, position.Y + 10); });
            MoveRight = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X + 10, position.Y); });
            MoveDown = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X, position.Y - 10); });
            MoveLeft = new MvvmCross.Commands.MvxCommand(() => { Position = new Point(position.X - 10, position.Y); });


            
        }

        private void LaunchSettings() {
            food.SetFoodPosition();
            bool[,] matrix = new bool[25, 25];
            for (int i = 0; i < 25; i++) {
                for (int j = 0; j < 25; j++) {
                    matrix[i, j] = false;
                }
            }


            f

            for (int i = 0; i < 25; i++) {
                for (int j = 0; j < 25; j++) {
                    if (matrix[i, j] != snake.Position[i, j]) {
                        //position snake
                    }
                }
            }
        }
    }
}
