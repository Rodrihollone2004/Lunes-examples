using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] string id;
    [SerializeField] int health;

    Factory factory;

    public string Id { get => id; set => id = value; }

    private void Awake()
    {
        factory = FindObjectOfType<Factory>();
        health = Random.Range(0,100);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnObjects();
        }
    }

    private void SpawnObjects()
    {
        factory.Create(id);
    }
}
