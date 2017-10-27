using UnityEngine;
using System.Collections;

public class ScenesMgr : MonoBehaviour 
{
    // 场景加载器.
    private SceneLoader m_sceneLoader;


    //// 外部不能
    //void Awake()
    //{
    //    // 是否需要对m_instance进行为空的判断.
    //    // 这里没有调用到getInstance函数.
    //    //if (m_instance == null)
    //    //{
    //    //    Debug.Log("ScenesMgr.cs Awake is null");

    //    //    m_instance = this;
    //    //}

        
    //}



    private static ScenesMgr m_instance;

    public static ScenesMgr getInstance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = new ScenesMgr();
            }
            return m_instance;
        }
    }


    // 提供对外功能.
    public void GotoScene()
    {
        ShowLoading();

        // 直接加载Loading Scene.
        Application.LoadLevel("LoadingScene");

        // 开始异步加载目标场景？
        StartLoad();

    }

    public AsyncOperation LoadSceneAsync()
    {
        // 设置状态.

        return Application.LoadLevelAsync("BeginScene");
    }

    private void StartLoad()
    {
        m_sceneLoader.StartLoad();
    }

    /// <summary>
    /// 显示Loading Prefab.
    /// </summary>
    private void ShowLoading()
    {
        CheckIfCreateLoader();

        if (m_sceneLoader != null && m_sceneLoader.gameObject != null)
        {
            m_sceneLoader.gameObject.SetActive(true);
        }
    }

    /// <summary>
    /// 把SceneLoader的对象脚本保存在ScenesMgr中.
    /// </summary>
    private void CheckIfCreateLoader()
    {
        if (null == m_sceneLoader)
        {
            GameObject go = GameObject.Find("SCENE_LOAD_Prefab");
            if (null != go)
            {
                m_sceneLoader = go.AddComponent<SceneLoader>();
            }
        }
    }

}
