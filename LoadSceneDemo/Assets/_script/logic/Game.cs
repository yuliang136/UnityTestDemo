using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{

    void Awake()
    {
        // 加载单例.
        //Debug.Log("Game.cs Awake");
        GameModel.instance.SetupMgr();
    }

    // Use this for initialization
    void Start()
    {
        // 切换开始场景.
        ScenesMgr.getInstance.GotoScene();
    }

}
