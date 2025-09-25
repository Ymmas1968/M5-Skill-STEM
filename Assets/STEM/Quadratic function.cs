using UnityEngine;
using UnityEngine.Rendering;

public class Quadraticfunction
{
    public float a = 1;
    public float b = 1;
    public float c = 1; 

    public Quadraticfunction(float a, float b, float c) 
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public float getY(float x)
    {
        return (a*x*x + b*x + c);
    }
    
}
