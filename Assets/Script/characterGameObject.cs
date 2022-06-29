using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterGameObject : MonoBehaviour
{

    public Character character;

    [HideInInspector] public string characterName;
    [HideInInspector] public int healthPoint;
    [HideInInspector] public int attackPoint;
    [HideInInspector] public Sprite characterSprite;

    public int currentHealthPoint;
    private SpriteRenderer spriteRenderer;
    public GameObject areaOfEffect;
    public GameObject particle;
    public CircleCollider2D hitbox;

    public BarUI healthBar;
    public BarUI StaminaBar;
    

    // Start is called before the first frame update
    void Start()
    {
        characterName = character.characterName;
        healthPoint = character.healthPoint;
        attackPoint = character.attackPoint;

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = character.characterSprite;
        areaOfEffect.transform.localScale = Vector3.one * character.areaRadius;
        hitbox.radius = character.hitboxRadius;

        currentHealthPoint = healthPoint; //start with full health;
        healthBar.SetMaxHealth(healthPoint);
    }

    void Update()
    {
        healthBar.SetCurrentHealth(currentHealthPoint);
        if (currentHealthPoint > healthPoint)
        {
            currentHealthPoint = healthPoint;
        }

        if (currentHealthPoint <= 0)
        {
            die();
        }


    }

    private void die()
    {
        GameObject _particle = Instantiate(particle) as GameObject;
        _particle.transform.position = transform.position;
        if (gameObject.CompareTag("Player"))
        {
            StaminaBar.SetCurrentHealth(0);
        }
        Destroy(gameObject);
    }
    public void TakeDamage(int damage)
    {
        currentHealthPoint -= damage;
    }
}
