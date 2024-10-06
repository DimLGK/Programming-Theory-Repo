using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Mammal // INHERITANCE Dog is sharing common behaviors but also implementing its own.
{
    private float foodPerformance = 0.75f;

    public override float FoodPerformance {
        get { return foodPerformance; }
        set { foodPerformance = value; }
    }

    public override void MakeSound() {
        Debug.Log(name + " barks!");
    }

    public override void Move() {
        Debug.Log(name + " runs with " + legs + " legs fast enough!");  
    }
}
