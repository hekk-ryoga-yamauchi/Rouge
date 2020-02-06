using App.Contract;
using App.Domain.MasterData;
using Zenject;

namespace App.Services
{
    public class InputService : IInputService
    {
        [Inject]
        private IInputModel _inputModel;
        public void SetCanInput(bool state)
        {
            _inputModel.SetCanInput(state);
        }

        public void SetInputState(SceneStateMasterData sceneStateMasterData)
        {
            _inputModel.SetInputState(sceneStateMasterData);
        }
    }
}