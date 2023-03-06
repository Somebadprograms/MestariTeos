using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out FirstPersonController fpsCOntroller))
        {
            animator.SetBool("OpenDoor", true);
            Debug.Log("Collide with " + other.transform.name);
        }
    }
}
