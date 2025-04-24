using System.Collections;
using System.Collections.Generic;
using Tanks.Complete;
using UnityEngine;

public class PowerUpBoost : MonoBehaviour
{

    public float m_SpeedMultiplier = 2f;
    public float m_Duration = 2f;

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
            TankMovement movement = other.gameObject.GetComponent<TankMovement>();
            movement.Boost(m_SpeedMultiplier, m_Duration);
        }
        Destroy(gameObject);
    }
}
