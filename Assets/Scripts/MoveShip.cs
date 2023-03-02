using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public int speed;
    public float minX, minY, maxX, maxY;
    public GameObject laserSpawner;
    public GameObject laserBeam;
    private float timer = 0;
    public float fireRate = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //Debug.Log("Horizontal values : " + horizontal + "vertical values : " + vertical);

        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal, vertical) * speed;
        float newX, newY;
        newX = Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, minX, maxX);
        newY = Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, minY, maxY);
        GetComponent<Rigidbody2D>().position = new Vector2(newX, newY);

        //Laser

        if (Input.GetAxis("Fire1") > 0 && timer > fireRate)
        {
            // Instiantiate: What do I instantiate? Where is it instantiated? What is its rotation?
            GameObject gObj;
            gObj = GameObject.Instantiate(laserBeam, laserSpawner.transform.position, laserSpawner.transform.rotation);
            gObj.transform.Rotate(new Vector3(0, 0, 90));
            timer = 0;

        }
        timer += Time.deltaTime;
        // Testing out GitKraken
    }
}
