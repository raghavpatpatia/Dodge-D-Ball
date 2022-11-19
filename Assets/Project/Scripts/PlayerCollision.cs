using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Balls")
        {
            PlayerManager.isGameOver = true;
            balls.spwaning = false;
            gameObject.SetActive(false);
        }
    }
}
