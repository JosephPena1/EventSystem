using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    /// <summary>
    /// Turns the object on/off
    /// </summary>
    public void ToggleCube()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
