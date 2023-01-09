using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics.Tracing;
using System;

public class LogEventListener : EventListener
{

    protected override void OnEventSourceCreated(System.Diagnostics.Tracing.EventSource eventSource)
    {
        base.OnEventSourceCreated(eventSource);
        Debug.Log("EventListener OnEventSourceCreated: " + eventSource.Name);
        
        //this.EnableEvents(eventSource, EventLevel.Informational);
        //this.EnableEvents(LogEventSource.Log, EventLevel.Informational, LogEventSource.Keywords.LoadScene);
        //base.EnableEvents(eventSource, EventLevel.Informational, LogEventSource.Keywords.LoadScene);

        Debug.Log("is enabled "+eventSource.IsEnabled());
        Debug.Log("is enable specific "+eventSource.IsEnabled(EventLevel.Informational, EventKeywords.All));

        // EventLevel.LogAlways enables all events.
    }

    protected override void OnEventWritten(EventWrittenEventArgs eventData)
    {
        Debug.Log("EventListener OnEventWritten" + eventData.Message);
        UtilityLogData.WriteLog(eventData.Message + " !!!Log from Listener", false);
    }

}
