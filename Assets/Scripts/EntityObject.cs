using UnityEngine;

public class EntityObject : Entity, IInteractable
{
    public void Interact(GameObject observer)
    {
        print(observer.name + "A interactuado conmigo");
    }
}
