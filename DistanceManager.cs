using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceManager : MonoBehaviour
{
    public Text distanceText;

    public float distance;

    public float pointsPerSec;

    public bool distanceIncreasing;

    void Start()
    {

    }

    void Update()
    {
        distance += pointsPerSec * Time.deltaTime;
        
        distanceText.text = "Distance: " + Mathf.Round(distance) + "m";

    }

}
