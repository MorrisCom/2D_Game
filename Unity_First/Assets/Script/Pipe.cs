using UnityEngine;

public class Pipe : Ground
{
 
    private void Start()
    {
        Object.Destroy(gameObject, 3.5f);
    }
}
