using App.Contract;
using App.Domain.MasterData;
using UniRx.Async;
using UnityEngine;
using Zenject;

namespace App.Controller
{
    public class InputController : IInputController
    {
        [Inject]
        private IInputModel Model;

        [Inject]
        private IPlayerService _playerService;

        private SceneStateMasterData _sceneState => Model.GetSceneState();
        private bool _canGetInput;

        [Inject]
        private void Contract()
        {
            Model.SetInputState(SceneStateMasterData.battle);
            _canGetInput = true;
            SendInput().Forget();
        }

        private async UniTask SendInput()
        {
            while (_canGetInput)
            {
                await UniTask.Yield();
                if (Input.inputString != "")
                {
                    SendInputMessage(Input.inputString);
                }
            }
        }

        private void SendInputMessage(string input)
        {
            switch (_sceneState)
            {
                case SceneStateMasterData.battle:
                    SendToBattle(input);
                    break;
                case SceneStateMasterData.talk:
                    SendToTalk(input);
                    break;
            }
        }

        private void SendToBattle(string input)
        {
            _playerService.SendInputMessage(input);
        }

        private void SendToTalk(string input)
        {
            
        }
    }
}