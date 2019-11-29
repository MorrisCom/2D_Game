using UnityEngine;

public class Pipe : Ground
{
    //掛腳本的物件要有Mesh renderer
    //在所有攝影機看不到時執行一次
    private void OnBecameInvisible()
    {
        Object.Destroy(gameObject, 1.0f);
    }
    //在所有攝影機看到時執行一次
    private void OnBecameVisible()
    {
        
    }
}
