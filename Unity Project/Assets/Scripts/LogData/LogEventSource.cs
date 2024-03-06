using System;
using System.Diagnostics.Tracing;
using UnityEngine;

sealed class LogEventSource : EventSource
{
    public static class Keywords
    {
        public const EventKeywords LoadScene = (EventKeywords)1;
        public const EventKeywords NoTimeStamp = (EventKeywords)2;
        public const EventKeywords Assessment = (EventKeywords)3;

        public static EventKeywords GetAll()
        {
            return LoadScene | NoTimeStamp | Assessment;
        }

    }
    public static class Tasks
    {
        public const EventTask LoadScene = (EventTask)1;    
        //public const EventTask 
    }


    //[Event(1, Message = "Application Failure: {0}", Level = EventLevel.Error, Keywords = Keywords.Diagnostic)]
    //public void Failure(string message) { WriteEvent(1, message); }

    //[Event(2, Message = "Starting up.", Keywords = Keywords.Perf, Level = EventLevel.Informational)]
    //public void Startup() { WriteEvent(2); }

    [Event(1, Message = "Loading Scene: {0}", Keywords = Keywords.LoadScene, Level = EventLevel.Informational)]
    public void LoadSceneLog(string sceneName)
    { 
        if (IsEnabled())
        {
            WriteEvent(1, sceneName, System.DateTime.Now.ToString());
            Debug.Log("load scene event enabled? " + Log.IsEnabled());
            Debug.Log(IsEnabled(EventLevel.Informational, Keywords.LoadScene));
        }
       
    }


    [Event(2, Message = "Assessment answers: {0}", Keywords = Keywords.Assessment, Level = EventLevel.Informational)]
    public void AssessmentResultLog(string answers) { WriteEvent(2, answers);
        if (IsEnabled())
        {
            Debug.Log("Assesement result event triggered");

        }
    }






    public static LogEventSource Log = new LogEventSource();

    
}
