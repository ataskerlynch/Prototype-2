using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    private float speed = 20.0f;
    private float xRange = 20;
    private float zRangeMin = -2;
    private float zRangeMax = 18;
    private Vector3 projectileSpanwLoc = new Vector3(0, 0, 1);
    public GameObject projectilePrefab;


    // Update is called once per frame
    void Update()
    {
        // Fire projectile if space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject pooledProjectile = ObjectPooler.SharedInstance.GetPooledObject();
            if (pooledProjectile != null)
            {
                pooledProjectile.SetActive(true); // activate it
                pooledProjectile.transform.position = transform.position + projectileSpanwLoc; // position it at player
            }
        }

        // Move player character left/right based on player input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Move player character up/down based on player input
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // If player hits boundries at top/bottom/left/right stop them from moving any further in the direction they are travelling
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
        }
        if (transform.position.z > zRangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
        }

    }
}
