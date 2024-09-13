using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public float rotationSpeed;
    public GameObject onCollectEffect;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            // Destroy the collectible when the player collides with it.
            Destroy(gameObject);

            // Instantiate the onCollectEffect at the position of the collectible.
            Instantiate(onCollectEffect, transform.position, Quaternion.identity);
        }
    }
}
