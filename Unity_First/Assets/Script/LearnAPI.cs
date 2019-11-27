using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    private void Start()
    {
        Debug.Log ("正常喔");
        Debug.LogWarning("打錯了");
        

        Debug.Log(Mathf.PI);
        //靜態方法 static properties
        Debug.Log(Random.value);//隨機浮點數
        //靜態方法 static method
        Debug.Log(Random.Range(1, 10));

       
    }
    //
    private void Update()
    {
        //類別.靜態方法(對應引數)
        print(Input.GetKeyDown("mouse 0"));         //字串取得按鈕
        print(Input.GetKeyDown(KeyCode.Mouse0));    //列舉取得按鈕
    }

}
