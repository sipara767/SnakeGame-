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
using SnakeElement;
using FoodElement;
using Environment;

namespace SnakeNet6.ViewModel {
    public class MainViewModel : INotifyPropertyChanged {
        DispatcherTimer gameTimer = new DispatcherTimer();

        private SnakeClass snake;
        private FoodClass food;
        private bool[,] matrix = new bool[25, 25];

        public ICommand MoveUpCommand { get; set; }
        public ICommand MoveRightCommand { get; set; }
        public ICommand MoveDownCommand { get; set; }
        public ICommand MoveLeftCommand { get; set; }

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
            snake = new SnakeClass();
            food = new FoodClass();
            evm = new EnvironmentClass();
             
            MoveUpCommand = new MvvmCross.Commands.MvxCommand(() => snake.SetDirectionUp());
            MoveRightCommand = new MvvmCross.Commands.MvxCommand(() => snake.SetDirectionRight());
            MoveDownCommand = new MvvmCross.Commands.MvxCommand(() => snake.SetDirectionDown());
            MoveLeftCommand = new MvvmCross.Commands.MvxCommand(() => snake.SetDirectionLeft());

            while (snake.IsAlive) {
                snake.IsSnakeInsideBound();
                if (snake.X == food.X && snake.Y == food.Y) {
                    snake.Score++;
                }
                snake.IncreaseOrDecreaseXYValues(snake.CurrentDirection);

                Thread.Sleep(300);
            }
        }
    }
}
