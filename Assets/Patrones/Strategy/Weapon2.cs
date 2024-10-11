using UnityEngine;

public class Weapon2 : MonoBehaviour, IStrategy
{
    public void PickWeapon()
    {
        Debug.Log("You pick SMG");
    }

    public void Attack()
    {
        Debug.Log("SMG atacando");
    }
}
