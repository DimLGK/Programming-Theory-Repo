using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public List<GameObject> animals;
    private List<Animal> _animals = new List<Animal>();

    void Start()
    {
        foreach (GameObject animal in animals) {
            _animals.Add(animal.GetComponent<Animal>());
        }

        Debug.Log($"{animals.Count} animals in the farm");
    }

    public void FeedAnimals()
    {
        int food = Random.Range(0, 10);

        // POLYMORPHISM  The class interacts with animals in a generic way (treating them all as Animal), but the actual methods executed depend on the specific animal type.
        foreach (Animal animal in _animals)
        {
            animal.Feed(food); // Each animal updates health differently
            animal.Eat(); // Each animal eats the same
        }
    }

    public void InteractWithAnimals()
    {
        // POLYMORPHISM  The class interacts with animals in a generic way (treating them all as Animal), but the actual methods executed depend on the specific animal type.
        foreach (Animal animal in _animals)
        {
            animal.Move();    // Each animal moves differently
            animal.MakeSound(); // Each animal makes its own sound
        }
    }
}
