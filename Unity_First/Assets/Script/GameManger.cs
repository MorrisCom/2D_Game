using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManger : MonoBehaviour
{
    [Header("分數")]
    [Range(0, 9999)]
    public int score;
    [Header("最佳分數")][Range(0,9999)]
    public int bestscore;
     [Header("生成水管")]
    public GameObject pipe;
    public GameObject Gofinal;
    public Text textscore;
    public Text textHeight;
    /// <summary>
    /// 加分
    /// </summary>
    public void addscore(int add=35)
    {
        //print("35");
        score = score + add;
        textscore.text = score.ToString();//Tostring讓數字可以貼在文字介面
        SetHeightScore();
    }
    /// <summary>
    /// 最佳分數
    /// </summary>
    private void SetHeightScore()
    {
        if (score>bestscore)
        {
            PlayerPrefs.SetInt("最佳分數", score);
        }
        //PlayerPrefs.SetInt("最佳分數", score);
    }
    /// <summary>
    /// 遊戲結束
    /// </summary>
    public void GG()
    {
        Gofinal.SetActive(true);
        CancelInvoke("SpawnPipe");
    }
    /// <summary>
    /// 生成水管的方法
    /// </summary>
    private void SpawnPipe()
    {
        //前面字體深綠色代表可省略
        //實例化、生成(物件)
        //Random.Range(1f, 5f);
        Vector3 R = new Vector3(7, Random.Range(-3f, 2.7f), 0);
        Instantiate(pipe,R,Quaternion.identity);
    }
    public void Replay()
    {
        //print("重新開始");
        SceneManager.LoadScene("GameScene");
    }
    public void Exit()
    {
        //print("離開遊戲");
        Application.Quit();
    }
    private void Start()
    {
        //SpawPipe();
        //延遲調用("方法名稱",延遲時間)
        //重複延遲調用("方法名稱",延遲時間,重複頻率)
        InvokeRepeating("SpawnPipe", 0, 3.0f);

        bestscore = PlayerPrefs.GetInt("最佳分數");
        textHeight.text = bestscore.ToString();
    }
}
