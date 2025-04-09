using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTest : MonoBehaviour
{
    // �ڵ带 ���� ������Ʈ ����
    // 1.����� ���� ���ҽ��� ����
    //   a. public ������ ���� ����
    //   b. �ڵ带 ���ؼ� �ε��ϴ� ��� - Resources
    // 2.������ ���ҽ��� ����

    public Transform target;
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate(effect, target.position + Vector3.back , effect.transform.rotation);

        // Resources.Load
        GameObject effectRes = Resources.Load<GameObject>("Particles/Hit_2");
        Instantiate(effectRes, target.position + Vector3.back, effect.transform.rotation);
    }
}
