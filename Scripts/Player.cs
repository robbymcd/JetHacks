using UnityEngine;
using System;

public class Player: MonoBehaviour
{
    public Rigidbody2D rb;
    public float upSpeed;
    public Animator animator;
    private Vector3 startPosition;

    void Update()
    {
        animator.SetFloat("Position", transform.position.y);



        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0)) {
            rb.AddForce(new Vector2(0, upSpeed));

        }
        
        
        //-4.719
        /*if (transform.position.y > 1){
            Debug.Log("Hello");
            //SpriteRenderer.Sprite = "Hero_walk_0001";
        }*/

    
    

        // Apply gravity and update the position

        /*
        // Tilt the bird based on the direction
        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;
        */
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Obstacle") {
            FindObjectOfType<GameManager>().GameOver();
        } 
    }
    /*
	Rigidbody2D body;
	
	public bool gameOver = false;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();s
	}
	
	void FixedUpdate () {
		if (gameOver) {
			
			if (Input.GetMouseButtonDown(0)) {
				SceneManager.LoadScene("Game");
			}
			return;
		}
		if (Input.GetMouseButton(0)) {
			body.AddForce(new Vector3(0, 50,0), ForceMode.Acceleration);
		} else if (Input.GetMouseButtonUp(0)) {
			body.velocity *= 0.25f;
		}
	}
	
	void OnTriggerEnter(Collider collider) {
		gameOver = true;
		body.isKinematic = true;
	}
    */













    //BELOW IS FROM FLAPPY BIRD
    //private SpriteRenderer spriteRenderer;
    //public Sprite[] sprites;
    //private int spriteIndex;

    /*
    public float strength = 5f;
    public float gravity = -9.81f;
    //public float tilt = 5f;
    */

    //private Vector3 direction;

    /*
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    */

    /*
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }
    */

    /*
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }
    */

    /*
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            direction = Vector3.up * strength;
        }

        // Apply gravity and update the position
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    */


        /*
        // Tilt the bird based on the direction
        Vector3 rotation = transform.eulerAngles;
        rotation.z = direction.y * tilt;
        transform.eulerAngles = rotation;
        */
    /*
    */
    
    
    /*
    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length) {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0) {
            spriteRenderer.sprite = sprites[spriteIndex];
        }
    }
    */
    
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle")) {
            FindObjectOfType<GameManager>().GameOver();
        } else if (other.gameObject.CompareTag("Scoring")) {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
    */
    

    //Explained
    /*


    private  Vector3 direction;    
    private float gravity = -9.8f;
    private float strength = 5f;

    //User input to play game
    private void Update(){

        //if user presses space key or left clicks on mouse, then direction go up
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            direction = Vector3.up * strength;
        }
    */

        /* FOR MOBILE COMPONENT
        // if more than one finger on screen
        if(Input.touchCount > 0){
            //we will only get the first touch, while ignore the rest
            Touch touch = Input.GetTouch(0)

            // i Just touched the screen, so the direction go up
            if(touch.phase == touchPhase.Began){
                direction = Vecotr3.up * strength
            }
        }
        */
    /*
        direction.y += gravity * Time.deltaTime;

        //Frame rate independent(not matter the frame rate of the game, its going to be consistent)
        transform.position += direction * Time.deltaTime;
    }
    */

}