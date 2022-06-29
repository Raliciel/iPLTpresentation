using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Character", menuName = "Character")]
public class Character : ScriptableObject
{
    public string characterName;
    public int healthPoint;
    public int attackPoint;
    public int areaRadius;
    public Sprite characterSprite;
    public float hitboxRadius = 1;
}
