using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody _rb;

    private float _minSpeed = 12f;
    private float _maxSpeed = 16f;
    private float _maxTorque = 10f;
    private float _xRange = 4f;
    private float _ySpawnPos = 6f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();

        _rb.AddForce(RandomForce(), ForceMode.Impulse);
        _rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }

    Vector3 RandomForce(){
        return Vector3.up * Random.Range(_minSpeed, _maxSpeed);
    }

    float RandomTorque(){
        return Random.Range(-_maxTorque, _maxTorque);
    }

    Vector3 RandomSpawnPos(){
        return new Vector3(Random.Range(-_xRange, _xRange), -_ySpawnPos);
    }

    private void OnMouseDown() {
        Destroy(gameObject);    
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);    
    }
}