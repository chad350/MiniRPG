using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // ���� 
    // ü��   : 100
    // ���ݷ� : 20

    // �÷��̾�
    // ü��   : 100    
    // ���� 1 : 20 
    // mp 0
    // ���� 2 : 40 
    // mp 20 

    // �ѹ� ������ �ϸ� ��� ���Ͱ� ������ �� ��
    // �����ϰ� ���� 4�ʵ��� �ٽ� ���� X

    // �������� �ִϸ��̼�
    //    -  ��� ���
    //    -  ���� ���
    //    -  ��Ʈ ���
    //       - ��ƼŬ �߰�    

    // ���� ������
    //    - �޽����� ������ Ȯ�� ��ư�� ������ ���������� �Ѿ��


    // �÷��̾� ����
    public int playerHp; // �ִ�ü�� ���� ������ �ʿ�
    public int playerMp;
    public int[] playerAtk;
    public int[] playerCost;
   
    // ����Ʈ
    public string[] effectName;

    // ����
    public AudioSource[] audio;


    public bool canAttack = true;

    public Enemy enemy;
    public UIUserInfo uiUserInfo;

    private void Start()
    {
        uiUserInfo.Setup(playerHp, playerMp);
    }


    // Open Close <- ������� ��Ģ
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
        // 4�� �ڿ��� ����
        // Invoke
        Invoke(nameof(DelayReset), 4);
    }

    // ������
    void DelayReset()
    {
        canAttack = true;
    }

    // ���Ͱ� ����
    public void Hit(int damage)
    {
        playerHp -= damage;
        if (playerHp <= 0)
        {
            playerHp = 0;
            // ���� ����
        }

        uiUserInfo.ChangePlayerInfo(playerHp, playerMp);
    }
}
