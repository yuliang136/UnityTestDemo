using UnityEngine;
using System.Collections;
using UnityEditor;

public class TestPack
{
    [MenuItem("AB Editor/Create Single AssetBunlde")]
    public static void PackSingle()
    {
        string path = Application.dataPath + "/StreamingAssets";

        BuildTarget target = BuildTarget.StandaloneWindows64;

        BuildAssetBundleOptions op = BuildAssetBundleOptions.DeterministicAssetBundle |
                                        BuildAssetBundleOptions.CollectDependencies;

        //BuildAssetBundleOptions op = BuildAssetBundleOptions.DeterministicAssetBundle |
        //                                BuildAssetBundleOptions.CompleteAssets;

        //BuildAssetBundleOptions op = BuildAssetBundleOptions.DeterministicAssetBundle;

        //BuildAssetBundleOptions op = null;

        GameObject obSet = AssetDatabase.LoadMainAssetAtPath("Assets/Prefabs/Cube1.prefab") as GameObject;

        MeshRenderer myMesh = obSet.GetComponent<MeshRenderer>();

        BuildPipeline.BuildAssetBundle(myMesh,
                        null,
                        path + "/Cube1.assetbundle",
                        op,
                        target);

        AssetDatabase.Refresh();

    }
    

    [MenuItem("AB Editor/Create Dependence AssetBunldes")]
    public static void Pack()
    {
        string path = Application.dataPath + "/StreamingAssets";

        BuildTarget target = BuildTarget.StandaloneWindows64;

        BuildAssetBundleOptions op = BuildAssetBundleOptions.CollectDependencies |
                                        BuildAssetBundleOptions.CompleteAssets |
                                        BuildAssetBundleOptions.DeterministicAssetBundle;
        // (A
        BuildPipeline.PushAssetDependencies();

        BuildPipeline.BuildAssetBundle(AssetDatabase.LoadMainAssetAtPath("Assets/Resources/myMat.mat"),
                                        null,
                                        path + "/green.assetbundle",
                                        op,
                                        target);

        // (B
        BuildPipeline.PushAssetDependencies();
        BuildPipeline.BuildAssetBundle(AssetDatabase.LoadMainAssetAtPath("Assets/Prefabs/Cube1.prefab"),
                                null,
                                path + "/Cube1.assetbundle",
                                op,
                                target);
        // B)
        BuildPipeline.PopAssetDependencies();

        // (C
        BuildPipeline.PushAssetDependencies();
        BuildPipeline.BuildAssetBundle(AssetDatabase.LoadMainAssetAtPath("Assets/Prefabs/Cube2.prefab"),
                                null,
                                path + "/Cube2.assetbundle",
                                op,
                                target);
        // C)
        BuildPipeline.PopAssetDependencies();


        // A)
        BuildPipeline.PopAssetDependencies();

        AssetDatabase.Refresh();
    }

    [MenuItem("AB Editor/Create AssetBundles ALL")]
    static void CreateAssetBundlesALL()
    {
        Caching.CleanCache();

        string strPath = Application.dataPath + "/StreamingAssets/ALL.assetbundle";


        Object[] SelectedAsset = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);

        foreach (Object obj in SelectedAsset)
        {
            Debug.Log("Create AssetBundles name :" + obj);
        }

        if (BuildPipeline.BuildAssetBundle(null, SelectedAsset, strPath, BuildAssetBundleOptions.CollectDependencies))
        {
            AssetDatabase.Refresh();
        }
    }


    [MenuItem("AB Editor/Create AssetBundles Main")]
    static void CreateAssetbundlesMain()
    {
        //Debug.Log("CreateAssetbundlesMain");

        Object[] SelectedAsset = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);


        foreach (Object obj in SelectedAsset)
        {
            string sourcePath = AssetDatabase.GetAssetPath(obj);

            //Debug.Log(obj.name);

            //if ((obj.name == "Cube1") || (obj.name == "Cube2"))
            //{
            //    string targetPath = Application.dataPath + "/StreamingAssets/" + obj.name + ".assetbundle";

            //    if (BuildPipeline.BuildAssetBundle(obj, null, targetPath, BuildAssetBundleOptions.CollectDependencies))
            //    {
            //        Debug.Log(obj.name + " 资源打包成功");
            //    }
            //    else
            //    {
            //        Debug.Log(obj.name + " 资源打包失败");
            //    }
            //}

            string targetPath = Application.dataPath + "/StreamingAssets/" + obj.name + ".assetbundle";

            if (BuildPipeline.BuildAssetBundle(obj, null, targetPath, BuildAssetBundleOptions.CollectDependencies))
            {
                Debug.Log(obj.name + " 资源打包成功");
            }
            else
            {
                Debug.Log(obj.name + " 资源打包失败");
            }
        }

        //Debug.Log("Here");

        AssetDatabase.Refresh();
    }
}
