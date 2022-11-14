using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalDistance : MonoBehaviour
{
    public Text distanceTrav;
    public DistanceManager distanceManager;

    void Update()
    {
        distanceTrav.text = Mathf.Round(distanceManager.distance) + "m";
    }
}
