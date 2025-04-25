using System.Collections;
using System.Collections.Generic;
using Tanks.Complete;
using UnityEngine;

public class PowerUpCriticalHit : MonoBehaviour
{

    public float m_DamageMultiplier = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Tank"))
        {
            TankShooting shooting = other.gameObject.GetComponent<TankShooting>();
            shooting.EquipSpecialShell(m_DamageMultiplier);
        }
        Destroy(gameObject);
    }

}
