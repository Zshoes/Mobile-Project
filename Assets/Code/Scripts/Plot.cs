using UnityEngine;

public class Plot : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;
    private GameObject tower;
    private Color startColor;

    private void Start()
    {
        startColor = sr.color;
    }
    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
        if(tower != null) //remove for upgrade / sell functions later (this is if it empty then we do, if not empty we return)
        {
            return;
        }

        Tower towerToBuild = BuildManager.main.GetSelectedTower();

        if (towerToBuild.cost > LevelManager.main.currency)
        {
            Debug.Log("too poor");
            return;
        }

        LevelManager.main.SpendCurrency(towerToBuild.cost);

        tower = towerToBuild.prefab;

        Instantiate(towerToBuild.prefab, transform.position, Quaternion.identity);

        Debug.Log("build tower here " + name);
    }

}
