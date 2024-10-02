using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dying : MonoBehaviour
{
    public Animator animator;
    public GameObject animatedObject;
    void Start()
    {
        animatedObject.SetActive(true);
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown("e")) { animator.SetBool("Dying", true); }
        if (Input.GetKeyDown("w")) { animator.SetBool("Dying", false); }
        if (Input.GetKeyDown("x")) { animator.SetBool("Praying", true); }
        if (Input.GetKeyDown("z")) { animator.SetBool("Praying", false); }
    }
}
