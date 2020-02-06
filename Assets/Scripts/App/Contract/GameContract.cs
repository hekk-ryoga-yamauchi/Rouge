using App.Views;
using UnityEngine;

namespace App.Contract
{

    public interface IGameController
    {
        void InstantiateFromPrefabName(string name, GameObject parent);
        GameObject GetCanvasRoot();
        GameView View { get; set; }
    }

    public interface IGameModel
    {
        
    }
}