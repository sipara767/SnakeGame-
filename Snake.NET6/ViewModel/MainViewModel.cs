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

namespace Snake.NET6.ViewModel {
    internal class MainViewModel : ObservableObject {
        private Model.SnakeElement snake;
        DispatcherTimer gameTimer = new DispatcherTimer();
        int speed = 5;

        public Model.SnakeElement Snake {
            get { return snake; }
            set { SetProperty(ref snake, value); }
        }

        public ICommand MoveUp { get; }
        public ICommand MoveRight { get; }
        public ICommand MoveDown { get; }
        public ICommand MoveLeft { get; }


        public MainViewModel() {
            snake = new Model.SnakeElement();
            MoveUp = new RelayCommand(SnakeMoveUp);
            MoveRight = new RelayCommand(SnakeMoveRight);
            MoveDown = new RelayCommand(SnakeMoveDown);
            MoveLeft = new RelayCommand(SnakeMoveLeft);
        }
        private void SnakeMoveUp() {
            Snake.Y += 1;
        }

        private void SnakeMoveRight() {
            Snake.X += 1;
        }

        private void SnakeMoveDown() {
            Snake.Y -= 1;
        }

        private void SnakeMoveLeft() {
            Snake.Y -= 1;
        }

    }
}
