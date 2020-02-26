using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sensors;

public class TestSensors : MonoBehaviour
{

    public Button play;
    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(callSensorLibrary);
    }

    public void callSensorLibrary()
    {
        Sensors.Sensors sensor = new Sensors.Sensors();
        Debug.Log(sensor.printSensors());
    }
}