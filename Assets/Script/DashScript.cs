using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DashScript : MonoBehaviour
{
    private GameObject player;
    private PlayerMovement playerScript;
    public Text dashText;
    public Image dashImage;
    private float nextUpdate = 1;
    private float t = 0f;
    // Update is called once per frame
    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerMovement>();
        dashImage.enabled = true;
    }
    void Update()
    {
        t += 1f * Time.deltaTime;
        if (dashImage.enabled == false)
        {
            
            playerScript.playerSpeed = Mathf.Lerp(10f, 4f, t);
        }

        if (dashImage.enabled && Input.GetMouseButtonDown(1))
        {
            dashImage.enabled = false;
            dashText.text = "3";
            nextUpdate = Time.time + 1f;
            playerScript.playerSpeed = 8f;
            t = 0.0f;
        }
        if (dashImage.enabled == false)
        {
            if (Time.time > nextUpdate)
            {
                if (dashText.text == "1")
                {
                    dashText.text = "";
                    dashImage.enabled = true;
                }
                else
                {
                    dashText.text = ((int.Parse(dashText.text)) - 1).ToString();
                    nextUpdate = Time.time + 1f;
                }
            }
        }
    }
}
