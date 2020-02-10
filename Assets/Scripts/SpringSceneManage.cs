using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpringSceneManage : MonoBehaviour
{
    public enum GameState { Spring1, Spring2, Spring3, Spring4, Spring5, Spring6, Spring7, Spring8, Spring9, Spring10, Spring11, Spring12, Spring13, Spring14, Spring15, Spring16, Spring17, Spring18, Spring19};
    public GameState currentGameState;

    public GameObject spring1;
    public GameObject spring2;
    public GameObject spring3;
    public GameObject spring4;
    public GameObject spring5;
    public GameObject spring6;
    public GameObject spring7;
    public GameObject spring8;
    public GameObject spring9;
    public GameObject spring10;
    public GameObject spring11;
    public GameObject spring12;
    public GameObject spring13;
    public GameObject spring14;
    public GameObject spring15;
    public GameObject spring16;
    public GameObject spring17;
    public GameObject spring18;
    public GameObject spring19;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.Spring1;
        ShowScreen(spring1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        spring1.SetActive(false);
        spring2.SetActive(false);
        spring3.SetActive(false);
        spring4.SetActive(false);
        spring5.SetActive(false);
        spring6.SetActive(false);
        spring7.SetActive(false);
        spring8.SetActive(false);
        spring9.SetActive(false);
        spring10.SetActive(false);
        spring11.SetActive(false);
        spring12.SetActive(false);
        spring13.SetActive(false);
        spring14.SetActive(false);
        spring15.SetActive(false);
        spring16.SetActive(false);
        spring17.SetActive(false);
        spring18.SetActive(false);
        spring19.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowSpring2()
    {
        currentGameState = GameState.Spring2;
        ShowScreen(spring2);
    }

    public void ShowSpring3()
    {
        currentGameState = GameState.Spring3;
        ShowScreen(spring3);
    }

    public void ShowSpring4()
    {
        currentGameState = GameState.Spring4;
        ShowScreen(spring4);
    }

    public void ShowSpring5()
    {
        currentGameState = GameState.Spring5;
        ShowScreen(spring5);
    }

    public void ShowSpring6()
    {
        currentGameState = GameState.Spring6;
        ShowScreen(spring6);
    }

    public void ShowSpring7()
    {
        currentGameState = GameState.Spring7;
        ShowScreen(spring7);
    }

    public void ShowSpring8()
    {
        currentGameState = GameState.Spring8;
        ShowScreen(spring8);
    }

    public void ShowSpring9()
    {
        currentGameState = GameState.Spring9;
        ShowScreen(spring9);
    }

    public void ShowSpring10()
    {
        currentGameState = GameState.Spring10;
        ShowScreen(spring10);
    }

    public void ShowSpring11()
    {
        currentGameState = GameState.Spring11;
        ShowScreen(spring11);
    }

    public void ShowSpring12()
    {
        currentGameState = GameState.Spring12;
        ShowScreen(spring12);
    }

    public void ShowSpring13()
    {
        currentGameState = GameState.Spring13;
        ShowScreen(spring13);
    }

    public void ShowSpring14()
    {
        currentGameState = GameState.Spring14;
        ShowScreen(spring14);
    }

    public void ShowSpring15()
    {
        currentGameState = GameState.Spring15;
        ShowScreen(spring15);
    }

    public void ShowSpring16()
    {
        currentGameState = GameState.Spring16;
        ShowScreen(spring16);
    }

    public void ShowSpring17()
    {
        currentGameState = GameState.Spring17;
        ShowScreen(spring17);
    }

    public void ShowSpring18()
    {
        currentGameState = GameState.Spring18;
        ShowScreen(spring18);
    }

    public void ShowSpring19()
    {
        currentGameState = GameState.Spring19;
        ShowScreen(spring19);
    }

    public void SpringTalk()
    {
        SceneManager.LoadScene("SpringLeahTalk", LoadSceneMode.Single);
    }
}
