using UnityEngine;
using UnityEngine.UI;

public class ImageOnDie : MonoBehaviour
{
    [SerializeField] PlayerObserver observer;
    Image imageOnDie;

    public void SetImageOnDie()
    {
        imageOnDie.enabled = true;
    }

    private void Awake()
    {
        imageOnDie = GetComponent<Image>();

        if (observer != null) 
        {
            observer.onDie += SetImageOnDie;
        }
    }

}
