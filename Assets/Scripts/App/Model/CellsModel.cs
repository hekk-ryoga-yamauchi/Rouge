using System.Linq;
using App.Contract;
using App.Views;
using Zenject;

namespace App.Models
{
    public class CellsModel : ICellsModel
    {
        [Inject]
        CellModel.Factory _cellModelFactory;

        private ICellModel[] _cellModels;

        public void SendCellMessage(CellView[] cellViews)
        {
            foreach (var cellView in cellViews)
            {
                var id = cellView.Id;
                var cellModel = _cellModelFactory.Create(id);
                cellModel.SetPosition(id % 11, id % 11);
                _cellModels[cellModel.Id] = cellModel;
            }
        }

        public ICellModel GetCellModel(int id)
        {
            return _cellModels.FirstOrDefault(g => g.Id == id);
        }
    }
}