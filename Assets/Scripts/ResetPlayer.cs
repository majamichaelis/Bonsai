using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject player;
    public GameObject bonsai;

    private Vector3 PLAYERPOS = new Vector3(0f, 1.01800001f, 2.45099998f);
    private Vector3 CAMPOS = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        player.gameObject.transform.position = PLAYERPOS;
        mainCamera.gameObject.transform.position = PLAYERPOS;
        player.transform.LookAt(bonsai.transform.position, Vector3.up);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
