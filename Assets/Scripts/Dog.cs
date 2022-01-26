using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    // POLYMORPHISM
    protected override void Talk()
    {
        Debug.Log("Woof");
    }
}
