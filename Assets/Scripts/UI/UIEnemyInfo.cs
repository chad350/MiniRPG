using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIEnemyInfo : MonoBehaviour
{
    // UI - ���ʹ�
    public TMP_Text txtEnemyHpValue;
    public Slider sliderEnemyHp;

    public void Setup(int hp)
    {
        sliderEnemyHp.maxValue = hp;
        sliderEnemyHp.value = hp;
        txtEnemyHpValue.text = hp.ToString();
    }


    // ������ ü���� ��ȭ
    public void ChangeEnemyInfo(int hp)
    {
        // 
        txtEnemyHpValue.text = hp.ToString();
        sliderEnemyHp.value = hp;
    }
}
