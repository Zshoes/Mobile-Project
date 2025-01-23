using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{

    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;

    private void OnGUI()
    {
        currencyUI.text = LevelManager.main.currency.ToString();
    }

    public void SetSelected()
    { 

    }

}
