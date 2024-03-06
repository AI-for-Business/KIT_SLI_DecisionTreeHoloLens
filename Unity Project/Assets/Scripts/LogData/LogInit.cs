using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class LogInit : MonoBehaviour
{
    public EventListener logger;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("logger init");
        //logger = new LogEventListener();
        //logger.EnableEvents(LogEventSource.Log, EventLevel.Informational);
        Debug.Log("is enabled logInit"+ LogEventSource.Log.IsEnabled());
        LogEventSource.Log.LoadSceneLog("logger start");
        //UtilityLogData.LoggerInit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
