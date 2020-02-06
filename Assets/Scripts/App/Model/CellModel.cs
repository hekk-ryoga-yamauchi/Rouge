using App.Contract;
using UnityEngine;
using Zenject;

namespace App.Models
{
   public class CellModel : ICellModel
   {
      private int _id;
      private Vector2Int _position;
      public int Id => _id;
      public Vector2Int Position => _position;

      public CellModel(int Id)
      {
         _id = Id;
      }

      public void SetPosition(int x, int y)
      {
         _position = new Vector2Int(x,y);
      }
      
      public class Factory : PlaceholderFactory<int,CellModel> { }
   }
}