using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField] GameObject thingToHide;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void test()
    {
        print("hej");
        thingToHide.SetActive(false);
    }
}
