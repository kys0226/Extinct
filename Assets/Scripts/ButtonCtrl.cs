using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCtrl : MonoBehaviour
{
    public GameObject MenuPanel;

    public void OptionConfirm()
    {
        MenuPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void OptionOpen()
    {
        MenuPanel.SetActive(true);
        Time.timeScale = 0;
    }

    
}
