using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagScript : MonoBehaviour
{
    [SerializeField] private GameObject pickUpBall;

    private bool pickUpBallAllowed;
    private bool pickedUp;
    private bool temp;

    // Update is called once per frame
    void Update()
    {
        if(pickUpBallAllowed && Input.GetKeyDown(KeyCode.F) && !(pickedUp)){
            PickUp();
            pickedUp = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && (pickedUp)){
            PutDown();
            pickedUp = false;
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
        gameObject.transform.parent = playerObject.transform;
        gameObject.transform.position = playerObject.transform.position;
        gameObject.transform.position += new Vector3(0f,0.7f,0f);
        gameObject.transform.localScale *= 0.5f;
    }
    private void PutDown()
    {
        var playerObject = GameObject.Find("Player");
        gameObject.transform.parent = null;
        gameObject.transform.position += new Vector3(0f, -0.7f, 0f);
        gameObject.transform.localScale *= 2f;
    }
}

