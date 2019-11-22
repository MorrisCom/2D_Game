
using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 55, b = 6;
    public int c = 3, d = 9;
    private void Start()
    {
        #region
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        a = a + 1;
        print(a);
        print(a++);//先輸出a再遞增
        print(++a);//先遞增再輸出
        print(b--);
        print(--b);
        #endregion
        print(b += 10);
        #region 比較運算子
        print(c > d);  //true 大於
        print(c <d);   //flase  小於      
        print(c >= d);  //true      大於等於    
        print(c <= d);  //flase     小於等於
        print(c == d);  //flase     等於
        print(c != d);  //true     不等於
        #endregion
        #region  邏輯運算子
        //&& 並且 shift+7
        //只要有一個false結果就是false
        print(true && true);
        print(true && false);
        print(false && true);
        print(false && true);
        // || 或者 shift+\
        // 只要有一個 true 結果就是 true
        print(true || true); //t
        print(true || false); //t
        print(false || true); //t
        print(false || false); //f
        // 相反!
        print(!true);
        #endregion


    }

}
