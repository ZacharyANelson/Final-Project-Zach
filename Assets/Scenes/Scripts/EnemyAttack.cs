using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float mdistance;
    public float timer;
    public PlayerHealth phealth;
    public int dmg;

    private Transform myTransform;
    public Transform target;
    public
    void Start()
    {
       
        target = transform;
        myTransform = transform;
        mdistance = 3;
        timer = 0;
        dmg = -10;

        phealth = (PlayerHealth)GetComponent(typeof(PlayerHealth));

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, myTransform.position);
        if(distance < mdistance)
        {
            Attack();
        }
        if(timer > 0)
        {
            timer = timer - Time.deltaTime;
        }
        if (timer < 0)
        {
            timer = 0;
        }
    }
    void Attack()
    {
        Vector3 dir = Vector3.Normalize(target.position - myTransform.position);
        float direction = Vector3.Dot(dir, transform.forward);
        if(direction > 0)
        {
            if(timer == 0)
            {
                phealth.ChangeHealth(dmg);
                timer = 2;
            }
        }
    }
}
