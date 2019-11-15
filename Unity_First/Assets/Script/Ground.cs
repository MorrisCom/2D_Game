using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [Header("這個是速度哦")] [Range(0.1f, 3)]
    public float speed = 1.5f;

    public Transform ground;


    /// <summary>
    /// 地板移動速度
    /// </summary>
    /// <param name="movespeed"></param>
    private void Move(float movespeed)
    {
      
    }




    private void Update()
    {
        ground.Translate(-speed, 0, 0);
    }

    


}
