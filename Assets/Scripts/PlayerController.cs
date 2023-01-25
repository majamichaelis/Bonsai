using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Die Kamera ist ein Kindelement des Players, also bewegt sie sich mit dem Player mit

    public CharacterController controller;
    public float speed = 12f;

    float y;

    // Start is called before the first frame update
    void Start()
    {
        y = transform.position.y;
    }

    // Update is called once per frame
    //nur für die Bewegung nach vorne, hinten, rechts und links
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Bewegung nach links und rechts + die Bewegung nach hinten und vorne
        Vector3 move = transform.right * x + transform.forward * z;
        move.y = 0;

        //Time.deltaTime wird multipliziert, damit wir abhängig von der Framerate rotieren, gibt die vergangene Zeit an ab dem Zeitpunkt
        //als update das letzte Mal aufgerufen wurde
        controller.Move(move * speed * Time.deltaTime);
        
    }
}
