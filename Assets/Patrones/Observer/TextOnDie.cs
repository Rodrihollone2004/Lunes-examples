using TMPro;
using UnityEngine;

public class TextOnDie : MonoBehaviour
{
    [SerializeField] PlayerObserver observer;
    TMP_Text textOnDie;

    public void SetTextOnDie()
    {
        textOnDie.text = "YOU DIED";
        textOnDie.enabled = true;
    }

    private void Awake()
    {
        textOnDie = GetComponent<TMP_Text>();

        if(observer != null)
        {
            observer.onDie += SetTextOnDie;
        }
    }
}
