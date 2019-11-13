using UnityEngine;

public class LearnAPI : MonoBehaviour
{
    private void Start()
    {
        Debug.Log ("正常喔");
        Debug.LogWarning("打錯了");
        

        Debug.Log(Mathf.PI);
        //靜態方法 static properties
        Debug.Log(Random.value);
        //靜態方法 static method
        Debug.Log(Random.Range(1, 10));
    }
    
}
