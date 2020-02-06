using App.Views;
using UnityEngine;
using Zenject;

namespace App.Contract
{
    public class GameController : IGameController
    {
        [Inject]
        public GameView View { get; set; }
        
        public void InstantiateFromPrefabName(string name, GameObject parent)
        {
            View.InstantiateFromPrefabName(name, parent);
        }

        public GameObject GetEnemiesRoot()
        {
            return View.GetEnemiesSpawnRoot();
        }

        public GameObject GetCanvasRoot()
        {
            return View.GetCanvasRoot();
        }
    }
}