using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightController : MonoBehaviour
{

    public GameObject redLight, yellowLight, greenLight;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TrafficLight());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TrafficLight()
    {
        while(true)
        {
            greenLight.SetActive(false);
            redLight.SetActive(true);
            yield return new WaitForSeconds(3);
            redLight.SetActive(false);
            yellowLight.SetActive(true);
            yield return new WaitForSeconds(3);
            yellowLight.SetActive(false);
            greenLight.SetActive(true);
            yield return new WaitForSeconds(3);
        }
    }
}
