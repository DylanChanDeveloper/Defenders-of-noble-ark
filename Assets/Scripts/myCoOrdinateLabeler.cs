using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]//script will now execute during play and edit mode
public class myCoOrdinateLabeler : MonoBehaviour
{
    TextMeshPro myLabel;
    Vector2Int myCoordinates = new Vector2Int();

    void Awake()//awake is the very first thing that will execute. meaning code encapsulated by the void awkae function will execute first.
    {
        myLabel = GetComponent<TextMeshPro>();
        CoordinateDisplay();
    }
    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)
        {
            CoordinateDisplay();
            UpdateObjectName();
        }
    }

    void CoordinateDisplay()
    {
        myCoordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);
        myCoordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);

        myLabel.text = myCoordinates.x + "," + myCoordinates.y;
    }

    void UpdateObjectName()
    {
        transform.parent.name = myCoordinates.ToString();
    }
}
