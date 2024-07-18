using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManeger : MonoBehaviour
{
    public int playerHealth = 4;
    public Text playerHealthText;
    public int gearCount;

   
    
    void Update()
    {
        if (playerHealthText != null)
        {
            playerHealthText.text = playerHealth.ToString();
        }
    }


    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        StartCoroutine("GetInvulnerable");
    }

    IEnumerator GetInvulnerable()
    {
        Physics2D.IgnoreLayerCollision(6, 7, true);
        yield return new WaitForSeconds(3f);
        Physics2D.IgnoreLayerCollision(6, 7, false);
    }

    public void Heal()
    {
        playerHealth += 1;
    }

    public void GearSet(int gears)
    {
        gearCount = gears;
    }
} 
