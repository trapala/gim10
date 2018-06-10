using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class CameraKeyBindingController : MonoBehaviour
{
    public Text notes;

    // Update is called once per frame
    void Update()
    {
        // Q key - "Sun Shafts" Effect
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (false == GetComponent<SunShafts>().enabled)
            {
                GetComponent<SunShafts>().enabled = true;
            }
            else
            {
                GetComponent<SunShafts>().enabled = false;
            }
        }

        // E key - "Edge Detection" Effect
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (false == GetComponent<EdgeDetection>().enabled)
            {
                GetComponent<EdgeDetection>().enabled = true;
            }
            else
            {
                GetComponent<EdgeDetection>().enabled = false;
            }
        }

        // B key - "Bloom Optimised" Effect
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (false == GetComponent<BloomOptimized>().enabled)
            {
                GetComponent<BloomOptimized>().enabled = true;
            }
            else
            {
                GetComponent<BloomOptimized>().enabled = false;
            }
        }

        // G key - "Global Fog" Effect
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (false == GetComponent<GlobalFog>().enabled)
            {
                GetComponent<GlobalFog>().enabled = true;
            }
            else
            {
                GetComponent<GlobalFog>().enabled = false;
            }
        }

        // F key - "Depth Of Field Deprecated" Effect
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (false == GetComponent<DepthOfFieldDeprecated>().enabled)
            {
                GetComponent<DepthOfFieldDeprecated>().enabled = true;
            }
            else
            {
                GetComponent<DepthOfFieldDeprecated>().enabled = false;
            }
        }

        // N key - "Antialiasing" Effect
        if (Input.GetKeyDown(KeyCode.N))
        {
            if (false == GetComponent<Antialiasing>().enabled)
            {
                GetComponent<Antialiasing>().enabled = true;
            }
            else
            {
                GetComponent<Antialiasing>().enabled = false;
            }
        }

        // M key - "Motion Blur" Effect
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (false == GetComponent<MotionBlur>().enabled)
            {
                GetComponent<MotionBlur>().enabled = true;
            }
            else
            {
                GetComponent<MotionBlur>().enabled = false;
            }
        }

        // I key - show/hide notes
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (true == notes.enabled)
            {
                notes.enabled = false;
            }
            else
            {
                notes.enabled = true;
            }
        }
    }
}
