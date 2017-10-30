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
}
