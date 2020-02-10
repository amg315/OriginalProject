using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreEndSceneM : MonoBehaviour
{
    public enum GameState { PreEnd1, PreEnd2, PreEnd3, PreEnd4, PreEnd5, PreEnd6, PreEnd7, PreEnd8, PreEnd9, PreEnd10, PreEnd11, PreEnd12, PreEnd13, PreEnd14, PreEnd15, PreEnd16, PreEnd17, PreEnd18, PreEnd19, PreEnd20, PreEnd21, PreEnd22, PreEnd23, PreEnd24, PreEnd25, PreEnd26, PreEnd27 };
    public GameState currentGameState;

    public GameObject pe1;
    public GameObject pe2;
    public GameObject pe3;
    public GameObject pe4;
    public GameObject pe5;
    public GameObject pe6;
    public GameObject pe7;
    public GameObject pe8;
    public GameObject pe9;
    public GameObject pe10;
    public GameObject pe11;
    public GameObject pe12;
    public GameObject pe13;
    public GameObject pe14;
    public GameObject pe15;
    public GameObject pe16;
    public GameObject pe17;
    public GameObject pe18;
    public GameObject pe19;
    public GameObject pe20;
    public GameObject pe21;
    public GameObject pe22;
    public GameObject pe23;
    public GameObject pe24;
    public GameObject pe25;
    public GameObject pe26;
    public GameObject pe27;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.PreEnd1;
        ShowScreen(pe1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        pe1.SetActive(false);
        pe2.SetActive(false);
        pe3.SetActive(false);
        pe4.SetActive(false);
        pe5.SetActive(false);
        pe6.SetActive(false);
        pe7.SetActive(false);
        pe8.SetActive(false);
        pe9.SetActive(false);
        pe10.SetActive(false);
        pe11.SetActive(false);
        pe12.SetActive(false);
        pe13.SetActive(false);
        pe14.SetActive(false);
        pe15.SetActive(false);
        pe16.SetActive(false);
        pe17.SetActive(false);
        pe18.SetActive(false);
        pe19.SetActive(false);
        pe20.SetActive(false);
        pe21.SetActive(false);
        pe22.SetActive(false);
        pe23.SetActive(false);
        pe24.SetActive(false);
        pe25.SetActive(false);
        pe26.SetActive(false);
        pe27.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowPreEnd2()
    {
        currentGameState = GameState.PreEnd2;
        ShowScreen(pe2);
    }

    public void ShowPreEnd3()
    {
        currentGameState = GameState.PreEnd3;
        ShowScreen(pe3);
    }

    public void ShowPreEnd4()
    {
        currentGameState = GameState.PreEnd4;
        ShowScreen(pe4);
    }

    public void ShowPreEnd5()
    {
        currentGameState = GameState.PreEnd5;
        ShowScreen(pe5);
    }

    public void ShowPreEnd6()
    {
        currentGameState = GameState.PreEnd6;
        ShowScreen(pe6);
    }

    public void ShowPreEnd7()
    {
        currentGameState = GameState.PreEnd7;
        ShowScreen(pe7);
    }

    public void ShowPreEnd8()
    {
        currentGameState = GameState.PreEnd8;
        ShowScreen(pe8);
    }

    public void ShowPreEnd9()
    {
        currentGameState = GameState.PreEnd9;
        ShowScreen(pe9);
    }

    public void ShowPreEnd10()
    {
        currentGameState = GameState.PreEnd10;
        ShowScreen(pe10);
    }

    public void ShowPreEnd11()
    {
        currentGameState = GameState.PreEnd11;
        ShowScreen(pe11);
    }

    public void ShowPreEnd12()
    {
        currentGameState = GameState.PreEnd12;
        ShowScreen(pe12);
    }

    public void ShowPreEnd13()
    {
        currentGameState = GameState.PreEnd13;
        ShowScreen(pe13);
    }

    public void ShowPreEnd14()
    {
        currentGameState = GameState.PreEnd14;
        ShowScreen(pe14);
    }

    public void ShowPreEnd15()
    {
        currentGameState = GameState.PreEnd15;
        ShowScreen(pe15);
    }

    public void ShowPreEnd16()
    {
        currentGameState = GameState.PreEnd16;
        ShowScreen(pe16);
    }

    public void ShowPreEnd17()
    {
        currentGameState = GameState.PreEnd17;
        ShowScreen(pe17);
    }

    public void ShowPreEnd18()
    {
        currentGameState = GameState.PreEnd18;
        ShowScreen(pe18);
    }

    public void ShowPreEnd19()
    {
        currentGameState = GameState.PreEnd19;
        ShowScreen(pe19);
    }

    public void ShowPreEnd20()
    {
        currentGameState = GameState.PreEnd20;
        ShowScreen(pe20);
    }

    public void ShowPreEnd21()
    {
        currentGameState = GameState.PreEnd21;
        ShowScreen(pe21);
    }

    public void ShowPreEnd22()
    {
        currentGameState = GameState.PreEnd22;
        ShowScreen(pe22);
    }

    public void ShowPreEnd23()
    {
        currentGameState = GameState.PreEnd23;
        ShowScreen(pe23);
    }

    public void ShowPreEnd24()
    {
        currentGameState = GameState.PreEnd24;
        ShowScreen(pe24);
    }

    public void ShowPreEnd25()
    {
        currentGameState = GameState.PreEnd25;
        ShowScreen(pe25);
    }

    public void ShowPreEnd26()
    {
        currentGameState = GameState.PreEnd26;
        ShowScreen(pe26);
    }

    public void ShowPreEnd27()
    {
        currentGameState = GameState.PreEnd27;
        ShowScreen(pe27);
    }

    public void Ending()
    {
        SceneManager.LoadScene("End", LoadSceneMode.Single);
    }
}
