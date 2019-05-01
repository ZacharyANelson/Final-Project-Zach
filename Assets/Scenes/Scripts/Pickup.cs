using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour


{
    public bool weaponEquipped;
    public GameObject weapon;
    public GameObject groundweapon;

    void Start()
    {
        weaponEquipped = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            weaponEquipped = false;
            weapon.SetActive(true);
            weaponEquipped = true;
            Object.Destroy(groundweapon);


        }
    }
}

