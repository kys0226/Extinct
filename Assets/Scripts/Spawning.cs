using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject meteor;

    float span = 1.0f;
    float delta = 0;

    void Update()
    {

        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            // 프레임과 프레임 사이의 시간차(delta 변수), 합계 1초 이상이 되면 한 번씩 생성

            GameObject go = Instantiate(meteor) as GameObject;
            int px = Random.Range(-2, 20);  // x좌표는 -2부터 20사이에 불규칙하게 위치 


            go.transform.position = new Vector3(px, 7, 0);

        }
    }
}
