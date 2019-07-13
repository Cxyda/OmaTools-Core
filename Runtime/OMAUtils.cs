using System;
using System.Linq;
using Plugins.O.M.A.Games.Core.ErrorHandling;
using UnityEditor;
using UnityEngine;

namespace Plugins.O.M.A.Games.Core
{
    /// <summary>
    /// TODO:
    /// </summary>
    public static class OMAUtils
    {
        private const string Prefix = ":: -- O.M.A.Tools -"; 

        public static string GetModuleName(Type declaringType)
        {
            var module = declaringType.Namespace != null ? declaringType.Namespace.Split('.').Last() : "Unknown";
            return Prefix + " Module: " + module;
        }

        #if UNITY_EDITOR
        public static T GetFloatingCameraSettings<T>() where T : ScriptableObject
        {
            var allSettingsGuids = AssetDatabase.FindAssets("t:" + typeof(T).Name);
            if (allSettingsGuids.Length == 0)
            {
                throw new OMAException("Cannot find a ScriptableObject of type " +  typeof(T).Name + ". Please create one ");
            }

            var settingsSoPath = AssetDatabase.GUIDToAssetPath(allSettingsGuids[0]);
            var settingsSo = AssetDatabase.LoadAssetAtPath<T>(settingsSoPath);
            return settingsSo;
        }
        #endif
    }
}