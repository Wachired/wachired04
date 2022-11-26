using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start_game ()
    {
        PickItem.score = 0;
        Life.life = 3;
        SceneManager.LoadScene(1);
    }
    public void main_menu()
    {
        SceneManager.LoadScene(0);
    }

    public void exit_game()
    {
        Application.Quit();
    }
}
