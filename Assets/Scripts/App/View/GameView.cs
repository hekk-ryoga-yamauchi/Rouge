using System.Runtime.InteropServices;
using App.Contract;
using App.Framework;
using UnityEngine;
using Zenject;

namespace App.Views
{
    public class GameView : ViewBase
    {
        [SerializeField]
        private GameObject _enemiesRoot = default;

        [SerializeField]
        private GameObject _canvasRoot = default;

        [Inject]
        private IGameController _gameController;
        
        [Inject]
        private void Construct()
        {
            _gameController.View = this;
        }

        public GameObject GetEnemiesSpawnRoot()
        {
            return _enemiesRoot.gameObject;
        }

        public GameObject GetCanvasRoot()
        {
            return _canvasRoot.gameObject;
        }


    }
}