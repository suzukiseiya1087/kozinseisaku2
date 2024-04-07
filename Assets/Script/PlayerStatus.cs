using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int MP = 100; // プレイヤーの初期MPを100とする

    // MPを消費するメソッド
    public bool ConsumeMP(int amount)
    {
        if (MP >= amount)
        {
            MP -= amount;
            return true;
        }
        return false;
    }
}
