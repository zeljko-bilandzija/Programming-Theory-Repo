using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    private Car car;
    private InheritedCustomCar bmw;
    // Start is called before the first frame update
    void Start()
    {
        car = new Car();
        bmw = new InheritedCustomCar("Bmw");
        bmw.StartCar();
        bmw.GearUp();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
