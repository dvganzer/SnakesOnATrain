using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectiables : MonoBehaviour
{


    public int Score;
    public Text playerScore;
    public AudioSource collected;
    public AudioSource OOF;

    private void Start()
    {
        Score = 0;

    }

    private void Update()
    {
        playerScore.text = ("Score: " + Score);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.name == "Gem")
        {
            Score += Random.Range(75, 100);
            Debug.Log(Score);
            collected.Play();
        }
        if (collision.gameObject.name == "Coin")
        {
            Score += Random.Range(10, 30);
            Debug.Log(Score);
            collected.Play();
        }
        if (collision.gameObject.name == "Bag")
        {
            Score += Random.Range(35, 80);
            Debug.Log(Score);
            collected.Play();
        }
        if (collision.gameObject.name == "Cash")
        {

            Score += 100;
            Score += Random.Range(100, 200);
            collected.Play();

            Debug.Log(Score);
        }
        if (collision.gameObject.name == "Watch")
        {
            Score += Random.Range(90, 155);
            Debug.Log(Score);
            collected.Play();
        }
        if (collision.gameObject.name == "Snake")
        {
            Score -= Random.Range(5, 25);
            Debug.Log(Score);
            OOF.Play();
        }
    }
}

