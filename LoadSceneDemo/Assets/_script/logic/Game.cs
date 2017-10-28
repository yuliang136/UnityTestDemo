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
        // 静态对象 调用了非静态函数.
        // 里面的this指针指向哪里
        ScenesMgr.getInstance.GotoScene();
    }

}
