using UnityEngine;
using System.Collections;

public class BeginScene : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        StartCoroutine(LoadAssets());
	}

    private IEnumerator LoadAssets()
    {
        yield return new WaitForSeconds(2);

        //Messenger.Broadcast(MessageName.MN_SCENE_CREATE_COMPLETE);

        // 这里访问getInstance时 m_instance之前没有值 会由getInstance判断New一个新的ScenesMgr对象出来
        // 和之前的对象已经不是同一个对象了.
        if (null == ScenesMgr.getInstance.m_sceneLoader)
        {
            Debug.Log("ScenesMgr.getInstance.m_sceneLoader is null");

            int nInstanceID = ScenesMgr.getInstance.GetInstanceID();
            Debug.Log("ScenesMgr.getInstance object = " + nInstanceID);
        }
        else
        {
            int nInstanceID = ScenesMgr.getInstance.GetInstanceID();
            Debug.Log("LoadAssets ScenesMgr.getInstance object = " + nInstanceID);

            Messenger.Broadcast(MessageName.MN_SCENE_CREATE_COMPLETE);
        }
    }
}
