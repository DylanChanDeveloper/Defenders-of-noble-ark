using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[ExecuteAlways]//script will now execute during play and edit mode
public class myCoOrdinateLabeler : MonoBehaviour
{
    TextMeshPro myLabel;
    Vector2Int myCoordinates = new Vector2Int();//using vector two int for representation of 2D vectors and points using integers.we are generating a vector by giving its components, we need to use new vector

    void Awake()//awake is the very first thing that will execute. meaning code encapsulated by the void awkae function will execute first.
    {
        myLabel = GetComponent<TextMeshPro>();//gets the textmeshpro component attached to this object and stores it in the myLabel variable
        CoordinateDisplay();//need to run the method in awake and update otherwise in play mode the method will break if we dont call it in awake
    }
    // Update is called once per frame
    void Update()
    {
        if (!Application.isPlaying)//means if the application is not playing run the methods below.
        {
            CoordinateDisplay();
            UpdateObjectName();
        }
    }

    void CoordinateDisplay()
    {
        myCoordinates.x = Mathf.RoundToInt(transform.parent.position.x / UnityEditor.EditorSnapSettings.move.x);//we encapuslate transform.parent.position.x because of a conversion error, mathf.roundtoint returns a float to a int.Are coordinates are in multiples of ten. dividing it by the unityeditor move x will give us the coordinates for the current location
        myCoordinates.y = Mathf.RoundToInt(transform.parent.position.z / UnityEditor.EditorSnapSettings.move.z);//we encapuslate transform.parent.position.x because of a conversion error, mathf.roundtoint returns a float to a int.

        myLabel.text = myCoordinates.x + "," + myCoordinates.y;//changes the text in the textmeshpro "mylabel" to the corodinates of my coordinates x and y
    }

    void UpdateObjectName()
    {
        transform.parent.name = myCoordinates.ToString();//the coordinates are in int and we need to convert it to a string with the to string method. we then update the string values and change the transform parent names to the coordinates
    }
}
