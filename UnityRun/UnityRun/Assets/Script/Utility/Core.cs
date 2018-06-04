using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static partial class Core 
{
    /// <summary>
    /// static function about scene
    /// </summary>
    /// <param name="Scene"></param>
    public static void Scene_LoadScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
    public static void Scene_LoadScene(int SceneBulldIndex)
    {
        SceneManager.LoadScene(SceneBulldIndex);
    }

    /// <summary>
    /// static function about application
    /// </summary>
    public static void Application_Quit()
    {
        Application.Quit();
    }
    public static SystemLanguage Application_SystemLanguage()
    {
        return Application.systemLanguage;
    }
    public static bool Application_NetworkCheck()
    {
        switch(Application.internetReachability)
        {
            case NetworkReachability.ReachableViaLocalAreaNetwork:
                return true;
            case NetworkReachability.ReachableViaCarrierDataNetwork:
                return true;
            default:
                return false;
        }
    }
    public static int Application_GetTargetFrameRate()
    {
        return Application.targetFrameRate;
    }
    public static void Application_SetTargetFrameRate(int FramesPerSecond)
    {
        Application.targetFrameRate = FramesPerSecond;
    }
}
