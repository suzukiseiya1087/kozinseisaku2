using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public int MaxHP = 100;

    //デリゲートの宣言
    //増減した値を取得するために、変更前の値を引数としています
    public delegate void ValueChangedHandler(int preValue);
    //ここに対象の値が変化したときの処理を追加していく
    public event ValueChangedHandler HpChanged;

    void Start()
    {
        //HPが変化したときに呼びたいメソッドを追加
        //メソッドを複数追加することもできます
        //human.HpChanged += OnHpChanged;
    }
    public int CurrentHP
    {
        get { return currentHp; }
        set
        {
            if (currentHp != value)
            {
                var pre = currentHp;
                currentHp = value;
                //ここで登録したデリゲートが呼ばれる
                HpChanged(pre);
            }
        }
    }
    int currentHp = 100;
}
