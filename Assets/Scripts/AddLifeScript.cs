using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddLifeScript : MonoBehaviour
{
    public GameManager gameManager;

    public void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.SetLives(gameManager.lives + 1);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("EntitiesBoundary"))
        {
            Destroy(gameObject);
        }
    }
}
