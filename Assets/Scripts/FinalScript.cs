using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScript : MonoBehaviour
{
    public enum GameState { End1, End2, End3, End4, End5, End6 };
    public GameState currentGameState;

    public GameObject e1;
    public GameObject e2;
    public GameObject e3;
    public GameObject e4;
    public GameObject e5;
    public GameObject e6;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.End1;
        ShowScreen(e1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        e1.SetActive(false);
        e2.SetActive(false);
        e3.SetActive(false);
        e4.SetActive(false);
        e5.SetActive(false);
        e6.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowEnd2()
    {
        currentGameState = GameState.End2;
        ShowScreen(e2);
    }

    public void ShowEnd3()
    {
        currentGameState = GameState.End3;
        ShowScreen(e3);
    }

    public void ShowEnd4()
    {
        currentGameState = GameState.End4;
        ShowScreen(e4);
    }

    public void ShowEnd5()
    {
        currentGameState = GameState.End5;
        ShowScreen(e5);
    }

    public void ShowEnd6()
    {
        currentGameState = GameState.End6;
        ShowScreen(e6);
    }
}

    
