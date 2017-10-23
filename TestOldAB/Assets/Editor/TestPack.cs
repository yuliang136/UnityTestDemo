using UnityEngine;
using System.Collections;
using UnityEditor;

public class TestPack
{

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
