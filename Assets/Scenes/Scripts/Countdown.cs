using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour

    
{
    public float currentTime = 0f;
    public float startTime = 50f;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    void Start()

    {
        currentTime = startTime;    
    }

    // Update is called once per frame
    void Update()
    {
    currentTime -= 1 * Time.deltaTime;
        countdownText.text= currentTime.ToString();

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

    }
}
