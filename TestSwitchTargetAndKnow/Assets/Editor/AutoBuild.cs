using UnityEngine;
using System.Collections;
using UnityEditor;
using System;

public class AutoBuild
{
    [MenuItem("Tools/ActiveBuildTarget")]
    public static void ActiveBuildTarget()
    {
        EditorUserBuildSettings.activeBuildTargetChanged = delegate() {
			if(EditorUserBuildSettings.activeBuildTarget == BuildTarget.Android){
				Debug.Log("Switch to android Done!");
                Console.WriteLine("Switch to android Done!");
			}
		};

        EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTarget.Android);
    }
}
