using UnityEngine;
using System.Collections;

[RequireComponent(typeof(GUIText))]
public class Hijack : MonoBehaviour 
{
    IEnumerator _countUp;

    IEnumerator _countDown;

    IEnumerator _current;

    int value = 0;




	// Use this for initialization
	void Start () {
        //Create our count up coroutine  
        _countUp = CountUp();
        //Create our count down coroutine  
        _countDown = CountDown();
        //Start our own coroutine for the hijack  
        StartCoroutine(Dohijack());  
	}
	
	// Update is called once per frame
	void Update () {
        guiText.text = value.ToString();
	
	}

    void OnGUI()
    {
        //Switch between the different functions  
        if (GUILayout.Button("Switch functions"))
        {
            if (_current == _countUp)
                _current = _countDown;
            else
                _current = _countUp;
        }  
    }

    IEnumerator Dohijack()
    {
        while (true)
        {
            if (_current != null && _current.MoveNext())
            {
                yield return _current.Current;
            }
            else
            {
                yield return null;
            }
        }
    }

    IEnumerator CountDown()
    {
        float increment = 0;

        while (true)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                break;
            }

            increment += Time.deltaTime;
            value -= Mathf.RoundToInt(increment);
            yield return new WaitForSeconds(0.1f);
        }
    }

    IEnumerator CountUp()
    {
        float increment = 0;

        while(true)
        {
            if (Input.GetKey(KeyCode.Q))
            {
                break;
            }

            increment += Time.deltaTime;
            value += Mathf.RoundToInt(increment);
            yield return null;
        }
    }
}
