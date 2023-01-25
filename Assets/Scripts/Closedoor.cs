using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closedoor : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Fade();
        animator.SetTrigger("Door_Closing");

    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(5f);

    }
}
