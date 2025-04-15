using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    private float swordClDwn;
    public float startSwordCldwn;
    public Transform swordPos;
    public float swordRange;
    public LayerMask Enemy;
    public int damage;
    public GameObject SwordGraphic;
    

    void Start()
    {
        swordClDwn = 0;
    }

    void Update ()
    {
        if(swordClDwn <= 0)
        {
            if(Input.GetKey(KeyCode.J))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(swordPos.position, swordRange, Enemy);
                for (int i = 0; i < enemiesToDamage.Length;  i++)
                {
                    EStats ennemy = enemiesToDamage[i].GetComponent<EStats>();
                    ennemy.TakeDamage(damage);
                }
                swordClDwn = startSwordCldwn;
                StartCoroutine("SwordAnim");
            }
        }
        else
        {
            swordClDwn -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(swordPos.position, swordRange);
    }

    IEnumerator SwordAnim()
    {
        SwordGraphic.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        SwordGraphic.SetActive(false);
    }
}
