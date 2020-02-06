using App.Contract;
using App.Models;
using Zenject;

namespace App.Services
{
    public class CellsService : ICellsService
    {
        [Inject]
        private ICellsModel _cellsModel;
        
        public ICellModel GetCellModel(int id)
        {
            return _cellsModel.GetCellModel(id);
        }
    }
}