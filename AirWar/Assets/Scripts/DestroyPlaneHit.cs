using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyPlaneHit : MonoBehaviour
{
    [Tooltip("Bullet")]
    public string targetTag = "Bullet";

    private Text scoreText;
    private static int score = 0;

    private void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(targetTag))
        {
            Destroy(gameObject);
            UpdateScore();
        }
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = $"Score: {score}";

    }
}
