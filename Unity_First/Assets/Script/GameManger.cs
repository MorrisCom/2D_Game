using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [Header("分數")]
    [Range(0, 9999)]
    public int score;
    [Header("最佳分數")][Range(0,9999)]
    public int bestscore;
  
    public GameObject pipe;

    /// <summary>
    /// 加分
    /// </summary>
    private void addscore()
    {
        
    }
    /// <summary>
    /// 最佳分數
    /// </summary>
    private void scoreheight()
    {

    }
    /// <summary>
    /// 遊戲結束
    /// </summary>
    private void GG()
    {
        
    }
    /// <summary>
    /// 生成水管的方法
    /// </summary>
    private void SpawnPipe()
    {
        //前面字體深綠色代表可省略
        //實例化、生成(物件)
        //Random.Range(1f, 5f);
        Vector3 R = new Vector3(7, Random.Range(-3f, 3.3f), 0);
        Instantiate(pipe,R,Quaternion.identity);
    }
    private void Start()
    {
        //SpawPipe();
        //延遲調用("方法名稱",延遲時間)
        //重複延遲調用("方法名稱",延遲時間,重複頻率)
        InvokeRepeating("SpawnPipe", 0, 2.5f);
      
    }
}
