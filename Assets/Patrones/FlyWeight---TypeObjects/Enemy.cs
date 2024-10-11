using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] FlyWeight flyWeight;

    private void Awake()
    {
        flyWeight.health = Random.Range(50,200);
    }

    private void Update()
    {
        if (flyWeight.health > 0)
        {
            flyWeight.SubstractHelath();
        }
        else
        {
            Debug.Log("Enemigo muerto");
            Destroy(gameObject);
        }
    }
}