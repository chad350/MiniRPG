using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManager : MonoBehaviour
{
    // 첫번째
    // 변수 만들기
    // int, flaot, stirng, bool  
    // GameObject, Transform, Color, Vector
    public GameObject cube;
    public GameObject light;

    public MeshRenderer ground;

    public Color lightColor;


    // 두번째
    // 함수 만들기
    void Start()
    {
        // cube.SetActive(true);
        // cube.SetActive(false);

        // Instantiate(cube); // 생성, 복사
        // Destroy(cube);

        // 제네릭 - 고급기법
        cube.GetComponent<Rigidbody>().mass = 1000;
        cube.GetComponent<Rigidbody>().useGravity = false;
    }

    public void CubeOn()
    {
        cube.SetActive(true);
    }

    public void CubeOff()
    {
        cube.SetActive(false);
    }

    public void SetGroundColor()
    {
        ground.material.color = Color.red;
    }

    public void SetLightColor()
    {
        // Color  0 ~ 1
        light.GetComponent<Light>().color = lightColor;
    }
}
