using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    [SerializeField]
    GameObject drawing_parent;

    [SerializeField]
    GameObject drawing_paint;

    Controls input;

    // Start is called before the first frame update
    void Start()
    {
        input = new Controls();
        input.Enable();

        InvokeRepeating("DrawObject", 0.0f, 0.1f);
    }

    void DrawObject()
    {
        if (input.Default.Draw.IsPressed())
        {
            var paint = Instantiate(drawing_paint);
            paint.transform.localPosition = transform.localPosition;

            paint.transform.parent = drawing_parent.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
