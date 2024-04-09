using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStatus : MonoBehaviour
{
    public int maxHP = 100;
    public int currentHP;
    public int maxMP = 50;
    public int currentMP;

    public Text hpText;
    public Text mpText;

    void Start()
    {
        // 初期値を設定
        currentHP = maxHP;
        currentMP = maxMP;

        // UIに反映
        UpdateUI();
    }

    void UpdateUI()
    {
        hpText.text = "HP: " + currentHP.ToString() + " / " + maxHP.ToString();
        mpText.text = "MP: " + currentMP.ToString() + " / " + maxMP.ToString();
    }

    // HPを減らすメソッド
    public void TakeDamage(int damageAmount)
    {
        currentHP -= damageAmount;
        if (currentHP < 0)
        {
            currentHP = 0;
        }
        UpdateUI();
    }

    // MPを消費するメソッド
    public void UseMP(int mpAmount)
    {
        currentMP -= mpAmount;
        if (currentMP < 0)
        {
            currentMP = 0;
        }
        UpdateUI();
    }

    // HPを回復するメソッド
    public void HealHP(int healAmount)
    {
        currentHP += healAmount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
        UpdateUI();
    }

    // MPを回復するメソッド
    public void RestoreMP(int restoreAmount)
    {
        currentMP += restoreAmount;
        if (currentMP > maxMP)
        {
            currentMP = maxMP;
        }
        UpdateUI();
    }
}
