using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    //[Header("移動速度")] [Range(0.1f, 10)]
    public static float speed = 3.1f;

    public Transform ground;


    /// <summary>
    /// 地板移動速度
    /// </summary>
    /// <param name="movespeed"></param>
    private void Move()
    {
        ground.Translate(-speed * Time.deltaTime, 0, 0);
    }




    private void Update()
    {
        Move();
    }

    


}
