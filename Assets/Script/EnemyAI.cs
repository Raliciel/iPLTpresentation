using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public characterGameObject character;
    public float coolDownSecond = 5f;
    public LayerMask playerLayer;
    private float distance;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(FindPlayer());
    }

    IEnumerator FindPlayer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            if (Attack())
            {
                yield return new WaitForSeconds(coolDownSecond-1);
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
            player.GetComponent<characterGameObject>().TakeDamage(attack);
            return true;
       }
       return false;
    }
}
