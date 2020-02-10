using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage2 : MonoBehaviour
{
    public enum GameState { TwoPart1State, TwoPart2State, TwoPart3State, TwoPart4State};
    public GameState currentGameState;

    public GameObject twopart1;
    public GameObject twopart2;
    public GameObject twopart3;
    public GameObject twopart4;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.TwoPart1State;
        ShowScreen(twopart1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        twopart1.SetActive(false);
        twopart2.SetActive(false);
        twopart3.SetActive(false);
        twopart4.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowPart2()
    {
        currentGameState = GameState.TwoPart2State;
        ShowScreen(twopart2);
    }

    public void ShowPart3()
    {
        currentGameState = GameState.TwoPart3State;
        ShowScreen(twopart3);
    }

    public void ShowPart4()
    {
        currentGameState = GameState.TwoPart4State;
        ShowScreen(twopart4);
    }
}
