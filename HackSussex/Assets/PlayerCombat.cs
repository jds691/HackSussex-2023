using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animation;
    public BoxCollider2D collision;
    private float cooldown;




    void Attack()
    {
        // Play an Attack animation
        // Detect enemies in range of attack
        // Damage them
        animation.SetTrigger("Swing");
        collision.enabled = true;
        cooldown = 0.16f;

    }

    // Update is called once per frame
    void Update()
    {
        cooldown -= Time.deltaTime;

        if (cooldown <= 0)
        {
            collision.enabled = false;
        }

         if (Input.GetKeyDown(KeyCode.F) && cooldown <= 0)
    {
        Attack();
    }

    }
}
