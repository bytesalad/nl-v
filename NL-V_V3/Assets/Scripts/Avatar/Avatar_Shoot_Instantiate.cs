using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar_Shoot_Instantiate : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private float offsetMagnitude;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //first thing to do would be to calculate the offset vector
            //get the mouse location in world space
            Vector2 mouseVector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 avatarPosition = gameObject.GetComponent<Transform>().position;

            Vector2 joiningVector = mouseVector - avatarPosition;

            Vector2 unitDirVect = joiningVector / joiningVector.magnitude;

            //now multiply by the offset magnitude to get an offset for the instantiation

            Vector2 offset = unitDirVect * offsetMagnitude;

            //there we have it but now we must instantiate the projectile correctly and call the projectile's OnInstantiate method
            //also bear in mind that the projectile must rotate to face the direction of shooting it

            //we should seperate the 2nd and 3rd quadrants from the 1st and 4th:
            if (unitDirVect.x > 0)
            {
                Instantiate(projectilePrefab, avatarPosition + offset, Quaternion.Euler(0f, 0f, -90f + Mathf.Atan(unitDirVect.y / unitDirVect.x) * (360f / (2 * Mathf.PI))))
                .gameObject.GetComponent<Avatar_Projectile_Behaviour>().OnInstantiate(unitDirVect);
            }
            else
            {
                Instantiate(projectilePrefab, avatarPosition + offset, Quaternion.Euler(0f, 0f, 90f + Mathf.Atan(unitDirVect.y / unitDirVect.x) * (360f / (2 * Mathf.PI))))
                .gameObject.GetComponent<Avatar_Projectile_Behaviour>().OnInstantiate(unitDirVect);
            }
            //longest function ever!
            //To calculate the rotation, the arctan function is used with the x and y components of the unitDirVect. But this function returns
            //radians so it must be converted to degrees before it can be used as a parameter for the Quaternion.Euler function.
        }
    }
}
