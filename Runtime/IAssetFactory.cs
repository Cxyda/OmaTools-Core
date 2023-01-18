using UnityEngine;

namespace Modules.AssetUtils
{
    public interface IAssetFactory
    {
        GameObject Create(GameObject gameObject);
        GameObject Create(GameObject template, Vector3 position, Quaternion rotation, Transform parent);
        T Create<T>(T template, Vector3 position, Quaternion rotation, Transform parent) where T : MonoBehaviour;
        T Create<T>(T template, Transform parent) where T : MonoBehaviour;
        T AddComponent<T>(GameObject gameObject) where T : Component;
    }
}