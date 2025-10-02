using UnityEngine;

public class JumpingBlock : MonoBehaviour
{
    [SerializeField] Transform Block;
    [SerializeField] Vector3 accelerationBegin;
    [SerializeField] Vector3 velocityBegin;

   [SerializeField] private float t = 0;

    Vector3 velocity;
    Vector3 acceleration;

    enum State { onGround, airBorne};
    private State myState = State.onGround;

    private float yMin;
    void Start()
    {
        yMin = Block.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (myState == State.onGround) 
        {
            velocity = Vector3.zero;
            acceleration = Vector3.zero;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myState = State.airBorne;
                velocity = velocityBegin;
                acceleration = accelerationBegin;
            }

        };

        if (myState == State.airBorne) 
        {
            t += Time.deltaTime;
            if (Block.position.y < yMin) 
            {
                myState = State.onGround;
                velocity = Vector3.zero;
                acceleration = Vector3.zero;
                Block.position = new Vector3(Block.position.x, yMin, Block.position.z);
            }
        };
        
        velocity += acceleration * Time.deltaTime;
        Block.position += velocity * Time.deltaTime;
    }
}
