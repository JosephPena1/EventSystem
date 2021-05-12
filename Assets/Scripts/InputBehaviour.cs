using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    [SerializeField]
    private Event _onSpacePress;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            // The "?" checks if _onSpacePress is null
            _onSpacePress?.Raise(gameObject);
    }
}
