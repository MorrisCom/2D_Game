using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuGuchicken : MonoBehaviour
{
   
    [Header("飛高高")] [Range(100,500)][Tooltip("放眼未來征服宇宙")]
    public int jump = 320;
    [Header("烤雞哦")]
    public bool death;

    public GameObject GoScore, GoGM;
    
    public float angle=5;

    public Rigidbody2D Rb2d;
    private void Update()
    {
        if (death) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GoScore.SetActive(true);
            GoGM.SetActive(true);
            Rb2d.Sleep();
            Rb2d.gravityScale=1;
            Rb2d.AddForce(new Vector2(0,jump));
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {        
            Rb2d.AddForce(new Vector2(0, -jump));
        }
        Rb2d.SetRotation(angle*Rb2d.velocity.y);

        
    }
    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void through()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print(collision.gameObject.name);
        flamebird();
        Rb2d.SetRotation(180);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        flamebird();
    }
    /// <summary>
    /// 是否變成烤雞
    /// </summary>
    private void flamebird()
    {
        death = true;
    }
    /// <summary>
    /// 小雞跳躍高度
    /// </summary>
    private void Gujump()
    {
    }
}
