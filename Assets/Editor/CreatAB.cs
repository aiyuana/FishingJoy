using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class CreatAB
{
    [MenuItem("Assets/BuildAllAB")]
    static void BuildAB()
    {
        string dir = "AssetBundles";
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        BuildPipeline.BuildAssetBundles(dir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
    }
}