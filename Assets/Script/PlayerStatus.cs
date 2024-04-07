using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int MP = 100; // �v���C���[�̏���MP��100�Ƃ���

    // MP������郁�\�b�h
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
