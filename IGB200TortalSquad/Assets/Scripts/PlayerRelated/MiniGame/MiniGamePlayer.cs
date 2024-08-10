using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MiniGamePlayer : MonoBehaviour
{

    public PlayerInput playerInput;
    private InputAction playerActons;

    public PlayerSO playerData;

    public float speed;

    public Camera mainCam;

    Vector3 MovementDirection;
    Vector3 targetPoint;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
        playerInput = GetComponent<PlayerInput>();
        playerActons = playerInput.actions["Movement"];

    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        Vector2 playerGeneralMovement = playerActons.ReadValue<Vector2>();
        transform.position += new Vector3(playerGeneralMovement.y, 0f, -playerGeneralMovement.x) * Time.deltaTime * 20;
    }
}
