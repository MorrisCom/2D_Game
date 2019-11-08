using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuGuchicken : MonoBehaviour
{
    [Header("飛高高的高度哦")] [Range(30,1500)][Tooltip("放眼未來征服宇宙")]
    public int jump = 50;
    [Header("烤雞哦")]
    public bool death;
}
