using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIUserInfo : MonoBehaviour
{
    // UI - 플레이어
    public TMP_Text txtHPValue;
    public Slider sliderHp;

    public TMP_Text txtMPValue;
    public Slider sliderMp;

    public void Setup(int hp, int mp)
    {
        txtHPValue.text = hp.ToString();
        sliderHp.maxValue = hp;
        sliderHp.value = hp;

        txtMPValue.text = mp.ToString();
        sliderMp.maxValue = mp;
        sliderMp.value = mp;
    }

    // 플레이어의 체력이 변화
    // 플레이어의 마나가 변화
    public void ChangePlayerInfo(int hp, int mp)
    {
        txtHPValue.text = hp.ToString();
        sliderHp.value = hp;

        txtMPValue.text = mp.ToString();
        sliderMp.value = mp;
    }
}
