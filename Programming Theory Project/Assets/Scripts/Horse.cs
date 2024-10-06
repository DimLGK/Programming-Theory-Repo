using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Horse : Mammal // INHERITANCE Horse is sharing common behaviors but also implementing its own.
{
    private float foodPerformance = 0.5f;

    public override float FoodPerformance {
        get { return foodPerformance; }
        set { foodPerformance = value; }
    }

    public override void MakeSound() {
        Debug.Log(name + " neighs!");
    }

    public override void Move() {
        Debug.Log(name + " runs with " + legs + " legs very very fast!");  
    }
}
