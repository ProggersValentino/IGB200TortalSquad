using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class RangerPlayerController : MonoBehaviour
{
    public PlayerInput playerInput;
    private InputAction movement;
    private Camera mainCam;

    public RangerNPC selectedNPC;

    //initial set up for when the player is enabled/ spawns in
    private void OnEnable()
    {
        mainCam = FindObjectOfType<Camera>();
        movement = playerInput.actions["Movement"];

        movement.performed += GetClickPos;
    }

    private void OnDestroy()
    {
        movement.performed -= GetClickPos;
    }

    private void OnDisable()
    {
        mainCam = null;
        movement.performed -= GetClickPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// when the player clicks this happens 
    /// </summary>
    /// <param name="context"></param>
    void GetClickPos(InputAction.CallbackContext context)
    {
        Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            //determine what we hit
            switch (hit.collider.GetComponent<MonoBehaviour>())
            {
                case RangerNPC ranger:
                    Debug.LogWarning($"this ranger is {ranger.gameObject.name}");
                    selectedNPC = ranger.SetRangerAsSelected();
                    break;
                case MicroTask taskToBeDone:
                    if(selectedNPC != null) selectedNPC.CompleteTask(taskToBeDone);
                    break;
                default:
                    selectedNPC = null;
                    Debug.LogWarning($"sadge nuithings");
                    Debug.LogWarning($"context {context.action}");
                    break;
            }
        }

    }
}
