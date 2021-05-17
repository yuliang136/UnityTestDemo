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
        // Debug.Log("wait for 1s");
        // yield return new WaitForSeconds(1f);
        //
        // Debug.Log("wait for 2s");
        // yield return new WaitForSeconds(2f);
        //
        // Debug.Log("wait for 3s");
        // yield return new WaitForSeconds(3f);

        int v = 5;
        Debug.Log(v);

        yield return new WaitForSeconds(1);

        v++;
        Debug.Log(v);

        yield return 1;


    }
}
