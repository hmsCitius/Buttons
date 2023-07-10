using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ChangeCharacter : MonoBehaviour
{
    [SerializeField] private int UserCharacterInt;
    [SerializeField] private int MenuCharacterInt;
    [SerializeField] private TextMeshProUGUI PriceText;
    [SerializeField] private TextMeshProUGUI BuyAndSelectText;
    [SerializeField] private int PlayerCharacter;
    [SerializeField] private int PlayerMoney;
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private GameObject FailBuyPanel;

    public TextMeshProUGUI PlayerMoneyText;


    [Header("Character Open")]
    [SerializeField] private int userCharacter0;
    [SerializeField] private int userCharacter1;
    [SerializeField] private int userCharacter2;
    [SerializeField] private int userCharacter3;
    [SerializeField] private int userCharacter4;
    [SerializeField] private int userCharacter5;
    [SerializeField] private int userCharacter6;
    [SerializeField] private int userCharacter7;



    public GameObject CharacterHolderGameObject;
    public GameObject LockImage;


    private void Awake()
    {
        userCharacter0 = PlayerPrefs.GetInt("ischaracter0open", 1);
        userCharacter1 = PlayerPrefs.GetInt("ischaracter1open", 0);
        userCharacter2 = PlayerPrefs.GetInt("ischaracter2open", 0);
        userCharacter3 = PlayerPrefs.GetInt("ischaracter3open", 0);
        userCharacter4 = PlayerPrefs.GetInt("ischaracter4open", 0);
        userCharacter5 = PlayerPrefs.GetInt("ischaracter5open", 0);
        userCharacter6 = PlayerPrefs.GetInt("ischaracter6open", 0);
        userCharacter7 = PlayerPrefs.GetInt("ischaracter7open", 0);


        PlayerCharacter = PlayerPrefs.GetInt("playercharacter", 0);
        PlayerMoney = PlayerPrefs.GetInt("playermoney", 0);


        InvokeRepeating("ShowMenuElements", 0f, 0.2f);
    }


    


    public void NextMenuButton()
    {
        if (MenuCharacterInt < CharacterHolderGameObject.transform.childCount - 1)
        {
            MenuCharacterInt++;
        }
        else
        {
            MenuCharacterInt = 0;
        }        
    }

    public void BackMenuButton()
    {
        if (MenuCharacterInt > 0)
        {
            MenuCharacterInt--;
        }
        else
        {
            MenuCharacterInt = CharacterHolderGameObject.transform.childCount - 1;
        }
    }


    public void BuyButton()
    {
        PlayerMoney = PlayerPrefs.GetInt("playermoney", 0);
        switch (MenuCharacterInt)
        {
            case 0:
                if(userCharacter0 == 1)
                {
                    SelectCharacter(0);
                    GetComponent<Buttons>().GoMainMenu();
                }
                else
                {
                    if(PlayerMoney > 0)
                    {
                        PlayerMoney -= 1000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(0);
                        userCharacter0 = 1;
                        PlayerPrefs.SetInt("ischaracter0open", 1);
                        particle.Play();

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;
            case 1:
                if (userCharacter1 == 1)
                {
                    SelectCharacter(1);
                    GetComponent<Buttons>().GoMainMenu();

                }
                else
                {
                    if (PlayerMoney > 10000)
                    {
                        PlayerMoney -= 10000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(1);
                        userCharacter1 = 1;
                        PlayerPrefs.SetInt("ischaracter1open", 1);
                        particle.Play();

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;
            case 2:
                if (userCharacter2 == 1)
                {
                    SelectCharacter(2);
                    GetComponent<Buttons>().GoMainMenu();

                }
                else
                {
                    if (PlayerMoney > 15000)
                    {
                        PlayerMoney -= 15000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(2);
                        userCharacter2 = 1;
                        PlayerPrefs.SetInt("ischaracter2open", 1);
                        particle.Play();

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;
            case 3:
                if (userCharacter3 == 1)
                {
                    SelectCharacter(3);
                    GetComponent<Buttons>().GoMainMenu();

                }
                else
                {
                    if (PlayerMoney > 20000)
                    {
                        PlayerMoney -= 20000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(3);
                        userCharacter3 = 1;
                        PlayerPrefs.SetInt("ischaracter3open", 1);
                        particle.Play();

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;


            case 4:
                if (userCharacter4 == 1)
                {
                    SelectCharacter(4);
                    GetComponent<Buttons>().GoMainMenu();

                }
                else
                {
                    if (PlayerMoney > 20000)
                    {
                        PlayerMoney -= 20000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(4);
                        userCharacter4 = 1;
                        PlayerPrefs.SetInt("ischaracter4open", 1);
                        particle.Play();
                        

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;

            case 5:
                if (userCharacter5 == 1)
                {
                    SelectCharacter(5);
                    GetComponent<Buttons>().GoMainMenu();

                }
                else
                {
                    if (PlayerMoney > 20000)
                    {
                        PlayerMoney -= 20000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(5);
                        userCharacter5 = 1;
                        PlayerPrefs.SetInt("ischaracter5open", 1);
                        particle.Play();

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;

            case 6:
                if (userCharacter6 == 1)
                {
                    SelectCharacter(6);
                    GetComponent<Buttons>().GoMainMenu();

                }
                else
                {
                    if (PlayerMoney > 20000)
                    {
                        PlayerMoney -= 20000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(6);
                        userCharacter6 = 1;
                        PlayerPrefs.SetInt("ischaracter6open", 1);
                        particle.Play();

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;

            case 7:
                if (userCharacter7 == 1)
                {
                    SelectCharacter(7);
                    GetComponent<Buttons>().GoMainMenu();

                }
                else
                {
                    if (PlayerMoney > 20000)
                    {
                        PlayerMoney -= 20000;
                        PlayerPrefs.SetInt("playermoney", PlayerMoney);
                        SelectCharacter(7);
                        userCharacter7 = 1;
                        PlayerPrefs.SetInt("ischaracter7open", 1);
                        particle.Play();

                    }
                    else
                    {
                        GetComponent<Buttons>().GoLosePanel();
                    }

                }
                break;
        }
    }


    public void ParaArttir()
    {
        PlayerPrefs.SetInt("playermoney", PlayerPrefs.GetInt("playermoney") + 50000);
    }

    public void SelectCharacter(int selectint)
    {
        PlayerPrefs.SetInt("playercharacter", selectint);
        PlayerCharacter = selectint;
        Debug.Log("Kod calisiyor.");
        Debug.Log(PlayerCharacter);
    }





    public void ShowMenuElements()
    {
        PlayerMoneyText.text = PlayerPrefs.GetInt("playermoney",0)+"";


        


        switch (MenuCharacterInt)
        {
            case 0:
                int characterint = 0;

                if(userCharacter0 == 0)
                {
                    PriceText.text = 0 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }



                for(int i = 0; i<CharacterHolderGameObject.transform.childCount;i++)
                {
                    if(i == characterint)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;

            case 1:
                int characterint1 = 1;
                if (userCharacter1 == 0)
                {
                    PriceText.text = 10000 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }

                for (int i = 0; i < CharacterHolderGameObject.transform.childCount; i++)
                {
                    if (i == characterint1)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;

            case 2:
                int characterint2 = 2;
                if (userCharacter2 == 0)
                {
                    PriceText.text = 15000 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }

                for (int i = 0; i < CharacterHolderGameObject.transform.childCount; i++)
                {
                    if (i == characterint2)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;

            case 3:
                int characterint3 = 3;
                if (userCharacter3 == 0)
                {
                    PriceText.text = 20000 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }

                for (int i = 0; i < CharacterHolderGameObject.transform.childCount; i++)
                {
                    if (i == characterint3)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;

            case 4:
                int characterint4 = 4;
                if (userCharacter4 == 0)
                {
                    PriceText.text = 20000 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }

                for (int i = 0; i < CharacterHolderGameObject.transform.childCount; i++)
                {
                    if (i == characterint4)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;

            case 5:
                int characterint5 = 5;
                if (userCharacter5 == 0)
                {
                    PriceText.text = 20000 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }

                for (int i = 0; i < CharacterHolderGameObject.transform.childCount; i++)
                {
                    if (i == characterint5)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;

            case 6:
                int characterint6 = 6;
                if (userCharacter6 == 0)
                {
                    PriceText.text = 20000 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }

                for (int i = 0; i < CharacterHolderGameObject.transform.childCount; i++)
                {
                    if (i == characterint6)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;

            case 7:
                int characterint7 = 7;
                if (userCharacter7 == 0)
                {
                    PriceText.text = 20000 + "";
                    LockImage.SetActive(true);
                    BuyAndSelectText.text = "Buy";
                }
                else
                {
                    PriceText.text = "You Have";
                    LockImage.SetActive(false);
                    BuyAndSelectText.text = "Select";
                }

                for (int i = 0; i < CharacterHolderGameObject.transform.childCount; i++)
                {
                    if (i == characterint7)
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(true);
                    }
                    else
                    {
                        CharacterHolderGameObject.transform.GetChild(i).gameObject.SetActive(false);

                    }

                }
                break;
        }
    }

}
