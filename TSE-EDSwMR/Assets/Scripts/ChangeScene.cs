using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics.Tracing;

public class ChangeScene : MonoBehaviour
{

    public void LoadScene(string sceneName)
    {
        //LogEventSource.Log.LoadSceneLog(sceneName);

        SceneManager.LoadScene(sceneName);


        UtilityLogData.WriteLog(UtilityLogData.MESSAGE_LOG_START_SCENE + sceneName, true);


    }

}
