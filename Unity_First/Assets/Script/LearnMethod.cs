using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnMethod : MonoBehaviour
{
    //宣告方法 - 定義方法Method
    //修飾詞 傳回類型 方法名稱()[陳述式、演算法]
    //private 只有此類別能使用此方法


    //自訂方法:不會執行、需要呼叫

    //void 無傳回
    private void Test()
    {
        print("測試方法");
    }
    //有傳回方法
    private string Hi()
    {
        return "阿囉哈~";
    }
    //傳回方法一定要有return並傳回相關資料
    private int Ten()
    {
        return 10;
    }
    
    private void SpeedMethod(int speed)//定義參數
    {
        //多個同樣語法時可使用
        print("引擎聲音");
        print("汽車速度" + speed);
    }
    //                 (參數1,參數2,參數="預設值")
    //                 有預設值的參數一定要寫在最後面
    private void Attack(int aspd,string type,int damage=30000)
    {
        print("攻擊速度:" + aspd);
        print("攻擊類型:" + type);
        print("攻擊傷害:" + damage);
    }

    private void Start()
    {
        //呼叫方法
        Test();
        int a = Ten();
        print("有傳回方法" + a);

        print("有傳回方法" + Ten());

        print("有傳回字串方法" + Hi());

        //同個語法不同速度
        SpeedMethod(55);
        SpeedMethod(155);
        //有預設值不用寫參數是可以的
        
        Attack(190, "雙刀");
        Attack(193, "拳刃", 350000);
    }


}
