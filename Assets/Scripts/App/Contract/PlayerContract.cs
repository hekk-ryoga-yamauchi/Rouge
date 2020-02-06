using UnityEngine;

namespace App.Contract
{
    public interface IPlayerView
    {
        
    }

    public interface IPlayerController
    {
        void SendInputMessage(string direction);
    }

    public interface IPlayerModel
    {
        void MoveRight();
        void MoveLeft();
        void MoveUp();
        void MoveDown();
        void Attack();
        void Move(int x, int y);
        void SetDirection(int x, int y);

        Vector2Int GetPosition();
        Vector2Int GetDirection();
        

    }

    public interface IPlayerService
    {
        void SendInputMessage(string input);
    }
}