using UnityEngine;
using System.Collections;
using Dylib.File;



public class LoadABTest : MonoBehaviour 
{

    private WWWFile m_fontFile;
    private GameObject m_loadUI;
    private UILabel m_label;

    void Awake()
    {

        // 初始化FileLoader.
        GameObject fileLoader = new GameObject("FileLoader");
        fileLoader.AddComponent<FileLoader>();
        DontDestroyOnLoad(fileLoader);


        m_loadUI = GameObject.Find("LoadPrefab");
        m_label = m_loadUI.transform.Find("Label").gameObject.GetComponent<UILabel>();


        string local = "/res/ui/font/font.assetbundle";

        //string local = "/res/ui/font/errorFont.assetbundle";

        string fontUrl = string.Empty;

        //fontUrl = "file://" + Application.streamingAssetsPath + local;

        fontUrl = Setting.FILEPATH + local;

        //Debug.Log(fontUrl);

        m_fontFile = new WWWFile(fontUrl);


        // 调用协程3s后执行
        //StartCoroutine(exeLater());
        m_fontFile.GetContentWhenReady(LoadFontComplete);
    }

    //private IEnumerator exeLater()
    //{
    //    yield return new WaitForSeconds(3f);

    //    m_fontFile.GetContentWhenReady(LoadFontComplete);
    //}

    private void LoadFontComplete(IFile file, object param1 = null, object param2 = null, object param3 = null)
    {
        WWWFile wwwFile = file as WWWFile;

        //wwwFile.GetWWW().assetBundle.


        GameObject fontPrefab = wwwFile.GetWWW().assetBundle.mainAsset as GameObject;

        UIFont font = fontPrefab.GetComponent<UIFont>();

        // 设置字体.
        m_label.bitmapFont = font;

        // 设置显示内容.
        m_label.text = "测试字体显示";

        // 为什么需要清除内存.
        // wwwFile里面的WWW对象内存占用是什么样子.
        wwwFile.GetWWW().assetBundle.Unload(false);
        wwwFile.Clear();
        wwwFile = null;
        
    }

	// Use this for initialization
	void Start () 
    {
	    
	}
	
}
