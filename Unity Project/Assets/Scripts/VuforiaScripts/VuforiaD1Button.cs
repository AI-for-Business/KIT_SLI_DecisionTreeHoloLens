using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VuforiaD1Button : MonoBehaviour
{
    public GameObject cube;
    public Material cubeHighlight;
    private void Start()
    {
        Debug.Log("Start Vuforia D1");
    }

    public void OnTargetFound()
    {
        Debug.Log("OnTargetFound");
        cube.GetComponent<MeshRenderer>().material = cubeHighlight;
    }
}
