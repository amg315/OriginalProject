using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PartOneStateManage : MonoBehaviour
{
    public enum GameState { Part1State, Part2State, Part3State, Part4State, Part5State, Part6State, Part7State, Part8State};
    public GameState currentGameState;

    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public GameObject part5;
    public GameObject part6;
    public GameObject part7;
    public GameObject part8;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.Part1State;
        ShowScreen(part1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        part1.SetActive(false);
        part2.SetActive(false);
        part3.SetActive(false);
        part4.SetActive(false);
        part5.SetActive(false);
        part6.SetActive(false);
        part7.SetActive(false);
        part8.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowPart2()
    {
        currentGameState = GameState.Part2State;
        ShowScreen(part2);
    }

    public void ShowPart3()
    {
        currentGameState = GameState.Part3State;
        ShowScreen(part3);
    }

    public void ShowPart4()
    {
        currentGameState = GameState.Part4State;
        ShowScreen(part4);
    }

    public void ShowPart5()
    {
        currentGameState = GameState.Part5State;
        ShowScreen(part5);
    }

    public void ShowPart6()
    {
        currentGameState = GameState.Part6State;
        ShowScreen(part6);
    }

    public void ShowPart7()
    {
        currentGameState = GameState.Part7State;
        ShowScreen(part7);
    }

    public void ShowPart8()
    {
        currentGameState = GameState.Part8State;
        ShowScreen(part8);
    }
}
