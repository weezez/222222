using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class GravityInverter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp("d"))
        {
            MakeTheObjectsGoUp();
        }
        if (Input.GetKey("a"))
        {
            MakeTheObjectsGoDown();
        }
    }
    public void MakeTheObjectsGoUp()
    {
        Physics.gravity = new Vector3(0f, 10f, 0f);
    }
    public void MakeTheObjectsGoDown()
    {
        Physics.gravity = new Vector3(0f, -10f, 0f);
    }
}
