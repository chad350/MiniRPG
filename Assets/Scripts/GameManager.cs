using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 몬스터 
    // 체력   : 100
    // 공격력 : 20

    // 플레이어
    // 체력   : 100    
    // 공격 1 : 20 
    // mp 0
    // 공격 2 : 40 
    // mp 20 

    // 한번 공격을 하면 상대 몬스터가 공격을 할 것
    // 공격하고 나면 4초동안 다시 공격 X

    // 몬스터한테 애니메이션
    //    -  대기 모션
    //    -  공격 모션
    //    -  히트 모션
    //       - 파티클 추가    

    // 몬스터 잡으면
    //    - 메시지가 나오고 확인 버튼을 누르면 엔딩씬으로 넘어가기


    // 플레이어 정보
    public int playerHp; // 최대체력 저장 변수가 필요
    public int playerMp;
    public int[] playerAtk;
    public int[] playerCost;
   
    // 이펙트
    public string[] effectName;

    // 사운드
    public AudioSource[] audio;


    public bool canAttack = true;

    public Enemy enemy;
    public UIUserInfo uiUserInfo;

    private void Start()
    {
        uiUserInfo.Setup(playerHp, playerMp);
    }


    // Open Close <- 개방폐쇄 원칙
    public void Attack(int index)
    {
        int playerCost = this.playerCost[index];       
        int playerAtk = this.playerAtk[index]; 
        string effectName = this.effectName[index]; 
        AudioSource audio = this.audio[index]; 

        if (canAttack == false)
            return;

        if (playerMp < playerCost)
            return;

        playerMp -= playerCost;

        enemy.Hit(playerAtk);
        uiUserInfo.ChangePlayerInfo(playerHp, playerMp);

        audio.Play();

        GameObject effectRes = Resources.Load<GameObject>(effectName);
        Instantiate(effectRes, enemy.transform.position + Vector3.back, effectRes.transform.rotation);

        canAttack = false;
        // 4초 뒤에는 공격
        // Invoke
        Invoke(nameof(DelayReset), 4);
    }

    // 딜레이
    void DelayReset()
    {
        canAttack = true;
    }

    // 몬스터가 공격
    public void Hit(int damage)
    {
        playerHp -= damage;
        if (playerHp <= 0)
        {
            playerHp = 0;
            // 게임 오버
        }

        uiUserInfo.ChangePlayerInfo(playerHp, playerMp);
    }
}
