using UnityEngine;

public class Script : MonoBehaviour
{
    // 程式內容
    // 宣告變數、定義欄位Field
    //修飾詞 欄位類型 欄位名稱 (指定 值) 結束
    //私人 - 隱藏 Private (預設)
    //公開 - 顯示 Public
    [Header("這個是大人的力量哦")]
    [Range(88, 888)]
    [Tooltip("發大財哦")]
    public int coin = 888;          //整數
    [Range(0.5f,15)]
    public float speed = 1.5f;       //浮點數
    public string prop = "綠色藥水";       //字串
    public bool dead = true;         //布林值
    //事件:在特定時間點以指定次數播放
    //開始:遊戲播放時執行一次
    private void Start()
    {
        print("你好,想發大財嗎");
    }
    private void Update()
    {
        print("發大財");
    }
}
