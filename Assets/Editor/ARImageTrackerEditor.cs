using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;

[CustomEditor(typeof(ARTrackedImageManager))]
public class ARImageTrackerEditor : Editor
{
    [SerializeField] private VisualTreeAsset visualTreeAsset;

    public override VisualElement CreateInspectorGUI()
    {
        var root = visualTreeAsset.CloneTree();
        
        return  root;
    }
}
