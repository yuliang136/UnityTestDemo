using UnityEngine;
using System.Collections;

public class ScenesMgr : MonoBehaviour 
{
    // 1 这里设置为static可用的原因是 变为针对类的一个实例.
    private static ScenesMgr m_instance;

    public SceneLoader m_sceneLoader;


    // 当附加脚本时 会调用这里.
    // 保证Awake在所有getInstance之前调用.
    void Awake()
    {
        // 保证m_instance保存的静态对象是addComponent时new出来的对象.
        // 这样可以通过gameObject获得这个唯一的对象值.
        m_instance = this;

        int nInstanceID = m_instance.GetInstanceID();

        Debug.Log("Awake m_instance InstanceID = " + nInstanceID);
    }

    void Start()    
    {
        Debug.Log("Start m_instance InstanceID = " + m_instance.GetInstanceID());
    }

    public static ScenesMgr getInstance
    {
        get
        {
            if (null == m_instance)
            {
                Debug.Log("Big Problem");
            }

            return m_instance;
        }
    }


    // 提供对外功能.
    // 静态对象调用非静态函数.
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
    /// 
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

                //int nInstanceID = this.GetInstanceID();
                //Debug.Log("CheckIfCreateLoader this.GetInstanceID = " + nInstanceID);
            }
        }
    }

}
