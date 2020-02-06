using App.Contract;
using App.Domain.MasterData;

namespace App.Models
{
    public class InputModel : IInputModel
    {
        private SceneStateMasterData _sceneInputState = SceneStateMasterData.battle;

        private bool _canInput;

        public void SetInputState(SceneStateMasterData state)
        {
            _sceneInputState = state;
        }

        public SceneStateMasterData GetSceneState()
        {
            return _sceneInputState;
        }

        public void SetCanInput(bool can)
        {
            _canInput = can;
        }

        public bool GetCanInput()
        {
            return _canInput;
        }
    }
}