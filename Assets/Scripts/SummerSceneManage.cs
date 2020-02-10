using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SummerSceneManage : MonoBehaviour
{
    public enum GameState { Summer1, Summer2, Summer3, Summer4, Summer5, Summer6, Summer7, Summer8, Summer9, Summer10, Summer11, Summer12, Summer13, Summer14, Summer15, Summer16, Summer17};
    public GameState currentGameState;

    public GameObject summer1;
    public GameObject summer2;
    public GameObject summer3;
    public GameObject summer4;
    public GameObject summer5;
    public GameObject summer6;
    public GameObject summer7;
    public GameObject summer8;
    public GameObject summer9;
    public GameObject summer10;
    public GameObject summer11;
    public GameObject summer12;
    public GameObject summer13;
    public GameObject summer14;
    public GameObject summer15;
    public GameObject summer16;
    public GameObject summer17;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.Summer1;
        ShowScreen(summer1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        summer1.SetActive(false);
        summer2.SetActive(false);
        summer3.SetActive(false);
        summer4.SetActive(false);
        summer5.SetActive(false);
        summer6.SetActive(false);
        summer7.SetActive(false);
        summer8.SetActive(false);
        summer9.SetActive(false);
        summer10.SetActive(false);
        summer11.SetActive(false);
        summer12.SetActive(false);
        summer13.SetActive(false);
        summer14.SetActive(false);
        summer15.SetActive(false);
        summer16.SetActive(false);
        summer17.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowPart2()
    {
        currentGameState = GameState.Summer2;
        ShowScreen(summer2);
    }

    public void ShowPart3()
    {
        currentGameState = GameState.Summer3;
        ShowScreen(summer3);
    }

    public void ShowPart4()
    {
        currentGameState = GameState.Summer4;
        ShowScreen(summer4);
    }

    public void ShowPart5()
    {
        currentGameState = GameState.Summer5;
        ShowScreen(summer5);
    }

    public void ShowPart6()
    {
        currentGameState = GameState.Summer6;
        ShowScreen(summer6);
    }

    public void ShowPart7()
    {
        currentGameState = GameState.Summer7;
        ShowScreen(summer7);
    }

    public void ShowPart8()
    {
        currentGameState = GameState.Summer8;
        ShowScreen(summer8);
    }

    public void ShowPart9()
    {
        currentGameState = GameState.Summer9;
        ShowScreen(summer9);
    }

    public void ShowPart10()
    {
        currentGameState = GameState.Summer10;
        ShowScreen(summer10);
    }

    public void ShowPart11()
    {
        currentGameState = GameState.Summer11;
        ShowScreen(summer11);
    }

    public void ShowPart12()
    {
        currentGameState = GameState.Summer12;
        ShowScreen(summer12);
    }

    public void ShowPart13()
    {
        currentGameState = GameState.Summer13;
        ShowScreen(summer13);
    }

    public void ShowPart14()
    {
        currentGameState = GameState.Summer14;
        ShowScreen(summer14);
    }

    public void ShowPart15()
    {
        currentGameState = GameState.Summer15;
        ShowScreen(summer15);
    }

    public void ShowPart16()
    {
        currentGameState = GameState.Summer16;
        ShowScreen(summer16);
    }

    public void ShowPart17()
    {
        currentGameState = GameState.Summer17;
        ShowScreen(summer17);
    }

    public void SummerTalk()
    {
        SceneManager.LoadScene("LeahSummerTalk", LoadSceneMode.Single);
    }
}
