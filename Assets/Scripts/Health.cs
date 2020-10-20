using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public static float health, score, highscore;
    public GameObject canvas;
    public Slider healthBar;
    public Text scoretext, highscoretext;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        Time.timeScale = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (healthBar.value != health)
        {
            healthBar.value = health;
           
        }
        if (score >= highscore)
        {
            highscore = score;
        }
        if (health <= 0 )
        {
            canvas.SetActive(true);
            Time.timeScale = 0;
            scoretext.text = "Score: " + score;
            highscoretext.text = "HighScore: " + highscore;
        }
        else
        {

            canvas.SetActive(false);
        }
    }
    public void Restart()
    {
        score = 0;
        SceneManager.LoadScene(0);
    }
}
