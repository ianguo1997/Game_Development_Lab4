using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i = 3;  // 初始化整数变量

    void Start()
    {
        i = 3; // 游戏开始时，整数变量设置为3
    }

    void Update()
    {
        i++; // 每帧递增1
        Debug.Log(gameObject.name + ":" + i); // 打印游戏对象的名称和整数变量
    }
}

