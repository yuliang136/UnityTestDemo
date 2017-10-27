using UnityEngine;
using System.Collections;

public class SceneLoader : MonoBehaviour 
{
    // 由SceneLoader保留异步读取对象.
    // 这个prefab和脚本一直存在 不用固定在Loading场景里.
    private AsyncOperation m_async;

    public void StartLoad()
    {
        // 确保GameObject是可见的.
        gameObject.SetActive(true);


        // 从ScenesMgr获得加载的状态.
        // 状态管理放在ScenesMgr对象里.
        m_async = ScenesMgr.getInstance.LoadSceneAsync();
    }
}
