using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //[SerializeField] private GameObject door;

    public CharacterController controller;

    private float directionX;
    private float directionZ;
    private float speed = 10f;


    // Update is called once per frame
    void Update()
    {
        directionX = Input.GetAxis("Horizontal") * speed * Time.deltaTime; 
        directionZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        Vector3 movement = transform.right * directionX + transform.forward * directionZ;

        controller.Move(movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Коллизия есть");

        if (other.gameObject.CompareTag("Door"))
        {
            Debug.Log("Сюда зашел");
            GameObject door = other.gameObject;

            door.GetComponent<DoorOpening>().OpenDoor();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            GameObject door = other.gameObject;
            door.GetComponent<DoorOpening>().CloseDoor();
        }
    }
}
