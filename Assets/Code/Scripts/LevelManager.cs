using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform[] path;
    public Transform startPoint;

    public int currency;


    private void Start()
    {
        currency = 100; //starting cash
    }

    private void Awake()
    {
        main = this;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
        if (amount <= currency) {
            //buying items
            currency -= amount;
            return true;
        }
        else
        {
            Debug.Log("Too Poor to Buy"); //prolly change to a ui pop up
            return false;
        }
    }
}
