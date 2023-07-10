using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject ShopPanel;
    public GameObject LosePanel;
    public GameObject LoseBuyPanel;
    public GameObject HatShopPanel;

    public float FinishTime;
    public GameObject CharacterControllerEvent;

    public static int RandomSceneInt;

    private void Awake()
    {
        InvokeRepeating("isGameReturn", 0f, 0.2f);
        FinishTime = 1f;
        RandomSceneInt = Random.Range(0, SceneManager.sceneCountInBuildSettings);
    }

    public void isGameReturn()
    {
        if (PlayGame.isGame)
        {
            ShopPanel.SetActive(false);
            MainMenuPanel.SetActive(false);


            if(GameObject.FindGameObjectWithTag("Player") == null)
            {
                Invoke("LosePlayerMethod", 2f);
            }

        } 
    }


    private void Update()
    {
        if(Application.platform == RuntimePlatform.IPhonePlayer)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if(!LosePanel.activeSelf && !MainMenuPanel.activeSelf && ShopPanel.activeSelf)
                {
                    GoMainMenu();
                }

                else if (LosePanel.activeSelf && !MainMenuPanel.activeSelf && !ShopPanel.activeSelf)
                {
                    GoShopMenu();
                }
                else
                {
                    return;
                }



            }
        }
    }



    public void LosePlayerMethod()
    {
        LosePanel.SetActive(true);
        CharacterControllerEvent.SetActive(false);
    }

    public void GoMainMenu()
    {
        ShopPanel.SetActive(false);
        MainMenuPanel.SetActive(true);
        LoseBuyPanel.SetActive(false);
        HatShopPanel.SetActive(false);
    }

    public void GoShopMenu()
    {
        ShopPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
        LoseBuyPanel.SetActive(false);
        HatShopPanel.SetActive(false);
    }

    public void GoLosePanel()
    {
        ShopPanel.SetActive(false);
        MainMenuPanel.SetActive(false);
        LoseBuyPanel.SetActive(true);
        HatShopPanel.SetActive(false);
    }

    




}
