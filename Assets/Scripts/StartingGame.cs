using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingGame : MonoBehaviour
{
    public void Starting()
    {
        SceneManager.LoadScene("Before Dream", LoadSceneMode.Single);
    }
}
