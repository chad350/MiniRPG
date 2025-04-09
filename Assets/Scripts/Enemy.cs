using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 상수 <- 변하지 않는 데이터
    const string AttackTrigger = "Attack";
    const string HitTrigger = "Hit";
    const string DieTrigger = "Die";

    // 변수 <- 변하는 데이터
    public GameManager gm;
    public UIEnemyInfo uIEnemyInfo;
    public UIClearPopup uiClearPopup;

    // 에너미 정보
    // 에너미 애니메이션 이름
    public Animator enemyAnimator;
    public int enemyHp;
    public int enemyAtk;


    private void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        uIEnemyInfo.Setup(enemyHp);
    }

    public void MonsterAttak()
    {
        enemyAnimator.SetTrigger(AttackTrigger);
        gm.Hit(enemyAtk);
    }

    public void Hit(int damage)
    {
        enemyAnimator.SetTrigger(HitTrigger);

        enemyHp -= damage;
        if (enemyHp <= 0)
        {
            enemyAnimator.SetTrigger(DieTrigger);
            enemyHp = 0;
            uiClearPopup.gameObject.SetActive(true);
        }

        Invoke(nameof(MonsterAttak), 2);
        uIEnemyInfo.ChangeEnemyInfo(enemyHp);
    }
}
