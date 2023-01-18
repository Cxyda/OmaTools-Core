using System;
using UnityEngine.AddressableAssets;

namespace Modules.AssetUtils
{
    public interface IAssetLoader<out T>
    {
        void LoadAssetAsync(string assetPath, Action<T> onLoadedCallback);
        void LoadAssetAsync(AssetReference reference, Action<T> onLoadedCallback);

        void Unload(AssetReference reference);

        bool IsLoaded(AssetReference reference);
    }
}
