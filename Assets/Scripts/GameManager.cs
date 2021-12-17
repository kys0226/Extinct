using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public GameObject menuPanel;
    public GameObject endPanel;
    public GameObject player;

    bool isMenu = false;
    bool isEnd = false;


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isMenu = !isMenu;
            if (isMenu == true)
            {
                Time.timeScale = 0; // 게임 일시정지
                menuPanel.SetActive(true);
            }
            else
            {
                Time.timeScale = 1; // 게임 다시 실행
                menuPanel.SetActive(false);
            }
        }

        if (player.activeSelf == false)
        {
            Time.timeScale = 0;
            endPanel.SetActive(true);
        }
        
    }
    

}