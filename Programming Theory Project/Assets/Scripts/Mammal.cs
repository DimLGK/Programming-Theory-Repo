using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mammal : Animal // INHERITANCE Mammal is sharing common behaviors but also implementing its own.
{
    protected int legs = 4;
    public override int Legs {
        get { return legs; }
        set { legs = value; }
    }
}
