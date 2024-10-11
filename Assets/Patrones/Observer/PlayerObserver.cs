using System;
using UnityEngine;

public class PlayerObserver : MonoBehaviour
{
    public event Action onDie;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Die"))
        {
            Debug.Log("Moriste");
            onDie.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
