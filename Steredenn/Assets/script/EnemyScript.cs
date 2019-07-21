using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private WeaponScript[] weapons;

    private void Awake()
    {
        //Retrieve the weapon only once
        weapons = GetComponentsInChildren<WeaponScript>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(WeaponScript weapon in weapons)
        {
            //Auto-Fire
            if (weapon != null && weapon.CanAttack)
            {
                weapon.Attack(true);
            }
        }
    }
}
