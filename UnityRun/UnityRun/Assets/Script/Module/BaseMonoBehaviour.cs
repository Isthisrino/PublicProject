using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BaseMonoBehaviour : MonoBehaviour
{
    public static Object ExInstantiate(Object Original, Transform Parent, bool WorldPositionStay)
    {
        GameObject Obj = Instantiate(Original, Parent, WorldPositionStay) as GameObject;
        return Obj;
    }

    public static T ExInstantiate<T>(T Original) where T : Object
    {
        return Instantiate<T>(Original);
    }

    public static void ExDestroy(GameObject DestroyObject, float DestroyTime = 0f)
    {
        if(null == DestroyObject)
        {
            return;
        }
        Destroy(DestroyObject, DestroyTime);
    }

    public Coroutine ExStartCoroutine(IEnumerator Routine)
    {
        return StartCoroutine(Routine);
    }

    public void ExStopCoroutine(string RoutineName)
    {
        StopCoroutine(RoutineName);
    }
    public void ExStopCoroutine(Coroutine Routine)
    {
        StopCoroutine(Routine);
    }

    public const byte RESET_POSITION = 0x01;
    public const byte RESET_ROTATION = 0x02;
    public const byte RESET_SCALE = 0x04;
    public const byte RESET_OFFSET = 0x08;

    public static void ExResetTransform(Transform Target, byte option = RESET_POSITION | RESET_ROTATION | RESET_SCALE | RESET_OFFSET)
    {
        if((option & RESET_POSITION) == RESET_POSITION)
        {
            Target.position = Vector3.zero;
        }
        if ((option & RESET_ROTATION) == RESET_ROTATION)
        {
            Target.localRotation = Quaternion.identity;
        }
        if ((option & RESET_SCALE) == RESET_SCALE)
        {
            Target.localScale = Vector3.one;
        }
        if ((option & RESET_OFFSET) == RESET_OFFSET)
        {
            RectTransform Rect = Target.GetComponent<RectTransform>();
            if(null != Rect)
            {
                Rect.anchorMin = Vector2.zero;
                Rect.anchorMax = Vector2.one;
                Rect.offsetMin = Vector2.zero;
                Rect.offsetMax = Vector2.one;
            }
        }
    }
}
