using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ���� 
    // ü��   : 100


    // �÷��̾�
    // MP : 50
    // ���� 1 : 20 <--
    // x
    
    // ���� 2 : 30 <--
    // mp 20 
    // �÷��̾��� MP �� 20 ���ϸ� ���� ��ü�� X

    public GameObject enemy;
    public int enemyHp = 100;

    
    int attackDamage1 = 20;
    int attackDamage2 = 30;

    public void Attack1()
    {
        enemyHp = enemyHp - attackDamage1;
        if (enemyHp <= 0)
        {
            Debug.Log("���͸� ��ҽ��ϴ�");
            Destroy(enemy);
        }
    }

    public void Attack2()
    {
        enemyHp = enemyHp - attackDamage2;
        if (enemyHp <= 0)
        {
            Debug.Log("���͸� ��ҽ��ϴ�");
            Destroy(enemy);
        }
    }
}
