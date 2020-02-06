using App.Models;
using App.Views;

namespace App.Contract
{
    public interface ICellsView
    {
        
    }

    public interface ICellsController
    {
        void SendCellsMessage(CellView[] cellsViews);
    }

    public interface ICellsModel
    {
        void SendCellMessage(CellView[] cellsViews);
        ICellModel GetCellModel(int id);
    }

    public interface ICellsService
    {
        
    }
}