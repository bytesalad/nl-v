using UnityEngine;

public class InteractableObjects_ActivateProgramFile : MonoBehaviour
{
    [SerializeField] private GameObject programFile;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (programFile != null)
        {
            if (collision.gameObject.tag == "AvatarProjectile")
            {
                programFile.SetActive(true);
            }
        }
    }
}
