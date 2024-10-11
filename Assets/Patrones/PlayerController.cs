using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

    IStrategy strategy;

    KeyCode forward = KeyCode.W;
    KeyCode backward = KeyCode.S;
    KeyCode left = KeyCode.A;
    KeyCode right = KeyCode.D;

    private void Update()
    {
        MovePlayer();
        UseStrategy();
    }

    private void UseStrategy()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            strategy.Attack();
    }

    private void MovePlayer()
    {
        if (Input.GetKey(forward))
        {
            transform.Translate(0, 0, 1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(backward))
        {
            transform.Translate(0, 0, -1 * speed * Time.deltaTime);
        }
        if (Input.GetKey(left))
        {
            transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(right))
        {
            transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        IStrategy weapon = other.GetComponent<IStrategy>();

        if(weapon != null)
        {
            SetWeapon(weapon);
            strategy.PickWeapon();
        }
    }

    public void SetWeapon(IStrategy weapon)
    {
        strategy = weapon;
    }
}
