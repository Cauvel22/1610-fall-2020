using UnityEngine;

public class Target : MonoBehaviour
{

    private Rigidbody _targetRb;
    private GameManager _gameManager;
    public int pointValue;
    public ParticleSystem explosionParticle;
    void Start()
    {
        _targetRb = GetComponent<Rigidbody>();
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _targetRb.AddForce(Vector3.up * Random.Range(12, 16), ForceMode.Impulse);
        _targetRb.AddTorque(Random.Range(-10, 10),Random.Range(-10, 10),Random.Range
        (-10, 10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4,4), -2);
    }
    private void OnMouseDown()
    {
        if (_gameManager.isGameActive)
        {
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position,
                explosionParticle.transform.rotation);
            _gameManager.UpdateScore(pointValue); 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (!gameObject.CompareTag("Bad"))
        {
            _gameManager.GameOver();
        }
    }
    
    
}
