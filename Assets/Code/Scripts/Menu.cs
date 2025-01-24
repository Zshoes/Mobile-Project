using UnityEngine;
using TMPro;
using System.Net.NetworkInformation;

public class Menu : MonoBehaviour
{

    [Header("References")]
    [SerializeField] TextMeshProUGUI currencyUI;
    [SerializeField] Animator anim;


    private bool isMenuOpen = true;

    public void ToggleMenu()
    {
        isMenuOpen = !isMenuOpen;
        anim.SetBool("MenuOpen", isMenuOpen);
    }

    private void OnGUI()
    {
        currencyUI.text = LevelManager.main.currency.ToString();
    }

   /** public void SetSelected()
    { 

    } was here then gone idk man**/ 

}
