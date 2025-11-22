using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 3;
        array[2] = 5;
        array[3] = 7;
        array[4] = 11;
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
