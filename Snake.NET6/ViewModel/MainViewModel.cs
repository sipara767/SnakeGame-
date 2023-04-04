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
        private Model.SnakeElement snake;
        DispatcherTimer gameTimer = new DispatcherTimer();
        int speed = 5;

        public Model.SnakeElement Snake {
            get { return snake; }
            set { SetProperty(ref snake, value); }
        }

        public ICommand IMoveUp { get; }
        public ICommand IMoveRight { get; }
        public ICommand IMoveDown { get; }
        public ICommand IMoveLeft { get; }
        


        public MainViewModel() {
            snake = new Model.SnakeElement();
            IMoveUp = new RelayCommand(MoveUp);
            IMoveRight = new RelayCommand(MoveRight);
            IMoveDown = new RelayCommand(MoveDown);
            IMoveLeft = new RelayCommand(MoveLeft);
            LaunchSettings();

        }
        private void LaunchSettings() {
            Snake.Coordinates = new Thickness(Snake.X, Snake.Y, 0, 0);
        }
        private void MoveUp() {
            
        }
        private void MoveRight() {

            snake.Coordinates = new Thickness(Snake.X += 50, Snake.Y, 0, 0);
        }
        private void MoveDown() {
            Snake.Y += 1;
            
        }
        private void MoveLeft() {
            Snake.Y += 1;
            
        }


    }
}
