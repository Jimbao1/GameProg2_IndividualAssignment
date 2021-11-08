using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    //Light light;
    //public bool drainOverTime;
    //public float maxBrightness;
    //public float minBrightness;
    //public float drainRate;

    [SerializeField] GameObject flashlightLight;
    private bool flashlightActive = true;

    // Start is called before the first frame update
    void Start()
    {
        flashlightLight.gameObject.SetActive(true);
        //light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //light.intensity = Mathf.Clamp(light.intensity, minBrightness, maxBrightness);
        //if (drainOverTime == true && light.enabled == true)
        //{
        //    if (light.intensity > minBrightness)
        //    {
        //        light.intensity = Time.deltaTime * (drainRate / 1000);
        //    }
        //}
        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    //light.enabled = !light.enabled;
        //    if (flashlightActive == false)
        //    {
        //        flashlightLight.gameObject.SetActive(true);
        //        flashlightActive = true;
        //    } else
        //    {
        //        flashlightLight.gameObject.SetActive(false);
        //        flashlightActive = false;
        //    }
        //}
    }
}


        
        
