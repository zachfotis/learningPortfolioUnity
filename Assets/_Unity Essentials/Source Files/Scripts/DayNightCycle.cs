using UnityEngine;

public class DayNightCycle : MonoBehaviour {
    // This variable determines how many seconds it takes for a full day to pass
    [SerializeField] private float secondsPerDay = 120f; // Default to 2 minutes per day

    // Update is called once per frame
    void Update() {
        // Calculate the rotation speed based on the number of seconds per day
        float rotationSpeed = 360f / secondsPerDay;

        // Rotate the directional light around the X axis
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
