using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
    [SerializeField] Image imageDie;
    [SerializeField] TMP_Text textDie;

    public void StartUI()
    {
        imageDie.enabled = false;
        textDie.text = "YOU DIED";
        textDie.enabled = false;
    }

    public void LoseUI()
    {

        imageDie.enabled = true;
        textDie.enabled = true;
    }
}
