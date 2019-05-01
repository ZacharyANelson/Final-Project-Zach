using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class points : MonoBehaviour
{

    public Text pointsText;
    public int pointscount = 0;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = pointscount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointscount += 50;
            pointsText.text = pointscount.ToString();
        }
    }
}
