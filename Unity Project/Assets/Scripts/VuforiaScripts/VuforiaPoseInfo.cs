using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VuforiaPoseInfo : MonoBehaviour
{

    public ObserverBehaviour mTarget;
    // Start is called before the first frame update

    bool now = true;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       if (now)
        {
            Debug.Log("gO.t.p: " + gameObject.transform.position + " mTarget.t.p: " + mTarget.transform.position);
            now = false;
            waiting();
        }

    }

    public void GetPose()
    {
        ObserverBehaviour obs = gameObject.GetComponent<ObserverBehaviour>();
        Debug.Log("obs=mTarget: "+ obs.Equals(mTarget) +"; gO.t.p: "+ gameObject.transform.position + " mTarget.t.p: " + mTarget.transform.position);
        
    
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(2);
        now = true;
    }

    
}
