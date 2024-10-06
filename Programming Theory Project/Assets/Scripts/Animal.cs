using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION: The Animal class defines high-level animal behaviors without worrying about specifics.
public abstract class Animal : MonoBehaviour
{
    // INHERITANCE
    // Methods and variables that are common to all animals
    public string name;
    
    public void Eat()
    {
        Debug.Log(name + " is eating.");
    }

    // ABSTRACTION
    // Abstract methods and variables that will be defined by each animal
    public abstract int Legs { get; set; }

    public abstract float FoodPerformance { get; set; }

    public abstract void MakeSound();

    public abstract void Move();


    // ENCAPSULATION The health variable is encapsulated and only accessible through controlled method Feed
    // Encapsulated field
    private float health;

    void Start()
    {
        health = Random.Range(50f, 100f);
    }
    
    // Encapsulated health with controlled access
    public float Health
    {
        get { return health; }
        private set {}
    }

    // Public method to allow increasing health through feeding
    public void Feed(int foodAmount)
    {
        float newHealth = health + foodAmount * FoodPerformance;

        if (newHealth > 100f) {
            health = 100f;
        } else {
            health = newHealth;
        }

        Debug.Log(name + " is fed. Health level: " + health);
    }
}
