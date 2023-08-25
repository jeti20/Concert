using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollON : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Weapon"))
        {
            if (animator != null)
            {
                animator.enabled = false;
            }
        }
    }
}
