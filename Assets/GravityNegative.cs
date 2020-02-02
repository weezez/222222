using UnityEngine;
using System.Collections;

public class GravityNegative : MonoBehaviour
{
    void Example()
    {
        Physics.gravity = new Vector3(0, -1.0F, 0);
    }
}