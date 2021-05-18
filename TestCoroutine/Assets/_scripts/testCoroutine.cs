using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCoroutine : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("testCoroutine Start.");
        StartCoroutine(Test());
    }

    private IEnumerator Test()
    {
        int v = 5;
        Debug.Log(v);
        yield return new WaitForSeconds(1);
        v++;
        Debug.Log(v);
        yield return 1;

        // public class ResourceRequest : AsyncOperation
        ResourceRequest rr = Resources.LoadAsync("test");

    }
}
