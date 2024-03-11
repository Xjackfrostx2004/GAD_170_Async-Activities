using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// this class holds all the information for my variables activity
/// </summary>
public class Variables : MonoBehaviour
{
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
    #region all of my unity functions

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
