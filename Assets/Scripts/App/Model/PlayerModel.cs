using App.Contract;
using UnityEngine;

namespace App.Models
{
    public class PlayerModel : IPlayerModel
    {
        private Vector2Int _position;
        private Vector2Int _direction;

        public void MoveRight()
        {
            _position = new Vector2Int(_position.x + 1, _position.y);
        }

        public void MoveLeft()
        {
            _position = new Vector2Int(_position.x - 1, _position.y);
        }

        public void MoveUp()
        {
            _position = new Vector2Int(_position.x, _position.y + 1);
        }

        public void MoveDown()
        {
            _position = new Vector2Int(_position.x, _position.y - 1);
        }

        public void Attack()
        {
            Debug.Log("攻撃！！");
        }

        public void Move(int x, int y)
        {
            _position = new Vector2Int(x, y);
        }

        public void SetDirection(int x, int y)
        {
            _direction = new Vector2Int(x, y);
        }

        public Vector2Int GetPosition()
        {
            return _position;
        }

        public Vector2Int GetDirection()
        {
            return _direction;
        }

        public override string ToString()
        {
            return $"position x : {_position.x}, y : {_position.y}, direction : {_direction}";
        }
    }
}