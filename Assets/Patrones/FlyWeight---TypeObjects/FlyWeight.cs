using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.WSA;

[CreateAssetMenu(fileName = "EnemyFlyWeight", menuName = "FlyWeigght/EnemyData", order = 1)]

public class FlyWeight : ScriptableObject
{
    public int damage;
    public float health;

    //Esto para que todos los objetos que tengan el scriptableObject tengan el mismo método pero lo puedan sobreescribir (TypeObject)
    public virtual void SubstractHelath()
    {
        health--;
    }
}
