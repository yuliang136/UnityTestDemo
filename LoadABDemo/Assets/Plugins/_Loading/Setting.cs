using UnityEngine;
using System.Collections;

public class Setting {

    private static string reportErrorUrl = string.Empty;

    public static string REPORT_ERROR_URL
    {
        set
        {
            reportErrorUrl = value;
        }
        get
        {
            return reportErrorUrl;
        }
    }

    #if UNITY_EDITOR
	public static string FILEPATH = "file://" + Application.streamingAssetsPath;
	
	#elif UNITY_IPHONE
	public static string FILEPATH = "file://" + Application.streamingAssetsPath;
	
    #elif UNITY_ANDROID
	public static string FILEPATH = Application.streamingAssetsPath;
 
    #endif

    #if UNITY_EDITOR
	public static string PERSISTENT_PATH = "file:///" + Application.persistentDataPath;
	
	#elif UNITY_IPHONE
	public static string PERSISTENT_PATH = "file://" + Application.persistentDataPath;
	
    #elif UNITY_ANDROID
	public static string PERSISTENT_PATH = "file://" + Application.persistentDataPath;

    #endif
}
