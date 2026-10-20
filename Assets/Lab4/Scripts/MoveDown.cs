using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float enemySpeed = 5.0f;
    private Rigidbody enemyRb;
    private float zDestroy = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(Vector3.forward * -enemySpeed);

        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
