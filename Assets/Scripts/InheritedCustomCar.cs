using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is inherited from base car class
/// </summary>
public class InheritedCustomCar : Car
{
    public InheritedCustomCar() {}
    public InheritedCustomCar(string name): base(name) { }

    protected override string GetName()
    {
        return "Car: " + base.GetName();
    }
}
