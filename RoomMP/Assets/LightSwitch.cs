using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed+= (ctx) => 
        {
            // changing the color at random allowing for multiple testings
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            light.color = new Color(r,g,b);
        };
    }
}
