using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Avatar_Health : MonoBehaviour
{
    [SerializeField] private int health;

    [SerializeField] private int maxHealth;

    [SerializeField] private Text healthUIText;

    public int GetHealth()
    {
        return health;
    }

    public void IncHealth()
    {
        if (health < maxHealth)
        {
            health++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyProjectile")
        {
            health--;
        }
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void Update()
    {
        healthUIText.text = "Strength: " + health.ToString();
    }
}
