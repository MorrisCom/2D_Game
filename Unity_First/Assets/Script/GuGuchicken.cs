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

    public GameManger Gm;

    public Rigidbody2D Rb2d;
    //音效區
    [Header("音效區域")]
    public AudioSource aud;
    public AudioClip Aud_jump;
    public AudioClip Aud_death;
    public AudioClip Aud_pass;

    private void Start()
    {
        Screen.SetResolution(450, 800, false);
    }
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
            aud.PlayOneShot(Aud_jump, 1.5f);
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {        
            Rb2d.AddForce(new Vector2(0, -jump));
            aud.PlayOneShot(Aud_jump, 1.5f);
        }
        Rb2d.SetRotation(angle*Rb2d.velocity.y);

        
    }
    /// <summary>
    /// 小雞通過水管
    /// </summary>
    private void through()
    {
        
    }
    /// <summary>
    /// 死掉時的碰撞
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print(collision.gameObject.name);
        flamebird();
        Rb2d.SetRotation(180);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name == ("水管_上") || collision.gameObject.name == ("水管_下"))
        {
            flamebird();
            Rb2d.SetRotation(180);
        }
    }
    /// <summary>
    /// 通過的方法
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == ("通過")&&!death)
        {
            //print("發大財");
            Gm.addscore();
            aud.PlayOneShot(Aud_pass, 1.5f);
            
        }
    }
    /// <summary>
    /// 是否變成烤雞
    /// </summary>
    private void flamebird()
    {
        if (death) return;
        aud.PlayOneShot(Aud_death, 1.5f);
        death = true;
        Gm.GG();
        Ground.speed = 0;
    }
    
    /// <summary>
    /// 小雞跳躍高度
    /// </summary>
    private void Gujump()
    {

    }
}
