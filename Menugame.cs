using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menugame : MonoBehaviour
{
    public string firstLevel;

    public GameObject optionScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void OpenOption()
    {
        optionScreen.SetActive(true);
    }
    public void CloseObtion()
    {
        optionScreen.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
