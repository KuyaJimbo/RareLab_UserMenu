using UnityEngine;

public class stretch : MonoBehaviour
{
    public Transform cube1;
    public Transform cube2;

    void Update()
    {
        // Calculate the center position between cube1 and cube2
        Vector3 centerPosition = (cube1.position + cube2.position) / 2f;

        // Set the position of the stretchcube to the center position
        transform.position = centerPosition;

        // Calculate the distance between cube1 and cube2
        float distance = Vector3.Distance(cube1.position, cube2.position);

        // Set the scale of the stretchcube along the axis connecting cube1 and cube2
        transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, distance);

        // Rotate the stretchcube to align with the line between cube1 and cube2
        transform.LookAt(cube2.position);
    }
}
/*
This Unity script, named "stretch," adjusts the position, scale, and rotation of an object ("stretchcube")
based on the positions of two other objects ("cube1" and "cube2").

1. It calculates the center position between cube1 and cube2.
2. It sets the position of the stretchcube to the center position.
3. It calculates the distance between cube1 and cube2.
4. It sets the scale of the stretchcube along the axis connecting cube1 and cube2.
5. It rotates the stretchcube to align with the line between cube1 and cube2 using LookAt function.
6. Overall, this script effectively creates an object that stretches between two other objects and aligns itself with them.

Note: This script assumes that cube1, cube2, and stretchcube are assigned as public Transform variables in the Unity editor.
This also assumes that cube1 and cube2 have y-scale of 0, as the script only scales the stretchcube along the z-axis.
*/