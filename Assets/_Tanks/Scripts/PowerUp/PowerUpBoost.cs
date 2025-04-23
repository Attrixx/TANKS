using System.Collections;
using System.Collections.Generic;
using Tanks.Complete;
using UnityEngine;

public class PowerUpBoost : MonoBehaviour
{

    public GameObject m_FlamesPrefab;
    public float m_BoostDuration;
    [HideInInspector]
    public TankMovement m_Movement;

    private void Awake()
    {
        m_Movement = GetComponent<TankMovement>();
        if (m_Movement != null )
        {
            m_Movement = gameObject.AddComponent<TankMovement>();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
