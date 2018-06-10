using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class HeightTriggerController : MonoBehaviour
{
    public Camera targetCamera;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            targetCamera.GetComponent<DepthOfFieldDeprecated>().enabled = true;
            targetCamera.GetComponent<MotionBlur>().blurAmount = 0.85f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))
        {
            targetCamera.GetComponent<DepthOfFieldDeprecated>().enabled = false;
            targetCamera.GetComponent<MotionBlur>().blurAmount = 0.5f; // should correspond to the original value
        }
    }
}
