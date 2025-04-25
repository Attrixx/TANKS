using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{

    public float m_DelayBetweenSpawns = 10f;
    public GameObject[] m_PowerUps;

    private bool m_IsWaitingForSpawn = false;
    private GameObject m_PowerUpSpawned;

    // Start is called before the first frame update
    void Start()
    {
        m_PowerUpSpawned = Instantiate(m_PowerUps[UnityEngine.Random.Range(0, m_PowerUps.Length)], gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (m_PowerUpSpawned == null && !m_IsWaitingForSpawn)
        {
            m_IsWaitingForSpawn = true;
            SpawnPowerUpDelayed();
        }
    }

    public void SpawnPowerUpDelayed()
    {
        if (m_PowerUpSpawned != null) return;
        StartCoroutine(SpawnPowerUpCoroutine());
    }

    private IEnumerator SpawnPowerUpCoroutine ()
    {
        yield return new WaitForSeconds(m_DelayBetweenSpawns);
        m_PowerUpSpawned = Instantiate(m_PowerUps[UnityEngine.Random.Range(0, m_PowerUps.Length)], gameObject.transform);
        m_IsWaitingForSpawn = false;
    }
}
