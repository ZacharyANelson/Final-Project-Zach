using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class EnterCar : MonoBehaviour

{
    public GameObject CarCamera;
    public GameObject Player;
    public GameObject ExitTrigger;
    public GameObject Car;
    public int TriggerCheck;

    
    


    private void OnTriggerEnter(Collider col)
    {
        TriggerCheck = 1;
    }

    private void OnTriggerExit(Collider col)
    {
        TriggerCheck = 0;
    }

    private void Update()
    {
        if (TriggerCheck == 1)
        {
            if(Input.GetButtonDown("Action"))
            {
                CarCamera.SetActive(true);
                Player.SetActive(false);
                Car.GetComponent<CarController>().enabled = true;
                Car.GetComponent<CarUserControl>().enabled = true;
                ExitTrigger.SetActive(true);
            }
        }
    }
}
