using System.Drawing;
using UnityEngine;

public class CubeShape : Shape
{
    protected override void Awake()
    {
        base.Awake();
        ShapeName = "Cube";
    }

    public override void Render()
    {
        if (color != null && shapeRenderer != null)
            color.ApplyColor(shapeRenderer);

        Debug.Log($"[Bridge] Rendering Cube with color: {color?.ColorName}");
    }
}
