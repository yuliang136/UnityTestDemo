using UnityEngine;
using System.Collections;

public class CoroutineCountdown : MonoBehaviour
{
    private bool firstUpdate = true;
    private bool firstLateUpdate = true;


    void Awake()
    {
 
    }

    // Use this for initialization
    void Start()
    {
        //StartCoroutine(Countdown());

        //StartCoroutine(SayHelloFiveTimes());

        //StartCoroutine(SayHello5Times());

        StartCoroutine(CountSeconds());

        //StartCoroutine(RepeatMessage(5, 1.0f, "Hello!"));

        //StartCoroutine(Wait(2.0f));

        //StartCoroutine(SaySomeThings());



    }

    IEnumerator MyCoutine()
    {
        Debug.Log("This is Start Coroutine Call Before" + " frameNum = " + Time.frameCount);
        //yield return new WaitForSeconds(1f);
        yield return null;
        Debug.Log("This is Start Coroutine Call After" + " frameNum = " + Time.frameCount);
    }

    void Update()
    {
        //if (firstUpdate)
        //{
            //Debug.Log("Update()" + " frameNum = " + Time.frameCount);
        //    firstUpdate = false;
        //}

        if (10 == Time.frameCount)
        {
            //this.enabled = false;
            this.gameObject.SetActive(false);
        }
    }

    void LateUpdate()
    {
        //if (firstLateUpdate)
        //{
            //Debug.Log("LateUpdate()" + " frameNum = " + Time.frameCount);
        //    firstLateUpdate = false;
        //}
    }

    IEnumerator SaySomeThings()
    {
        Debug.Log("The routine has started");

        yield return StartCoroutine(Wait(1.0f));

        Debug.Log("1 second has passed since the last message");
        
        yield return StartCoroutine(Wait(2.5f));
        
        Debug.Log("2.5 second has passed since the last message");

        
    }

    IEnumerator Wait(float duration)
    {
        //Debug.Log("Start Wait");

        for (float timer = 0; timer < duration; timer += Time.deltaTime)
        {
            yield return null;
        }

        //Debug.Log("Wait Done!");
    }

    IEnumerator RepeatMessage(int count, float frequency, string message)
    {
        for (int i = 0; i < count; i++)
        {
            Debug.Log(message);
            for (float timer = 0; timer < frequency; timer += Time.deltaTime)
            {
                yield return 0;
            }
        }
    }

    IEnumerator CountSeconds()
    {
        int seconds = 0;

        while (true)
        {
            // 延缓1s
            for (float timer = 0; timer < 1; timer += Time.deltaTime)
            {
                Debug.Log("frameCount = " + Time.frameCount + " " + "timer = " + timer);
                yield return 0;
            }

            seconds++;
            Debug.Log(seconds + " seconds have passed since the Coroutine started.");
        }
    }

    IEnumerator Countdown()
    {
        for (float timer = 3.0f; timer >= 0; timer -= Time.deltaTime)
        {
            //Time.frameCount

            Debug.Log("frameCount = " + Time.frameCount + " " + "timer = " + timer);

            //yield return 0;
            yield return null;
        }

        Debug.Log("This message appears after 3 seconds!");
    }

    IEnumerator SayHello5Times()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Hello");
            Debug.Log("frameCount = " + Time.frameCount);
            yield return 0;
        }
    }

    // This will say hello 5 times, 
    IEnumerator SayHelloFiveTimes()
    {
        Debug.Log("Hello");
        Debug.Log("frameCount = " + Time.frameCount);
        yield return 0;

        Debug.Log("Hello");
        Debug.Log("frameCount = " + Time.frameCount);
        yield return 0;

        Debug.Log("Hello");
        Debug.Log("frameCount = " + Time.frameCount);
        yield return 0;

        Debug.Log("Hello");
        Debug.Log("frameCount = " + Time.frameCount);
        yield return 0;

        Debug.Log("Hello");
        Debug.Log("frameCount = " + Time.frameCount);
        yield return 0;
    }
}
