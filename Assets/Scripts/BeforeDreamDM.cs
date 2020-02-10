using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeforeDreamDM : MonoBehaviour
{
    public TextMeshProUGUI textDisplay; //slot for TextMeshPro
    public string[] sentences; //creates array of sentences to be shown
    private int index; //number used to go through sentences
    public float typingSpeed; //typing speed
    public GameObject continueButton;
    private SceneManage2 POSM2;
    public GameObject oPOSM2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
        POSM2= oPOSM2.GetComponent<SceneManage2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            POSM2.ShowPart2();
        }
    }
}
