using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallSceneManage : MonoBehaviour
{
    public enum GameState { Fall1, Fall2, Fall3, Fall4, Fall5, Fall6, Fall7, Fall8, Fall9, Fall10, Fall11, Fall12, Fall13, Fall14, Fall15, Fall16, Fall17, Fall18, Fall19, Fall20, Fall21 };
    public GameState currentGameState;

    public GameObject f1;
    public GameObject f2;
    public GameObject f3;
    public GameObject f4;
    public GameObject f5;
    public GameObject f6;
    public GameObject f7;
    public GameObject f8;
    public GameObject f9;
    public GameObject f10;
    public GameObject f11;
    public GameObject f12;
    public GameObject f13;
    public GameObject f14;
    public GameObject f15;
    public GameObject f16;
    public GameObject f17;
    public GameObject f18;
    public GameObject f19;
    public GameObject f20;
    public GameObject f21;
    // Start is called before the first frame update
    void Start()
    {
        currentGameState = GameState.Fall1;
        ShowScreen(f1);
    }

    void ShowScreen(GameObject gameObjectToShow)
    {
        f1.SetActive(false);
        f2.SetActive(false);
        f3.SetActive(false);
        f4.SetActive(false);
        f5.SetActive(false);
        f6.SetActive(false);
        f7.SetActive(false);
        f8.SetActive(false);
        f9.SetActive(false);
        f10.SetActive(false);
        f11.SetActive(false);
        f12.SetActive(false);
        f13.SetActive(false);
        f14.SetActive(false);
        f15.SetActive(false);
        f16.SetActive(false);
        f17.SetActive(false);
        f18.SetActive(false);
        f19.SetActive(false);
        f20.SetActive(false);
        f21.SetActive(false);
        gameObjectToShow.SetActive(true);
    }

    public void ShowFall2()
    {
        currentGameState = GameState.Fall2;
        ShowScreen(f2);
    }

    public void ShowFall3()
    {
        currentGameState = GameState.Fall3;
        ShowScreen(f3);
    }

    public void ShowFall4()
    {
        currentGameState = GameState.Fall4;
        ShowScreen(f4);
    }

    public void ShowFall5()
    {
        currentGameState = GameState.Fall5;
        ShowScreen(f5);
    }

    public void ShowFall6()
    {
        currentGameState = GameState.Fall6;
        ShowScreen(f6);
    }

    public void ShowFall7()
    {
        currentGameState = GameState.Fall7;
        ShowScreen(f7);
    }

    public void ShowFall8()
    {
        currentGameState = GameState.Fall8;
        ShowScreen(f8);
    }

    public void ShowFall9()
    {
        currentGameState = GameState.Fall9;
        ShowScreen(f9);
    }

    public void ShowFall10()
    {
        currentGameState = GameState.Fall10;
        ShowScreen(f10);
    }

    public void ShowFall11()
    {
        currentGameState = GameState.Fall11;
        ShowScreen(f11);
    }

    public void ShowFall12()
    {
        currentGameState = GameState.Fall12;
        ShowScreen(f12);
    }

    public void ShowFall13()
    {
        currentGameState = GameState.Fall13;
        ShowScreen(f13);
    }

    public void ShowFall14()
    {
        currentGameState = GameState.Fall14;
        ShowScreen(f14);
    }

    public void ShowFall15()
    {
        currentGameState = GameState.Fall15;
        ShowScreen(f15);
    }

    public void ShowFall16()
    {
        currentGameState = GameState.Fall16;
        ShowScreen(f16);
    }

    public void ShowFall17()
    {
        currentGameState = GameState.Fall17;
        ShowScreen(f17);
    }

    public void ShowFall18()
    {
        currentGameState = GameState.Fall18;
        ShowScreen(f18);
    }

    public void ShowFall19()
    {
        currentGameState = GameState.Fall19;
        ShowScreen(f19);
    }

    public void ShowFall20()
    {
        currentGameState = GameState.Fall20;
        ShowScreen(f20);
    }

    public void ShowFall21()
    {
        currentGameState = GameState.Fall21;
        ShowScreen(f21);
    }

    public void AfterFall()
    {
        SceneManager.LoadScene("LeahTalkFall", LoadSceneMode.Single);
    }
}
