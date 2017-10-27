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

        if (null == ScenesMgr.getInstance.m_sceneLoader)
        {
            Debug.Log("ScenesMgr.getInstance.m_sceneLoader is null");
        }
    }
}
