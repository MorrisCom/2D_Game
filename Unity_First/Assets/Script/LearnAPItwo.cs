
using UnityEngine;

public class LearnAPItwo : MonoBehaviour
{
    //存放類別欄位
    public GuGuchicken gugu;

    private void Start()
    {
        //設定其他類別的欄位
        gugu.jump = 800;
        //取得其他類別的欄位
        print("小雞跳躍:" + gugu.jump);
        
    }
}
