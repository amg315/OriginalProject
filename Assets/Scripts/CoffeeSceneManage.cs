using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffeeSceneManage : MonoBehaviour
{
    public enum GameState { CoffeePart1, CoffeePart2, CoffeePart3, CoffeePart4, CoffeePart5, CoffeePart6, CoffeePart7, CoffeePart8, CoffeePart9, CoffeePart10, CoffeePart11, CoffeePart12, CoffeePart13, CoffeePart14, CoffeePart15, CoffeePart16, CoffeePart17, CoffeePart18, CoffeePart19, CoffeePart20, CoffeePart21, CoffeePart22, CoffeePart23, CoffeePart24};
    public GameState currentGameState;

    public GameObject coffee1;
    public GameObject coffee2;
    public GameObject coffee3;
    public GameObject coffee4;
    public GameObject coffee5;
    public GameObject coffee6;
    public GameObject coffee7;
    public GameObject coffee8;
    public GameObject coffee9;
    public GameObject coffee10;
    public GameObject coffee11;
    public GameObject coffee12;
    public GameObject coffee13;
    public GameObject coffee14;
    public GameObject coffee15;
    public GameObject coffee16;
    public GameObject coffee17;
    public GameObject coffee18;
    public GameObject coffee19;
    public GameObject coffee20;
    public GameObject coffee21;
    public GameObject coffee22;
    public GameObject coffee23;
    public GameObject coffee24;

    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.CoffeePart1;
        ShowScreen(coffee1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        coffee1.SetActive(false);
        coffee2.SetActive(false);
        coffee3.SetActive(false);
        coffee4.SetActive(false);
        coffee5.SetActive(false);
        coffee6.SetActive(false);
        coffee7.SetActive(false);
        coffee8.SetActive(false);
        coffee9.SetActive(false);
        coffee10.SetActive(false);
        coffee11.SetActive(false);
        coffee12.SetActive(false);
        coffee13.SetActive(false);
        coffee14.SetActive(false);
        coffee15.SetActive(false);
        coffee16.SetActive(false);
        coffee17.SetActive(false);
        coffee18.SetActive(false);
        coffee19.SetActive(false);
        coffee20.SetActive(false);
        coffee21.SetActive(false);
        coffee22.SetActive(false);
        coffee23.SetActive(false);
        coffee24.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowPart2()
    {
        currentGameState = GameState.CoffeePart2;
        ShowScreen(coffee2);
    }

    public void ShowPart3()
    {
        currentGameState = GameState.CoffeePart3;
        ShowScreen(coffee3);
    }

    public void ShowPart4()
    {
        currentGameState = GameState.CoffeePart4;
        ShowScreen(coffee4);
    }

    public void ShowPart5()
    {
        currentGameState = GameState.CoffeePart5;
        ShowScreen(coffee5);
    }

    public void ShowPart6()
    {
        currentGameState = GameState.CoffeePart6;
        ShowScreen(coffee6);
    }

    public void ShowPart7()
    {
        currentGameState = GameState.CoffeePart7;
        ShowScreen(coffee7);
    }

    public void ShowPart8()
    {
        currentGameState = GameState.CoffeePart8;
        ShowScreen(coffee8);
    }

    public void ShowPart9()
    {
        currentGameState = GameState.CoffeePart9;
        ShowScreen(coffee9);
    }

    public void ShowPart10()
    {
        currentGameState = GameState.CoffeePart10;
        ShowScreen(coffee10);
    }

    public void ShowPart11()
    {
        currentGameState = GameState.CoffeePart11;
        ShowScreen(coffee11);
    }

    public void ShowPart12()
    {
        currentGameState = GameState.CoffeePart12;
        ShowScreen(coffee12);
    }

    public void ShowPart13()
    {
        currentGameState = GameState.CoffeePart13;
        ShowScreen(coffee13);
    }

    public void ShowPart14()
    {
        currentGameState = GameState.CoffeePart14;
        ShowScreen(coffee14);
    }

    public void ShowPart15()
    {
        currentGameState = GameState.CoffeePart15;
        ShowScreen(coffee15);
    }

    public void ShowPart16()
    {
        currentGameState = GameState.CoffeePart16;
        ShowScreen(coffee16);
    }

    public void ShowPart17()
    {
        currentGameState = GameState.CoffeePart17;
        ShowScreen(coffee17);
    }

    public void ShowPart18()
    {
        currentGameState = GameState.CoffeePart18;
        ShowScreen(coffee18);
    }

    public void ShowPart19()
    {
        currentGameState = GameState.CoffeePart19;
        ShowScreen(coffee19);
    }

    public void ShowPart20()
    {
        currentGameState = GameState.CoffeePart20;
        ShowScreen(coffee20);
    }

    public void ShowPart21()
    {
        currentGameState = GameState.CoffeePart21;
        ShowScreen(coffee21);
    }

    public void ShowPart22()
    {
        currentGameState = GameState.CoffeePart22;
        ShowScreen(coffee22);
    }

    public void ShowPart23()
    {
        currentGameState = GameState.CoffeePart23;
        ShowScreen(coffee23);
    }

    public void ShowPart24()
    {
        currentGameState = GameState.CoffeePart24;
        ShowScreen(coffee24);
    }

    public void LeahTalk1()
    {
        SceneManager.LoadScene("LeahTalk1", LoadSceneMode.Single);
    }
}
