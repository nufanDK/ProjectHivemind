﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameHUDController : MonoBehaviour
{

    public Color ImageColor;
    public GameObject OptionsMenu;
    public GameObject MainMenu;
    public GameObject ModifiersMenu;
    public GameObject PauseMenu;
    public GameObject InGameHUD;

    public BoolVariable InMainMenu;
    public SceneHandler SH;


    //public GameObject OptionsPanel;
    public BoolVariable GameIsPaused;

    GameObject uM;

    public void OnEnable()
    {
        Debug.Log("InMainMenu Value: " + InMainMenu.Value);
        string sceneName = "";
        if (SceneManager.GetActiveScene() != null)
        {
            sceneName = SceneManager.GetActiveScene().name;
        }
        Debug.Log("InMainMenu Value: " + InMainMenu.Value);
        InMainMenu.Value = sceneName.Contains("Menu");

        Debug.Log("InMainMenu Value: " + InMainMenu.Value);

        uM = GameObject.Find("UpdateManager");
        SetupAnimators(this.gameObject);
        SetupColors(InGameHUD);
        Debug.Log("InMainMenu Value: " + InMainMenu.Value);

        if (InMainMenu.Value)
        {
            Debug.Log("Im Not null.....");
            EnterMainMenu();
        }
        else
            EnterInGameHUD();


    }


    public void Pause()
    {
        Time.timeScale = 0;
        GameIsPaused.Value = true;
        uM.SetActive(false);
    }

    public void Unpause()
    {
        Time.timeScale = 1;
        GameIsPaused.Value = false;
        uM.SetActive(true);
    }

    public void SetupColors(GameObject go)
    {
        for (int i = 0; i < go.transform.childCount; i++)
        {
            SetupAnimators(go.transform.GetChild(i).gameObject);
        }

        foreach (Image img in go.GetComponentsInChildren<Image>())
        {

            img.color = ImageColor;
            Debug.Log("Found Image");
        }
    }
    public void SetupAnimators(GameObject go)
    {
        for (int i = 0; i < go.transform.childCount; i++)
        {
            SetupAnimators(go.transform.GetChild(i).gameObject);
        }

        foreach (Animator anim in go.GetComponentsInChildren<Animator>())
        {

            anim.updateMode = AnimatorUpdateMode.UnscaledTime;
            Debug.Log("Found animator: Updatemode = " + anim.updateMode);
        }
    }

    public void QuitButton()
    {
        Unpause();
        SceneManager.LoadScene("MainMenu");
    }

    // TrashCode
    public void NewGame()
    {
        InMainMenu.Value = false;
        SH.ChangeScene("ArenaGeneration");
    }

    public void BackButton()
    {
        if (InMainMenu.Value)
            EnterMainMenu();
    }

    // Change Menu
    public void EnterMainMenu()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
        ModifiersMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InGameHUD.SetActive(false);
    }
    public void EnterOptionsMenu()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
        ModifiersMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InGameHUD.SetActive(false);
    }
    public void EnterModifiersMenu()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        ModifiersMenu.SetActive(true);
        PauseMenu.SetActive(false);
        InGameHUD.SetActive(false);
    }
    public void EnterPauseMenu()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        ModifiersMenu.SetActive(false);
        PauseMenu.SetActive(true);
        InGameHUD.SetActive(false);
    }

    public void EnterInGameHUD()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(false);
        ModifiersMenu.SetActive(false);
        PauseMenu.SetActive(false);
        InGameHUD.SetActive(true);
    }

}
