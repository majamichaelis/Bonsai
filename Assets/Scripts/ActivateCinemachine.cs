using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ActivateCinemachine : MonoBehaviour
{
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        CinemachineBrain brain = mainCamera.GetComponent<CinemachineBrain>();
        brain.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
