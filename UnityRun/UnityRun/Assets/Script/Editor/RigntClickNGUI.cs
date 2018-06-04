using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RigntClickNGUI : Editor
{
    [MenuItem("GameObject/NGUI/Sprite", false, 6)]
    public static void AddSprite()
    {
        NGUIMenu.AddSprite();
    }

    [MenuItem("GameObject/NGUI/Label", false, 6)]
    public static void AddLabel()
    {
        NGUIMenu.AddLabel();
    }

    [MenuItem("GameObject/NGUI/Texture", false, 6)]
    public static void AddTexture()
    {
        NGUIMenu.AddTexture();
    }

    [MenuItem("GameObject/NGUI/Unity 2D Sprite", false, 6)]
    public static void AddSprite2D()
    {
        NGUIMenu.AddSprite2D();
    }

    [MenuItem("GameObject/NGUI/AddWidget", false, 6)]
    public static void AddWidget()
    {
        NGUIMenu.AddWidget();
    }
}
