using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ClickEventTB : MonoBehaviour
{
    public characterGameObject character;
    public BarUI staminaBar;
    public Text turnSignal;
    public static bool selfTurn = true; //if it's player's turn then this is true;
    public FollowCamera followCamera;

    void Update()
    {
        if (staminaBar.GetValue() == 0)
        {
            selfTurn = false;
            
        }
        updateText();
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.transform.gameObject.CompareTag("Enemy"))
            {
                Attack(hit.transform);
            }

        }
    }

    public void updateText()
    {
        if (selfTurn)
        {
            turnSignal.text = "Your Turn";
        }
        else turnSignal.text = "Enemy Turn";
    }

    void Attack(Transform enemy)
    {
        if (!selfTurn) return;
        if (staminaBar.GetValue() == 0)
        {
            DamagePopUp.CreateDamage(transform, "Stamina\nOut!");
            return;
        }
        if (Vector2.Distance(enemy.position, transform.position) > character.character.areaRadius) return;
        int attack = character.attackPoint;
        DamagePopUp.CreateDamage(enemy, attack);
        enemy.GetComponent<characterGameObject>().TakeDamage(Random.Range(0, attack));
        staminaBar.DecreseValue(20);
    }
}
