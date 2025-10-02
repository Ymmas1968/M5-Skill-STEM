using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class Parabola : MonoBehaviour
{

    [SerializeField] Point point;
    int NumberOfPoints = 100;
    Vector2 minScreen, maxScreen;

    Quadraticfunction f;

    [SerializeField] public float a = 1;
    [SerializeField] public float b = 2;
    [SerializeField] public float c = 3;


    void Start()
    {
        minScreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint (new Vector2(Screen.width, Screen.height));

        float dx = (maxScreen.x - minScreen.x) / NumberOfPoints;

        f = new Quadraticfunction(1, 2, 3);

        for (int i = 0; i < NumberOfPoints; i++)
        {
            float x_pos = minScreen.x + i * dx;
            float y_pos = f.getY(x_pos);
            Point copyOfPoint = Instantiate(point);
            copyOfPoint.transform.position = new Vector3(x_pos, y_pos, 0);
        }
       
        
    }

    
    void Update()
    {
        
    }
}
