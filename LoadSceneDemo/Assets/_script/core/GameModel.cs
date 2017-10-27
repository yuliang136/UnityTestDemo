using UnityEngine;
using System.Collections;

public class GameModel : MonoBehaviour 
{
    //public 
    public ScenesMgr sceneMgr = null;       // 场景管理器.

    public void SetupMgr()
    {
        GameObject model = this.gameObject;
        
        // 加载场景切换单例.
        sceneMgr = Utils.CreateGameObjectComponent<ScenesMgr>("ScenesMgr", model);

        Debug.Log("Here");

    }




    #region 单例部分
    private static GameModel s_Instance = null;

    // 实现一个单例.
    public static GameModel instance
    {
        get
        {
            if (s_Instance == null)
            {
                GameObject model = new GameObject("GameModel");
                s_Instance = model.AddComponent<GameModel>();
                DontDestroyOnLoad(model);
            }

            return s_Instance;
        }
    }

    void OnFinalize()
    {
        s_Instance = null;
    }
    #endregion
}
