using UnityEngine;
using System.Collections;

public class OldAssetBundleLoad : MonoBehaviour 
{
    public static int m_frameCount = 0;

    // 不同平台下StreamingAssets的路径不同
    public static readonly string PathURL =
#if UNITY_ANDROID
    "jar:file://" + Application.dataPath + "!/assets/";

#elif UNITY_IPHONE
    Application.dataPath + "/Raw/"
#elif UNITY_STANDALONE_WIN || UNITY_EDITOR
    "file://" + Application.dataPath + "/StreamingAssets/";
#else
        string.Empty;
#endif

    IEnumerator _current;

    // Use this for initialization
	void Start () 
    {
        //_current = LoadALLGameObject(PathURL + "ALL.assetbundle");
        //StartCoroutine(MyLoad());

        //StartCoroutine(LoadALLGameObject(PathURL + "ALL.assetbundle"));

        //_current = MyTestYield();
        //StartCoroutine(LoadMainGameObject(PathURL + "green.assetbundle"));
        StartCoroutine(LoadMainGameObject(PathURL + "Cube1.assetbundle"));
        //StartCoroutine(LoadMainGameObject(PathURL + "Cube2.assetbundle"));

	}

    //IEnumerator MyLoad()
    //{
    //    while (true)
    //    {
    //        //Check if we have a current coroutine and MoveNext on it if we do  
    //        //if (_current != null && _current.MoveNext())
    //        if (_current.MoveNext())
    //        {
    //            //Return whatever the coroutine yielded, so we will yield the  
    //            //same thing  

    //            if (_current.Current is WWW)
    //            {
    //                Debug.Log("_current.Current is WWW object");
    //            }

    //            Debug.Log("Call time");

    //            yield return _current.Current;
    //        }
    //        else
    //        {
    //            //Debug.Log("_current.Current is null");
    //            //Otherwise wait for the next frame  
    //            yield return null;
    //        }

    //    }
    //}

    IEnumerator MyTestYield()
    {
        yield return null;
        yield return null;
        yield return null;
    }

    private IEnumerator LoadMainGameObject(string path)
    {
        WWW bundle = new WWW(path);

        yield return bundle;

        MeshRenderer meshRenderer = bundle.assetBundle.mainAsset as MeshRenderer;

        if (null != meshRenderer)
        {
            Debug.Log(meshRenderer.name);
        }

        Instantiate(bundle.assetBundle.mainAsset);
        yield return null;

        bundle.assetBundle.Unload(false);
    }

    private IEnumerator LoadALLGameObject(string path)
    {
        // 打印出当前执行的帧数.

        Debug.Log("1 Time.frameCount = " + Time.frameCount);

        WWW bundle = new WWW(path);


        Debug.Log("2 Time.frameCount = " + Time.frameCount);

        yield return bundle;
        //yield return null;

        Debug.Log("3 Time.frameCount = " + Time.frameCount);

        Object obj0 = bundle.assetBundle.Load("Cube1");

        Debug.Log("4 Time.frameCount = " + Time.frameCount);

        Object obj1 = bundle.assetBundle.Load("Cube2");

        Debug.Log("5 Time.frameCount = " + Time.frameCount);

        //yield return Instantiate(obj0);
        Instantiate(obj0);
        yield return null;

        Debug.Log("6 Time.frameCount = " + Time.frameCount);


        Instantiate(obj1);
        yield return null;
        //yield return Instantiate(obj1);

        Debug.Log("7 Time.frameCount = " + Time.frameCount);

        bundle.assetBundle.Unload(false);

        Debug.Log("8 Time.frameCount = " + Time.frameCount);
    }



    void Update()
    {
        m_frameCount++;
    }


}
