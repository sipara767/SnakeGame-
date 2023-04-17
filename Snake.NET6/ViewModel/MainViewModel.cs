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
        private EnvironmentClass evm;

        public ICommand MoveUpCommand { get; set; }
        public ICommand MoveRightCommand { get; set; }
        public ICommand MoveDownCommand { get; set; }
        public ICommand MoveLeftCommand { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

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

            snake.SetDirectionRight();
            snake.X = 1;
            snake.Y = 12;

            while (snake.IsAlive) {
                snake.IsSnakeInsideBound();
                if (snake.X == food.X && snake.Y == food.Y) {
                    snake.Score++;
                    food.SetFood(snake.X, snake.Y);
                }
                snake.IncreaseOrDecreaseXYValues(snake);
                evm.ResetEnvironmentMatrixToFalse();
                evm.PlaceSnakeInEnvironment(snake);
                snake.IsAlive = snake.IsSnakeInsideBound();

                Thread.Sleep(300);
            }
            //GAME OVER
        }
    }
}
