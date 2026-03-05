using UnityEngine;

public class ShowImage : MonoBehaviour
{
    public GameObject imageObject;

    public void ShowTheImage()
    {
        imageObject.SetActive(true);
    }
}
