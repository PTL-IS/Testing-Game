using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] private GameObject pickUpBall;

    private bool pickUpBallAllowed;

    private bool temp;

    // Update is called once per frame
    void Update()
    {
        if(pickUpBallAllowed && Input.GetKeyDown(KeyCode.F)){
            temp = !temp;
        }

        if (pickUpBallAllowed && temp)
        {
            PickUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpBall.gameObject.SetActive(true);
            pickUpBallAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            pickUpBall.gameObject.SetActive(false);
            pickUpBallAllowed = false;
        }
    }

    private void PickUp()
    {
        var playerObject = GameObject.Find("Player");
        var playerPos = playerObject.transform.position;
        gameObject.transform.position = playerPos;
    }
}
