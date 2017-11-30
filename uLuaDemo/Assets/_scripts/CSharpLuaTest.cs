using UnityEngine;
using System.Collections;
using LuaInterface;

public class CSharpLuaTest : MonoBehaviour
{

    // 创建lua虚拟机.
    private LuaState luaState = new LuaState();

    // Use this for initialization
    void Start()
    {
        // 在lua虚拟机中注册自定义函数.
        this.luaState.RegisterFunction("CSharpMethod",
                                        this,
                                        this.GetType().GetMethod("CSharpMethod"));

        // 加载lua文件.
        this.luaState.DoFile(Application.streamingAssetsPath + "/Test.lua");

        // 加载lua文件后 用GetFunction获取lua脚本中的函数.
        // 再调用Call执行.

        object[] objs = luaState.GetFunction("LuaMethod").Call(999);

        Debug.Log(string.Format("{0}-{1}", objs[0], objs[1]));

    }

    public string CSharpMethod(int num)
    {
        return string.Format("Hello World {0} !", num + 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
