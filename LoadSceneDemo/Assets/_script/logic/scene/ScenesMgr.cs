using UnityEngine;
using System.Collections;

public class ScenesMgr : MonoBehaviour 
{
    // 这里如果不是static. 设置为

    // 场景加载器.
    //private static SceneLoader m_sceneLoader;

    public SceneLoader m_sceneLoader;


    //// 外部不能
    //void Awake()
    //{

    //    // 是否需要对m_instance进行为空的判断. 这里没有调用到getInstance函数.
    //    // 这个Awake必须用.
    //    if (m_instance == null)
    //    {
    //        Debug.Log("ScenesMgr.cs Awake is null");

    //        m_instance = this;
    //    }


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

        // 开始监听SceneCreate完成的事件.
        Messenger.AddListener(MessageName.MN_SCENE_CREATE_COMPLETE, SceneCreateComplete);


        return Application.LoadLevelAsync("BeginScene");
    }

    private void SceneCreateComplete()
    {
        // 取消监听 结束本次的的场景切换.
        Messenger.RemoveListener(MessageName.MN_SCENE_CREATE_COMPLETE, SceneCreateComplete);

        CloseLoading();
    }

    private void CloseLoading()
    {
        if (null != m_sceneLoader)
        {
            m_sceneLoader.CloseLoad();
        }
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
        //getInstance.m_sceneLoader

        if (null == m_sceneLoader)
        {
            GameObject go = GameObject.Find("UI_SCENE_LOAD_Prefab");
            if (null != go)
            {
                m_sceneLoader = go.AddComponent<SceneLoader>();

                Debug.Log(m_sceneLoader.name);
            }
        }
    }

}
