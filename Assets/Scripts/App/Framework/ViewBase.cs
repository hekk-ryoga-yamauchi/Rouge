using UniRx.Async;
using UnityEngine;

namespace App.Framework
{
    public abstract class ViewBase : MonoBehaviour
    {
        public virtual async void InstantiateFromPrefabName(string name, GameObject parent)
        {
            var obj = await Resources.LoadAsync(name);
            var instance = (GameObject)Instantiate(obj, parent.transform, true);
        }
    }
}