using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Transform target;  // The target object to orbit around
    public float speed = 10f; // Orbit speed
    public float noiseIntensity = 1f; // Intensity of the noise
    public float noiseFrequency = 1f; // Frequency of the noise

    private float noiseOffsetX;
    private float noiseOffsetZ;

    void Start()
    {
        // Initialize noise offsets
        noiseOffsetX = Random.Range(0f, 100f);
        noiseOffsetZ = Random.Range(0f, 100f);
    }

    void Update()
    {
        if (target != null)
        {
            // Add Perlin noise to the rotation
            float noiseX = Mathf.PerlinNoise(Time.time * noiseFrequency + noiseOffsetX, 0f) * 2 - 1;
            float noiseZ = Mathf.PerlinNoise(Time.time * noiseFrequency + noiseOffsetZ, 0f) * 2 - 1;

            Vector3 noise = new Vector3(noiseX, 0, noiseZ) * noiseIntensity;

            // Rotate around the target's position at a constant speed with added noise
            transform.RotateAround(target.position, Vector3.up, (speed + noise.magnitude) * Time.deltaTime);

            // Apply noise to the position to create a wiggly effect including the Z axis
            transform.position += noise * Time.deltaTime;
        }
    }
}
