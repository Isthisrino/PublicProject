using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSingleTon<T> : BaseMonoBehaviour where T : BaseMonoBehaviour
{
    protected static T _Instance = null;
    public static T Instance
    {
        get
        {
            if(null == _Instance)
            {
                GameObject Obj = new GameObject(typeof(T).ToString());
                Obj.AddComponent<T>();
                Obj.layer = (int)E_LAYER_INDEX.LAYER_SYSTEM;
            }
            return _Instance;
        }
    }
    void Awake()
    {
        SetInstance();
        ExAwake();
    }
    void Start()
    {
        ExStart();
    }
    void SetInstance()
    {
        _Instance = this as T;
    }
    protected virtual void ExAwake() { }
    protected virtual void ExStart() { }
}
