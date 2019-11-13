using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
   [Header("這個是速度哦")][Range(0.1f,3)]
 public float speed = 1.5f;

    public Transform ground;

    private void Update()
    {
        ground.Translate(-speed, 0, 0);
    }

}
