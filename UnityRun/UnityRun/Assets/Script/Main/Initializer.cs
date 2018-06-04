using UnityEngine;

public abstract class Initializer : BaseMonoBehaviour
{
    void Awake()
    {
        EarlyInitialize();
    }
    void Start()
    {

        Initialize();
    }

    public abstract void EarlyInitialize();
    public abstract void Initialize();
}
