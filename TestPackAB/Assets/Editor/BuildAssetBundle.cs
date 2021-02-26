using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;


public static class BuildAssetBundle
{
    private static BuildAssetBundleOptions buildOptions =
        // 不包含类型信息, 减小包体并提高加载速度
        //BuildAssetBundleOptions.DisableWriteTypeTree |
        // 禁用以资源名与扩展名索引, 节省运行时内存并提高加载性能
        BuildAssetBundleOptions.DisableLoadAssetByFileNameWithExtension;

    [MenuItem("Tools/PackAB")]
    public static void PackAB()
    {
        Debug.Log("PackAB Start");


        string buildTarget = EditorUserBuildSettings.activeBuildTarget.ToString();

        // Debug.Log(buildTarget);


        string buildDirectory = Application.streamingAssetsPath; // + assetBundleDirectory + GetPlatfomDirectory(buildTarget) + folder;
        Debug.Log("输出目录:" + buildDirectory);
        if (!Directory.Exists(buildDirectory))
        {
            Directory.CreateDirectory(buildDirectory);
        }

        BuildPipeline.BuildAssetBundles(buildDirectory, buildOptions, EditorUserBuildSettings.activeBuildTarget);


        Debug.Log("PackAB Done!!!");
    }
}
