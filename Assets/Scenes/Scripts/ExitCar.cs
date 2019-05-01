using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class ExitCar : MonoBehaviour
{
    public GameObject CarCamera;
    public GameObject Player;
    public GameObject ExitTrigger;
    public GameObject Car;
    public GameObject ExitLocation;

    

    private void Update()
    {
        if (Input.GetButtonDown("Action"))
        {
            Player.transform.position = ExitLocation.transform.position;
            Player.SetActive(true);           
            CarCamera.SetActive(false);
            Car.GetComponent<CarController>().enabled = false;
            Car.GetComponent<CarUserControl>().enabled = false;
            ExitTrigger.SetActive(false);
        }
    }
}
