using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : MonoBehaviour
{

    public AudioSource deathAudio;
    public AudioSource arrowAudio;

    private int HP = 60;
    public Slider healthBar;
    public Animator animator;
    
    void Update()
    {
        healthBar.value = HP;
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;

        if(HP <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            deathAudio.Play();
        }
        else
        {
            animator.SetTrigger("damage");
            arrowAudio.Play();
        }
    }
}
