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
        // �����l��ݒ�
        currentHP = maxHP;
        currentMP = maxMP;

        // UI�ɔ��f
        UpdateUI();
    }

    void UpdateUI()
    {
        hpText.text = "HP: " + currentHP.ToString() + " / " + maxHP.ToString();
        mpText.text = "MP: " + currentMP.ToString() + " / " + maxMP.ToString();
    }

    // HP�����炷���\�b�h
    public void TakeDamage(int damageAmount)
    {
        currentHP -= damageAmount;
        if (currentHP < 0)
        {
            currentHP = 0;
        }
        UpdateUI();
    }

    // MP������郁�\�b�h
    public void UseMP(int mpAmount)
    {
        currentMP -= mpAmount;
        if (currentMP < 0)
        {
            currentMP = 0;
        }
        UpdateUI();
    }

    // HP���񕜂��郁�\�b�h
    public void HealHP(int healAmount)
    {
        currentHP += healAmount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
        UpdateUI();
    }

    // MP���񕜂��郁�\�b�h
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
