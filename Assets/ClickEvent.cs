using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
    public characterGameObject character;
    public BarUI staminaBar;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.transform.gameObject.CompareTag("Enemy"))
            {
                Attack(hit.transform);
            }

        }
    }

    void Attack(Transform enemy)
    {
        if (staminaBar.GetValue() == 0)
        {
            DamagePopUp.CreateDamage(transform, "Stamina\nOut!");
            return;
        }
        if (Vector2.Distance(enemy.position, transform.position) > character.character.areaRadius) return;

        int attack = character.attackPoint;
        DamagePopUp.CreateDamage(enemy, attack);
        enemy.GetComponent<characterGameObject>().TakeDamage(Random.Range(0, attack));
        staminaBar.DecreseValue(5);
    }
}
