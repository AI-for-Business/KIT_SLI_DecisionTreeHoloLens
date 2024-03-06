using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventArgsLog : EventArgs
{
    public string m_eventArgsData;

    public EventArgsLog(string m)
    {
        this.m_eventArgsData = m;
    }

}
