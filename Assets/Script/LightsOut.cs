using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightsOut : MonoBehaviour
{
    public UnityEngine.Experimental.Rendering.Universal.Light2D light;

    public Text lightText;
    private float nextUpdate = 1;
    private float t = 0f;
    public float lightDelay;
    public float lightSpeed;

    // Update is called once per frame
    void Update()
    {
        t += lightSpeed * Time.deltaTime;
        if (lightText.text != "Q"){
            light.pointLightOuterRadius = Mathf.Lerp(0.5f, 5f, t-lightDelay);
        }
        if (lightText.text == "Q" && Input.GetKeyDown(KeyCode.Q))
        {
            lightText.text = "10";
            nextUpdate = Time.time + 1f;
            light.pointLightOuterRadius = 0f;
            t = 0.0f;
        }
        if (lightText.text != "Q")
        {
            if (Time.time > nextUpdate)
            {
                if (lightText.text == "1")
                {
                    lightText.text = "Q";
                }
                else
                {
                    lightText.text = ((int.Parse(lightText.text))-1).ToString();
                    nextUpdate = Time.time + 1;
                }
            }
        }
    }
}
