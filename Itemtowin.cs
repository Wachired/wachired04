using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Itemtowin : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    public AudioClip itemSound;
    public AudioClip completeSound;

    //amount item
    int itemCount;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        Debug.Log(itemCount);
        scoreText.text = "Item = " + score.ToString() + "/" + itemCount.ToString();
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag.Equals("Item"))
        {
            //delete Item
            Destroy(target.gameObject);

            score += 1;
            scoreText.text = "Item = " + score.ToString() + "/" + itemCount.ToString();
            audioSource.PlayOneShot(itemSound);
            if (score >= itemCount)
            {
                audioSource.PlayOneShot(completeSound);
                StartCoroutine(NextLevel());
            }
            else
            {
                audioSource.PlayOneShot(itemSound);
            }
        }
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Youwin");
    }
}