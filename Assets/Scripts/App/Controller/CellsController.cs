using App.Contract;
using App.Models;
using App.Views;
using Zenject;

namespace App.Controller
{
    public class CellsController : ICellsController
    {
        [Inject]
        private ICellsModel Model;
        public void SendCellsMessage(CellView[] cellsViews)
        {
            Model.SendCellMessage(cellsViews);
        }
    }
}