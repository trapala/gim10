using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class NoFogTriggerController : MonoBehaviour
{
    public Camera targetCamera;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            targetCamera.GetComponent<MotionBlur>().enabled = false;
            targetCamera.GetComponent<GlobalFog>().enabled = false;
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            targetCamera.GetComponent<MotionBlur>().enabled = true;
            targetCamera.GetComponent<GlobalFog>().enabled = true;
        }
    }
}
