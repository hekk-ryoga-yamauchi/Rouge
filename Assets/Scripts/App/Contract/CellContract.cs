using UnityEngine;

namespace App.Contract
{
    public interface ICellView
    {
        
    }

    public interface ICellController
    {
    }

    public interface ICellModel
    {
        int Id { get; }
        Vector2Int Position { get; }
        void SetPosition(int x, int y);

    }
}