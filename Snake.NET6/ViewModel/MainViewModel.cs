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

namespace Snake.NET6.ViewModel {
    internal class MainViewModel : ObservableObject {
        DispatcherTimer gameTimer = new DispatcherTimer();
        
        private Model.SnakeElement snake;

        public Model.SnakeElement Snake {
            get { return snake; }
            set { snake = value; }
        }

        public ICommand IMoveUp { get; }
        public ICommand IMoveRight { get; }
        public ICommand IMoveDown { get; }
        public ICommand IMoveLeft { get; }


        private System.Windows.Threading.DispatcherTimer gameTickTimer = new System.Windows.Threading.DispatcherTimer();


        public MainViewModel() {
            snake = new Model.SnakeElement();
            IMoveUp = new RelayCommand(MoveUp);
            IMoveRight = new RelayCommand(MoveRight);
            IMoveDown = new RelayCommand(MoveDown);
            IMoveLeft = new RelayCommand(MoveLeft);
            LaunchSettings();
            gameTickTimer.Tick += GameTickTimer_Tick;
        }

        private void GameTickTimer_Tick(object? sender, EventArgs e) {
            if (snake.Direction == "up") {

            }
            else if (snake.Direction == "right") {

            }
            else if (snake.Direction == "down") {

            }
            else if (snake.Direction == "left") {

            }
        }

        private void LaunchSettings() {
            snake.Coordinates = new Thickness(Snake.X, Snake.Y, 0, 0);
        }
        private void MoveUp() {
            snake.Direction = "up";
        }
        private void MoveRight() {
            snake.Direction = "right";
        }
        private void MoveDown() {
            snake.Direction = "down";
        }
        private void MoveLeft() {
            snake.Direction = "left";
        }


    }
}
