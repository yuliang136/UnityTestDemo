using UnityEngine;
using System.Collections;

public class GameLoading : MonoBehaviour 
{

    // 用来保存加载GameObject.
    private GameObject m_loadUI;

    void Awake()
    {
        // 使得在场景切换时 这个GameObject不会被销毁.
        m_loadUI = GameObject.Find("SCENE_LOAD_Prefab");
        if (m_loadUI != null)
        {
            DontDestroyOnLoad(m_loadUI);
        }
        
    }

	// Use this for initialization
	void Start () 
    {
        //StartCoroutine(BeginLoad());


        gameObject.AddComponent("Game");
	}

    private IEnumerator BeginLoad()
    {
        yield return new WaitForSeconds(2);

        Debug.Log("Start Load LoadingScene");

        // 同步加载Loading.
        Application.LoadLevel("LoadingScene");

    }


	// Update is called once per frame
	void Update () 
    {
	
	}
}
