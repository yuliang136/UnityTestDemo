using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsUpdater : MonoBehaviour
{

    public Text fpsText;

    private int count;
    private float deltaTime;

    void Awake()
    {
        // QualitySettings.vSyncCount = 0;

        // Sync framerate to monitors refresh rate
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;

        Debug.Log("QualitySettings.vSyncCount = 0");
    }

    // Update is called once per frame
    void Update()
    {

        count++;
        deltaTime += Time.deltaTime;

        // 没过0.5s更新一次.
        if (deltaTime >= 0.5f)
        {
            // 经过的帧数 / 经过的时间
            var fps = count / deltaTime;

            count = 0;
            deltaTime = 0.0f;
            fpsText.text = $"FPS: {Mathf.Ceil(fps)}";
        }

    }
}
