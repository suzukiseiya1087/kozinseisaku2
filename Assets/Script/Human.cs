using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    public int MaxHP = 100;

    //�f���Q�[�g�̐錾
    //���������l���擾���邽�߂ɁA�ύX�O�̒l�������Ƃ��Ă��܂�
    public delegate void ValueChangedHandler(int preValue);
    //�����ɑΏۂ̒l���ω������Ƃ��̏�����ǉ����Ă���
    public event ValueChangedHandler HpChanged;

    void Start()
    {
        //HP���ω������Ƃ��ɌĂт������\�b�h��ǉ�
        //���\�b�h�𕡐��ǉ����邱�Ƃ��ł��܂�
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
                //�����œo�^�����f���Q�[�g���Ă΂��
                HpChanged(pre);
            }
        }
    }
    int currentHp = 100;
}
