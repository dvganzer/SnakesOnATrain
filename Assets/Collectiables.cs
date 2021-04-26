using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectiables : MonoBehaviour
{
    public GameObject Gem;
    public GameObject Bag;
    public GameObject Coin;
    public float Score;
    public Text playerScore;
    public AudioSource collected;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == Gem)
        {
            Score += 100;
          
            Debug.Log(Score);
        }
        if (collision.gameObject == Coin)
        {
            Score += 10;
            Debug.Log(Score);
        }
        if (collision.gameObject == Bag)
        {
            Score += 50;
            Debug.Log(Score);
        }
    }
}
