using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public float health;
    public GameObject canvas;
    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            health -= 1;
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

        healthBar.value = health;
        if (health <= 0 )
        {
            canvas.SetActive(true);
            
        }
        else
        {
            
            Time.timeScale = health / 10;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
