using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTutorial : MonoBehaviour
{
    //wie schnell die Mausbewegung ausgeführt werden soll
    public float mousesensitivity = 200f;
    public Transform playerbody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //der Cursor wird in der Gameview festgehalten und unsichtbar
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    //nur für die Rotationsbewung der Kamera nach oben und unten
    void Update()
    {
        /* der Wert wie die Maus in x-Richtung bewegt wird, wird ausgelesen
        Time.deltaTime wird multipliziert, damit wir abhängig von der Framerate rotieren, gibt die vergangene Zeit an ab dem Zeitpunkt
        als update das letzte Mal aufgerufen wurde
        **/
        float mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;

        //für die rattion nach oben und unten, also um die x-Achse
        //Wert der Rotation
        xRotation -= mouseY;
        //kein überrotieren
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //für die Beweegung nach links und rechts
        //Rotation um den up-Vektor, also die y-Achse
        //so weit rotieren wie die Maus in x-Richtung bewegt wird
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
