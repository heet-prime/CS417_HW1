using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public Transform XRRig;
    public Transform inside;
    public Transform outside;
    public InputActionReference action;

    private bool IsOut = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsOut = false;
        XRRig.position = inside.position;
        XRRig.rotation = inside.rotation;


        action.action.Enable();
        action.action.performed+= (ctx) =>
        {
            //Vector3 posChange = CameraOffset.position - XRRig.position;
            if (IsOut == false)
            {   
                XRRig.position = outside.position;
                XRRig.rotation = outside.rotation;
                IsOut = true;
            }
            else if(IsOut == true)
            {
                XRRig.position = inside.position;
                XRRig.rotation = inside.rotation;
                IsOut = false;
            }
        };
    }
}
