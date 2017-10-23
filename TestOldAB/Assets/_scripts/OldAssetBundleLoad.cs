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



    // Use this for initialization
	void Start () 
    {
        StartCoroutine(LoadALLGameObject(PathURL + "ALL.assetbundle"));
	}

    void Update()
    {
        m_frameCount++;
    }

    private IEnumerator LoadALLGameObject(string path)
    {
        // 打印出当前执行的帧数.

        Debug.Log("m_frameCount = "  +m_frameCount);

        WWW bundle = new WWW(path);


        Debug.Log("m_frameCount = " + m_frameCount);

        yield return bundle;

        Debug.Log("m_frameCount = " + m_frameCount);

        Object obj0 = bundle.assetBundle.Load("Cube1");

        Debug.Log("m_frameCount = " + m_frameCount);

        Object obj1 = bundle.assetBundle.Load("Cube2");

        Debug.Log("m_frameCount = " + m_frameCount);

        yield return Instantiate(obj0);

        Debug.Log("m_frameCount = " + m_frameCount);


        yield return Instantiate(obj1);

        Debug.Log("m_frameCount = " + m_frameCount);

        bundle.assetBundle.Unload(false);

        Debug.Log("m_frameCount = " + m_frameCount);
    }
}
