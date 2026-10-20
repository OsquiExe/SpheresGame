using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerLab4 : MonoBehaviour
{
    public float playerSpeed = 50;
    private Rigidbody playerRb;
    private InputSystem_Actions controls;

    void Awake()
    {
        controls = new InputSystem_Actions();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.AddForce(Vector3.forward * playerSpeed * Time.deltaTime);
        playerRb.AddForce(Vector3.left * playerSpeed * Time.deltaTime);
    }
}
