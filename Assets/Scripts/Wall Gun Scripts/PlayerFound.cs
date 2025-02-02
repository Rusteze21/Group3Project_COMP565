using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFound : MonoBehaviour
{
    [SerializeField] private GameObject wallGun;

    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    private void OnTriggerStay(Collider other) {
        // As long as Player stays within the ScanZone
        if(other.transform.tag == "Player"){
            // Send the referenced variable the current position of the player
            wallGun.GetComponent<ShootProjectile>().playerPosition = other.transform.position;
        }
    }

    private void OnTriggerExit(Collider other) {
        // When Player exists collider, reset position of referenced variable (player is not here)
        if(other.transform.tag == "Player"){
            wallGun.GetComponent<ShootProjectile>().playerPosition = new Vector3(0, 0, 0);
        }
    }
}
