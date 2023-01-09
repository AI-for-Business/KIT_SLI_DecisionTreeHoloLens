using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightVersionM4 : Rebuild_DecisionTree
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnDataHandlerInit()
    {
        Debug.Log("Light version on init");

        StartCoroutine(LightVersion());
    }


    //public IEnumerator LightVersion()
    //{
    //    // Play Intro, then position frame show info_box dialog & frame, then put balls click away dialog (position dialog somewhere not in the way), the start intro for 
    //    // TODO plays entropy for definitions and then balls intro
    //    Debug.Log("Light version func 3");
    //    //info_box.SetActive(false);

    //    yield return new WaitForSeconds(2);
    //    Debug.Log("Light version func 4");

    //    m4AudioHandler.Intro_M4Light();

    //    yield return new WaitForSeconds(25);
    //    //info_box.SetActive(true);
    //    m4AudioHandler.PlaceFrame_M4Light();
    //    base.OnDataHandlerInit();
    //}


  
}
