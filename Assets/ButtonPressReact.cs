using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aButtonPressReact : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            animator.SetBool("d pressed", true);
        }
        else if (Input.GetKeyDown("a"))
        {
            animator.SetBool("a pressed", true);
        }
        else if (Input.GetKeyDown("space"))
        {
            animator.SetBool("space pressed", true);
        }
        else if (Input.GetKeyDown("q"))
        {
            animator.SetBool("q pressed", true);
        }
        else if (Input.GetKeyDown("e"))
        {
            animator.SetBool("e pressed", true);
        }
        if (Input.GetKeyUp("d"))
        {
            animator.SetBool("d pressed", false);
        }
        else if (Input.GetKeyUp("a"))
        {
            animator.SetBool("a pressed", false);
        }
        else if (Input.GetKeyUp("space"))
        {
            animator.SetBool("space pressed", false);
        }
        else if (Input.GetKeyUp("q"))
        {
            animator.SetBool("q pressed", false);
        }
        else if (Input.GetKeyUp("e"))
        {
            animator.SetBool("e pressed", false);
        }
    }
}
