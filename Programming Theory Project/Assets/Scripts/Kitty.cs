using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kitty : Mammal // INHERITANCE Kitty is sharing common behaviors but also implementing its own.
{
    private float foodPerformance = 0.8f;

    public override float FoodPerformance {
        get { return foodPerformance; }
        set { foodPerformance = value; }
    }

    public override void MakeSound() {
        Debug.Log(name + " meows!");
    }

    public override void Move() {
        Debug.Log(name + " runs with " + legs + " legs very fast and can jump very high!");  
    }
}
