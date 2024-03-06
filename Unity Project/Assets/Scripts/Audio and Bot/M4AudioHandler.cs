using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M4AudioHandler : MonoBehaviour

{

    private BotAndAudioScript botAndAudioScript;
    // Use this class to play audios for explanation of M4 Information Gain and Entropy

    public void Start()
    {
        if (botAndAudioScript == null) botAndAudioScript = GetComponent<BotAndAudioScript>();
    }

    public void ExplainEntropy()
    {
        if (botAndAudioScript != null) StartCoroutine(botAndAudioScript.PlayClipCoroutine(0));

    }
        
    public void ExplainIG()
    {
        if (botAndAudioScript != null) StartCoroutine(botAndAudioScript.PlayClipCoroutine(1));

    }

    public void ExplainID3()
    {
        if (botAndAudioScript != null) StartCoroutine(botAndAudioScript.PlayClipCoroutine(2));

    }

    public void Intro_M4Light()
    {      
        if (botAndAudioScript != null) StartCoroutine(botAndAudioScript.PlayClipCoroutine(3));
    }


    public void PlaceFrame_M4Light()
    {
        if (botAndAudioScript != null) StartCoroutine(botAndAudioScript.PlayClipCoroutine(4));

    }

    public void ExplanationTree_M4Light()
    {
        if (botAndAudioScript != null) StartCoroutine(botAndAudioScript.PlayClipCoroutine(5));

    }

}
