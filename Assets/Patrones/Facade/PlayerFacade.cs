using UnityEngine;

public class PlayerFacade : MonoBehaviour
{
    [SerializeField] FacadeManager facadeManager;

    private void Start()
    {
        facadeManager.StartGame();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Die"))
        {
            Debug.Log("Moriste");
            facadeManager.LoseGame();
            Destroy(collision.gameObject);
        }
    }
}
