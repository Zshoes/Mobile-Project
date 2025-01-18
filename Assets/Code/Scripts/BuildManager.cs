using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;

    [Header("References")]
    [SerializeField] private GameObject[] towerPrefabs;


    //[Header("Attributes")]
    //[SerializeField] private GameObject go;

    private int selectedTower = 0;


    private void Awake()
    {
        main = this;
    }
    
    public GameObject GetSelectedTower()
    {
        return towerPrefabs[selectedTower];
    }
}


