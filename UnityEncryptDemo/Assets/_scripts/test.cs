using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour
{

    public static int A = 10;

    public Text m_Show;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}

    public void ShowValue()
    {
        A++;
        m_Show.text = A.ToString();
    }
}
