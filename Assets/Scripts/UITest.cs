using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    public Image img;
    public Button btn;
    public Slider slider;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        // Image 조작 - 색, 그림 X
        img.color = Color.white;
        img.color = new Color(0.5f, 0.5f, 0.5f);
        // img.sprite = null;

        // 버튼 조작 - 활성화, 이벤트 연결
        btn.interactable = true;
        btn.interactable = false;
        // btn.onClick.AddListener(함수);

        // 슬라이더 조작 - 활성화, min, max, value
        slider.interactable = true;
        slider.interactable = false;        
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.value = 50;

        // 텍스트
        text.text = "안녕하세요!";
        text.fontStyle = FontStyle.Bold;
        text.fontStyle = FontStyle.Italic;
        text.fontStyle = FontStyle.BoldAndItalic;
        text.fontSize = 30;
        text.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
