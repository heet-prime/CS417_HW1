using UnityEngine;

public class OrbitPlt : MonoBehaviour
{
    public float Rot_Speed = 35f;

    // Update is called once per frame
    void Update()
    {
        float rotate = Rot_Speed * Time.deltaTime;
        transform.Rotate(Vector3.up,rotate);
    }
}
