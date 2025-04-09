using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // ��� <- ������ �ʴ� ������
    const string AttackTrigger = "Attack";
    const string HitTrigger = "Hit";
    const string DieTrigger = "Die";

    // ���� <- ���ϴ� ������
    public GameManager gm;
    public UIEnemyInfo uIEnemyInfo;
    public UIClearPopup uiClearPopup;

    // ���ʹ� ����
    // ���ʹ� �ִϸ��̼� �̸�
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
