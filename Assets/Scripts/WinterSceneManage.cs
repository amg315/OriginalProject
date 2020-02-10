using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinterSceneManage : MonoBehaviour
{
    public enum GameState { Winter1, Winter2, Winter3, Winter4, Winter5, Winter6, Winter7, Winter8, Winter9, Winter10, Winter11, Winter12, Winter13, Winter14 };
    public GameState currentGameState;

    public GameObject w1;
    public GameObject w2;
    public GameObject w3;
    public GameObject w4;
    public GameObject w5;
    public GameObject w6;
    public GameObject w7;
    public GameObject w8;
    public GameObject w9;
    public GameObject w10;
    public GameObject w11;
    public GameObject w12;
    public GameObject w13;
    public GameObject w14;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.Winter1;
        ShowScreen(w1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        w1.SetActive(false);
        w2.SetActive(false);
        w3.SetActive(false);
        w4.SetActive(false);
        w5.SetActive(false);
        w6.SetActive(false);
        w7.SetActive(false);
        w8.SetActive(false);
        w9.SetActive(false);
        w10.SetActive(false);
        w11.SetActive(false);
        w12.SetActive(false);
        w13.SetActive(false);
        w14.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowWinter2()
    {
        currentGameState = GameState.Winter2;
        ShowScreen(w2);
    }

    public void ShowWinter3()
    {
        currentGameState = GameState.Winter3;
        ShowScreen(w3);
    }

    public void ShowWinter4()
    {
        currentGameState = GameState.Winter4;
        ShowScreen(w4);
    }

    public void ShowWinter5()
    {
        currentGameState = GameState.Winter5;
        ShowScreen(w5);
    }

    public void ShowWinter6()
    {
        currentGameState = GameState.Winter6;
        ShowScreen(w6);
    }

    public void ShowWinter7()
    {
        currentGameState = GameState.Winter7;
        ShowScreen(w7);
    }

    public void ShowWinter8()
    {
        currentGameState = GameState.Winter8;
        ShowScreen(w8);
    }

    public void ShowWinter9()
    {
        currentGameState = GameState.Winter9;
        ShowScreen(w9);
    }

    public void ShowWinter10()
    {
        currentGameState = GameState.Winter10;
        ShowScreen(w10);
    }

    public void ShowWinter11()
    {
        currentGameState = GameState.Winter11;
        ShowScreen(w11);
    }

    public void ShowWinter12()
    {
        currentGameState = GameState.Winter12;
        ShowScreen(w12);
    }

    public void ShowWinter13()
    {
        currentGameState = GameState.Winter13;
        ShowScreen(w13);
    }

    public void ShowWinter14()
    {
        currentGameState = GameState.Winter14;
        ShowScreen(w14);
    }

    public void Ending()
    {
        SceneManager.LoadScene("PreEnd", LoadSceneMode.Single);
    }
}
