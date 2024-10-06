using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal // INHERITANCE Chicken is sharing common behaviors but also implementing its own.
{
    private int legs = 2;
    public override int Legs {
        get { return legs; }
        set { legs = value; }
    }

    private float foodPerformance = 0.6f;

    public override float FoodPerformance {
        get { return foodPerformance; }
        set { foodPerformance = value; }
    }

    public override void MakeSound() {
        Debug.Log(name + " clucks!");
    }

    public override void Move() {
        Debug.Log(name + " runs with " + legs + " legs slowly!");  
    }
}
