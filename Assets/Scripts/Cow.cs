using UnityEngine;

// INHERITANCE
public class Cow : Animal
{
    // POLYMORPHISM
    protected override void Talk()
    {
        Debug.Log("Moo");
    }
}
