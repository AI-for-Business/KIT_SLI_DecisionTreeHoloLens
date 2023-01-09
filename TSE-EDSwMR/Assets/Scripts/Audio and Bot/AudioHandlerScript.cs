using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
 * A way of timing the play of an clip exactly
 * 
 * PLAY SCHEDULED
 * how to queue a clip to play seamlessly after another clip has finished.
 *
 *     audioSource1.PlayScheduled(AudioSettings.dspTime);
 *     double clipLength = audioSource1.clip.samples / audioSource1.clip.frequency;
 *     audioSource2.PlayScheduled(AudioSettings.dspTime + clipLength);
 * 
 * 
 */



/// <summary>
/// To use this put some audio files (mp3 or WAV) in the Audio Clip Array.
/// </summary>
public class AudioHandlerScript : MonoBehaviour
{
    /*
     * To play something, an AudioSource in Unity is needed. Create a new AudioSource component
     */
    [SerializeField] AudioSource audioSourcePublic;
    [SerializeField] AudioClip[] audioClipArray;


  
    /// <summary>
    /// Play the clip with the index=arrayIndex from the array of AudioClips which is provided in the AudioHandler Component in Unity.
    /// </summary>
    /// <param name="arrayIndex"> Index of the clip in the Audio Clip Array </param>
    public void PlayAudioClipNr(int arrayIndex)
    {
        if (arrayIndex < audioClipArray.Length)
        {
            AudioClip clip = audioClipArray[arrayIndex];
            audioSourcePublic.clip = clip;
            audioSourcePublic.Play();
        }
        else
        {
            throw new System.IndexOutOfRangeException("AudioHandler clip index does not exist.");
        }

    }

    /// <summary>
    /// Play the provided AudioClip
    /// </summary>
    /// <param name="clip"></param>
    public void PlayGivenAudioClip(AudioClip clip)
    {
        audioSourcePublic.clip = clip;
        audioSourcePublic.Play();
    }


    /// <summary>
    /// Plays the clip form the AudioClip Array in the DataHandler with the given seconds of delay
    /// </summary>
    /// <param name="indexAudioClipArray"></param>
    /// <param name="secondsDelay"></param>
    public void PlayClipWithDelay(int indexAudioClipArray, float secondsDelay)
    {
        audioSourcePublic.clip = audioClipArray[indexAudioClipArray];
        audioSourcePublic.PlayDelayed(secondsDelay);
    }



    public bool isPlaying()
    {
        return audioSourcePublic.isPlaying;
    }

    public float DurationAudio(int clipNumber)
    {
        float clipLenght = 0;
        if (clipNumber < audioClipArray.Length)
        {
            AudioClip clip = audioClipArray[clipNumber];
            audioSourcePublic.clip = clip;


            clipLenght = audioSourcePublic.clip.samples / audioSourcePublic.clip.frequency;
        }

        return clipLenght;
    }

    public int GetAudioClipArrayLength()
    {
        return audioClipArray.Length;
    }

    /// <summary>
    /// This method stops audios while playing.
    /// </summary>
    public void StopAudio()
    {
        audioSourcePublic.Stop();
    }

}
