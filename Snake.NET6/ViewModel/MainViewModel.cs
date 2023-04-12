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
        private bool[,] matrix = new bool[25, 25];

        public Model.SnakeElement Snake {
            get { return snake; }
            set { snake = value; }
        }

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
            var currentDirection = SnakeElement.Directions.Right;
            snake = new Model.SnakeElement();
            food = new Model.FoodElement();
            LaunchSettings();
            gameTickTimer.Start();

             
            MoveUpCommand = new MvvmCross.Commands.MvxCommand(() => snake.MoveUp());
            MoveRightCommand = new MvvmCross.Commands.MvxCommand(() => snake.MoveRight());
            MoveDownCommand = new MvvmCross.Commands.MvxCommand(() => snake.MoveDown());
            MoveLeftCommand = new MvvmCross.Commands.MvxCommand(() => snake.MoveLeft());

            while (snake.Alive) {
                if (snake.X == food.X && snake.Y == food.Y) {
                    //Snake eats food
                    snake.Score++;
                }
                snake.Move(snake.currentDirection);
                snake.SetSnakePosition(snake.X, snake.Y);
                Thread.Sleep(300);
            }
            gameTickTimer.Stop();

        }
        public void SetSnakesPosition(int x, int y) {
            matrix[x, y] = true;
        }

        private void LaunchSettings() {
            food.SetFoodPosition();

            //Build matrix
            for (int i = 0; i < 25; i++) {
                for (int j = 0; j < 25; j++) {
                    matrix[i, j] = false;
                }
            }
        }
        private void TrackSnake(int x, int y) {

            for (int i = 0; i < 25; i++) {
                for (int j = 0; j < 25; j++) {
                    if (matrix[i, j] == true) {
                        //position snake
                    }
                }
            }
        }

    }
}
