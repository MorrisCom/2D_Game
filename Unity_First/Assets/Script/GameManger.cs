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

}
