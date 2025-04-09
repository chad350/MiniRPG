using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTest : MonoBehaviour
{
    // 코드를 통한 오브젝트 생성
    // 1.만들고 싶은 리소스에 접근
    //   a. public 변수로 만들어서 연결
    //   b. 코드를 통해서 로드하는 방법 - Resources
    // 2.선택한 리소스를 생성

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
