using UnityEngine;

public class PlanetOrbit : MonoBehaviour
{
    public Transform sun; // Reference to the sun object
    public float orbitSpeed = 10f; // Speed at which the planet orbits around the sun

    void Update()
    {
        // Ensure that the sun reference is set
        if (sun == null)
        {
            Debug.LogError("Sun reference is not set for " + gameObject.name);
            return;
        }

        // Orbit around the sun
        transform.RotateAround(sun.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}

