using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacadeManager : MonoBehaviour
{
    UIManager uIManager;

    public void Awake()
    {
        uIManager = FindObjectOfType<UIManager>();
    }

    public void StartGame()
    {
        uIManager.StartUI();
    }

    public void LoseGame()
    {
        uIManager.LoseUI();
    }
}
