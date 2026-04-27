using UnityEngine;

public interface IPckable
{
    bool KeepWorldPosition { get; }

    GameObject PickUp();
}
