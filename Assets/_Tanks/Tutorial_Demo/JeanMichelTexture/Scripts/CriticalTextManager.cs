using UnityEngine;
using UnityEngine.UI;

public class CriticalTextManager : MonoBehaviour
{
    private Image m_CriticalTextImage;

    private void Start()
    {
        m_CriticalTextImage = GetComponent<Image>();
        m_CriticalTextImage.enabled = false;
    }

    void LateUpdate()
    {
        var cam = Camera.main;
        if (cam)
            transform.forward = cam.transform.forward;
    }

    public void DisplayCritical()
    {
        m_CriticalTextImage.enabled = true;
    }

    public void HideCritical()
    {
        m_CriticalTextImage.enabled = false;
    }
}
