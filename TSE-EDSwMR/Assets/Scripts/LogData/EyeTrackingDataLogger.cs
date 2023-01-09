using Microsoft.MixedReality.Toolkit.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * Attach focushandler to game object that should be tracked
 */
public class EyeTrackingDataLogger : MonoBehaviour, IMixedRealityFocusHandler
{

    string extraInformation = null;
    string lastFocusMessage;
    // Start is called before the first frame update
    void Start()
    {
        //TO DO get activated with each dialog
        Debug.Log("start eye tracking");
    }


    void IMixedRealityFocusHandler.OnFocusEnter(FocusEventData eventData)
    {
        // only if the object is a dialog how???? Also other things
        Debug.Log("OnFocusEnter");
       
    
        string name = eventData.NewFocusedObject.name;
        string parentName = eventData.NewFocusedObject.transform.parent.name;
        Debug.Log("extra information: "+extraInformation);
        //UtilityLogData.WriteLog(UtilityLogData.MESSAGE_LOG_EYETRACKING + name + ", parent name: " + parentName  + " " + extraInformation ?? "" , true);
        if (extraInformation != null)
        {
            lastFocusMessage = extraInformation;
            UtilityLogData.WriteLog(UtilityLogData.MESSAGE_LOG_EYETRACKING + extraInformation, true);

        }
        else
        {
            lastFocusMessage = parentName; 
            UtilityLogData.WriteLog(UtilityLogData.MESSAGE_LOG_EYETRACKING + parentName, true);

        }

    }

    void IMixedRealityFocusHandler.OnFocusExit(FocusEventData eventData)
    {
        Debug.Log("OnFocusExit");
        //string nam1e = eventData.NewFocusedObject.GetHashCode().ToString(); // leads to nullpointer

        UtilityLogData.WriteLog(UtilityLogData.MESSAGE_LOG_EYETRACKING_END + lastFocusMessage, true);
    }

    public void SetExtraInformation(string message)
    {
        extraInformation = message;
    }
}
