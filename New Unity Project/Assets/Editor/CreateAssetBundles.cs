﻿using UnityEditor;
using System.IO;

public class CreateAssetBundles
{
    [MenuItem("MiniMap/Build MiniMap AssetBundle")]
    static void BuildAllAssetBundles()
    {
        string assetBundleDirectory = "AssetBundles";
        if(!Directory.Exists(assetBundleDirectory))
        {
            Directory.CreateDirectory(assetBundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(assetBundleDirectory, 
                                        BuildAssetBundleOptions.None, 
                                        BuildTarget.StandaloneWindows);
    }
}