using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 몬스터 
    // 체력   : 100


    // 플레이어
    // MP : 50
    // 공격 1 : 20 <--
    // x
    
    // 공격 2 : 30 <--
    // mp 20 
    // 플레이어의 MP 가 20 이하면 실행 자체가 X

    public GameObject enemy;
    public int enemyHp = 100;

    
    int attackDamage1 = 20;
    int attackDamage2 = 30;

    public void Attack1()
    {
        enemyHp = enemyHp - attackDamage1;
        if (enemyHp <= 0)
        {
            Debug.Log("몬스터를 잡았습니다");
            Destroy(enemy);
        }
    }

    public void Attack2()
    {
        enemyHp = enemyHp - attackDamage2;
        if (enemyHp <= 0)
        {
            Debug.Log("몬스터를 잡았습니다");
            Destroy(enemy);
        }
    }
}
