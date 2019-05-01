using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth = 100f;
    public int damage = 5;
    public Collider playerhitbox;



    public void Start()
    {
        currentHealth = maxHealth;
    }


    public void ChangeHealth (int health)
    {
        currentHealth += health;
    }
 
    public void takeDamage()
    {
        currentHealth -= damage;
       
    }


    //private void OnCollisionEnter(Collider other)
    //{
        //if (other.gameObject.tag == "ENEMY")
        //{
            //takeDamage();

        //}
    //}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ENEMY")
        {
            takeDamage();
        }
    }
}
