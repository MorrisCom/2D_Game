using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool open;

    public int score;

    public int combo;

    private void Start()
    {
        if (true)
        {
            print("哈囉");
        }

        if (open)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }

        if (score >= 60)
        {
            print("及格");
        }
        else if (score >= 40)
        {
            print("補考");
        }
        else
        {
            print("不及格");
        }

        if (combo < 50)
        {
            print("攻擊");
        }
        else if (combo < 100)
        {
            print("攻擊x2");
        }
        else if (combo < 150)
        {
            print("攻擊X5");
        }
        else
        {
            print("攻擊*10");
        }

    }
        
    
    
    
}
