using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class DeactivateCinemachine : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject player;
    public GameObject bonsai; 
    // Start is called before the first frame update
    void Start()
    {
        CinemachineBrain brain =  mainCamera.GetComponent<CinemachineBrain>();
        brain.enabled = false;
        mainCamera.gameObject.transform.position = new Vector3(0f, 1.01800001f, 2.45099998f);
        player.transform.LookAt(bonsai.transform.position, Vector3.up);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
