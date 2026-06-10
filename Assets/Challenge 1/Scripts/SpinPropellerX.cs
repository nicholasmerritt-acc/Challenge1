using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 1600f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.forward);
    }
}
