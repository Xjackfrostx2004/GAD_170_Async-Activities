using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this class holds all the information for my variables activity
/// </summary>
public class Variables : MonoBehaviour
{
    #region Code neatness tutorial
    // this is a single line comment
    /* this is a multi line comment 
     * and i can keep writing here 
     * and here 
     * and close this off 
     */
    [Tooltip("This bool holds true or false")] // tooltip provides a message when we hover over a variable in our inspector
    public bool myFirstBool = true;

    [Header("Movement Related Variables")]// a header creates a heading in the untiy inspector
    public bool mySecondBool = false;

    [Space(20)] // space creates space in the unity inspector based on the number put in 
    public bool myThirdBool = false;
    #endregion

    #region all of my unity functions

    #region Data Types
    public int myFirstInt = 1; // an int holds whole numbers only
    public float myHeight = 166.5f; // a float holds decimal number values
    public double NepalGp = 180.87; // a double doubles the float value
    public string myFirstName = "Sandesh"; // a string holds words only
    public char myInitial = 'S'; // a char holds a single character only
    public bool isWearingAWatch = false; // a bool holds true or false


    #endregion

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
