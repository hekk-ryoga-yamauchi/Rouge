using App.Views;
using Zenject;

namespace App.Contract
{
    public class PlayerController : IPlayerController
    {
        [Inject]
        private IPlayerModel _model;

        [Inject]
        private IGameController GameController;

        [Inject]
        public void Construct()
        {
             GameController.InstantiateFromPrefabName("Prefabs/Player/Player",GameController.GetCanvasRoot());
        }

        public void SendInputMessage(string inputMessage)
        {
            switch (inputMessage)
            {
                case "a":
                    MoveLeft();
                    break;
                case "s":
                    MoveDown();
                    break;
                case "d":
                    MoveRight();
                    break;
                case "w":
                    MoveUp();
                    break;
                case "c":
                    Attack();
                    break;
            }
        }

        private void MoveRight()
        {
            _model.MoveRight();
        }

        private void MoveLeft()
        {
            _model.MoveLeft();
        }

        private void MoveUp()
        {
            _model.MoveUp();
        }

        private void MoveDown()
        {
            _model.MoveDown();
        }

        private void Attack()
        {
            _model.Attack();
        }

        private void Move(int x, int y)
        {
            
        }
    }
}