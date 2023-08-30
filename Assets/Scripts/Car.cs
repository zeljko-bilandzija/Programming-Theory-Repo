using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    #region Consts

    private const int MAX_GEARS = 6;

    #endregion

    #region Properties
    // Example of encapsulation
    protected int Gear { get; set; }

    #endregion

    #region Protected variables

    protected bool isStarted;

    #endregion

    #region Private variables
    private string name = "Car";
    #endregion

    #region Constructors
    public Car() { }
    public Car(string name)
    {
        this.name = name;
    }
    #endregion

    #region Public methods
    public void StartCar()
    {
        isStarted = true;
    }

    public void TurnOffCar()
    {
        isStarted = false;
    }

    public void GearUp()
    {
        if (isStarted && Gear < MAX_GEARS)
        {
            Gear++;
        }
    }

    public void GearDown()
    {
        if (isStarted && Gear < MAX_GEARS)
        {
            Gear++;
        }
    }

    #endregion

    // Bad example of polymorphism
    protected virtual string GetName()
    {
        return name;
    }
}
