using UnityEngine;
using System.Collections;

public class MoonController : Planet
{
    void Start()
    {
        radius = 3.0f;
        speed = 0.016f;
        target_tag = 5;
    }
}
