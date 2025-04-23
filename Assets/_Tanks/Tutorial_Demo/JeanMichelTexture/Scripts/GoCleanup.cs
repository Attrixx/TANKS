using UnityEngine;

public class Cleanup : MonoBehaviour
{
    [Tooltip("Delay before the object is destroyed")]
    public float delay = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
