using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaImageTargetFound : MonoBehaviour
{
    [SerializeField] private DecisionTreeHandler decisionTreeHandler;
    [SerializeField] private int imageTargetIndex;
    [SerializeField] private GameObject cross;

    //public ObserverBehaviour mTarget;

    private DefaultObserverEventHandler itEventHandler;


    private GameObject frame = null;
    private FrameHandler frameHandler;
    private static int nrDataPoints;

    private static bool newLayer;
    private static int counterNewLayerTrue = 0;

    void Update()
    {
        if (newLayer)
        {

            if (counterNewLayerTrue <= nrDataPoints)
            {
                counterNewLayerTrue++;
                FrameTargetBelongsTo();
            }
            else
            {
                newLayer = false;
                counterNewLayerTrue = 0;
            }
            

        }
    }

    public int GetIndexOfTarget()
    {
        return imageTargetIndex;
    }



    public void FrameTargetBelongsTo()
    {
        frame = decisionTreeHandler.DT_FrameWithDataPoint(imageTargetIndex);

        if (!(frame == null))
        {
            CrossOutSingular();
        }


    }

    public void CrossOutSingular()
    {

        if (!(frame == null))
        {
            frameHandler = frame.GetComponent<FrameHandler>();

            if (frameHandler.Singular())
            {

                cross.transform.parent = gameObject.transform.parent;
                cross.SetActive(true);
            }
            else if (cross.activeInHierarchy)
            {
                 //!frameHandler.Singular()
                cross.SetActive(false);

            }
        }

    }

    public static void NewLayerActivatedDT()
    {
        newLayer = true;
        nrDataPoints = DataHandler.data.Count;

    }

    private bool newLayerStillTrue()
    {
        //Debug.Log("Vuforia: newLayerStill true? new Layer: " + newLayer + " counter: " + counterNewLayerTrue + " nr dp: " + nrDataPoints);
        if (newLayer)
        {
            if (counterNewLayerTrue <= nrDataPoints)
            {
                return true;
            } else
            {
                newLayer = false;
                counterNewLayerTrue = 0;
                return false;
            }
        }
        return false;
    }

}
