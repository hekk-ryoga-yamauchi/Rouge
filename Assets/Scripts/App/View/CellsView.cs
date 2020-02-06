using App.Contract;
using UnityEngine;
using Zenject;

namespace App.Views
{
    public class CellsView : MonoBehaviour,  ICellsView
    {
        [Inject]
        private ICellsController _controller;
        
        [Inject]
        private void Construct()
        {
            CellView[] cellsViews = GetComponentsInChildren<CellView>();
            _controller.SendCellsMessage(cellsViews);
        }
        
    }
}