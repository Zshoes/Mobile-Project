using Unity.VisualScripting;
using UnityEngine;

public class NEwScriptTT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("References")]
    [SerializeField] public float attackTime = 5f;
    [SerializeField] public float attackDamage = 2f;
    [SerializeField] public float health = 50f; 
    [SerializeField] public float gateHealth = 500f;



    [Header("Attributes")]
    [SerializeField] private float speed = 5f;
    [SerializeField] private int dmg = 1;

    /**notes for later additions 
     * add gate that the enemies attack instead of just crossing a finsih line
     * give the "Gate" HP points that the enimes hit as they wait
     * add gate defeneses you can buy / upggrade
     * make enemies that are "special" i.e enemies that only certain towers can attack
     * add eniems that attack back at the towers, potentially killing them? (needs to be tested) **/
    private void TestTT()
    {


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
