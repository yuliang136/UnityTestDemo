using UnityEngine;
using System.Collections;

public class Utils
{
    /// <summary>
    /// 创建GameObject 挂载泛型脚本 并返回脚本对象.
    /// </summary>
    /// <typeparam name="T">对T进行泛型约束 满足MonoBehaviour</typeparam>
    /// <param name="objName">创建GameObject的名字</param>
    /// <param name="objParent">parent的GameObject对象</param>
    /// <returns>挂载在</returns>
    public static T CreateGameObjectComponent<T>(string objName, GameObject objParent) where T : MonoBehaviour
    {
        // 根据objName创建GameObject名字
        GameObject obj = new GameObject(objName);

        T tClass = obj.AddComponent<T>();
        if (objParent != null)
        {
            obj.transform.parent = objParent.transform;
        }

        return tClass;
    }
}
