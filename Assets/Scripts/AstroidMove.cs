using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AstroidMove : MonoBehaviour
{
   
    void Update()
    {
        
        transform.Translate(-0.09f, -0.02f, 0); // 프레임마다 낙하

        if (transform.position.y < -5.0f)   // 화면 밖으로 나오면 오브젝트 소멸
        {
            Destroy(gameObject);
        }
    }

}
