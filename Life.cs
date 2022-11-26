using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    public static int  life = 3;
    public GameObject h1, h2, h3 ,start_point, player_point ;

    void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Player");
        {
            life -= 1;
            player_point.transform.position = start_point.transform.position;
            
        }
    }


    void Update()
    {
        switch (life)
        {
            case 2:
              h3.SetActive(false);
              break;
            
            case 1:
                h2.SetActive(false);
                break;
            
            case 0:
                h1.SetActive(false);
                SceneManager.LoadScene(4);
                break;
        }
    }
}
