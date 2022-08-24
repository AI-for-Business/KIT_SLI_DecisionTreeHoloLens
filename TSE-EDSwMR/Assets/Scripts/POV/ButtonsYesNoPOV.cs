using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script informs the State Script, which handels the current state of the POV Game, which button was clicked.
/// And destroys the buttons after the game is finished.
/// </summary>
public class ButtonsYesNoPOV : MonoBehaviour
{
    public GameObject buttons;

    public StateScriptPOV stateScript;

    // Start is called before the first frame update
    void Start()
    {
        buttons.SetActive(false);
        //StartCoroutine(TestButtons());
    }

    // Update is called once per frame
    void Update()
    {
        DestroyButtonsAfterGameFinished();
        if (buttons.activeInHierarchy == false && !stateScript.GetIntroIsPlaying())
        {
            buttons.SetActive(true);

        }

    }

   


    public void Yes_Clicked()
    {
        Debug.Log("Buttons: Yes clickd");

        stateScript.Yes_Clicked();

    }

    public void No_Clicked()
    {
        Debug.Log("Buttons: No clickd");

        stateScript.No_Clicked();

    }

    private void DestroyButtonsAfterGameFinished()
    {
        if (stateScript.GetFinishedGame())
        {
            Destroy(gameObject);

        }
    }


    //IEnumerator TestButtons()
    //{
    //    int i = 0;
    //    while(i<4)
    //    {
    //        stateScript.Yes_Clicked();
    //        yield return new WaitForSeconds(2);
    //    }
    //}
}