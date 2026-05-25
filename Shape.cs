using UnityEngine;

public interface IColor
{
    void ApplyColor(Renderer renderer);
    string ColorName { get; }
}
