using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAITurnBase : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public characterGameObject character;
    public float coolDownSecond = 5f;
    public LayerMask playerLayer;
    private float distance;
    public static int enemyStamina = 100;

    private ClickEventTB clickEventTB;

    void Start()
    {
        clickEventTB = player.GetComponent<ClickEventTB>();
        StartCoroutine(FindPlayer());
    }

    IEnumerator FindPlayer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            if (!ClickEventTB.selfTurn)
            {
                if (Attack())
                {
                    Debug.Log("EnemyStamina" + enemyStamina);
                    yield return new WaitForSeconds(coolDownSecond-1);
                }   
            }

            if (enemyStamina <= 10)
            {
                yield return null;
                enemyStamina = 100;
                ClickEventTB.selfTurn = true;
                clickEventTB.staminaBar.SetValue(100);
            }
         
        }
    }

    // Update is called once per frame

    bool Attack()
    {   
       Collider2D collider = Physics2D.OverlapCircle(transform.position, character.character.areaRadius, playerLayer);
       if (collider != null)
       {
            int attack = character.attackPoint;
            DamagePopUp.CreateDamage(collider.transform, attack);
            enemyStamina -= 20;
            player.GetComponent<characterGameObject>().TakeDamage(attack);
            return true;
       }
       return false;
    }
}
