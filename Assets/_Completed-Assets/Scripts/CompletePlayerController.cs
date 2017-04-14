          using UnityEngine;
using System.Collections;

//Adding this allows us to access members of the UI namespace including Text.
using UnityEngine.UI;

public class CompletePlayerController : MonoBehaviour
{

    public float speed = 0.1f;              //Floating point variable to store the player's movement speed.
                                            //public Text countText;			//Store a reference to the UI Text component which will display the number of pickups collected.
                                            //public Text winText;			//Store a reference to the UI Text component which will display the 'You win' message.
    public GameObject stationRef;
    Vector2 stationRefPosition;
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    //assume receive input from DB as array of tracks
    public string[] dbtrack = new string[] { "12A01", "12A02", "12A03" };
	public Track track;
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        stationRef = GameObject.FindGameObjectWithTag("track");
		//Track trackref = stationRef.
        //var trackID = trackscript.;
		Debug.Log(stationRef);
        /*do
        {
            
            if(stationRef.ID)
            transform.position = Vector2.MoveTowards(transform.position, stationRef2[_CurrentTrack].transform.position, speed * Time.fixedDeltaTime);
            Debug.Log(transform.position);
            Debug.Log(stationRef2[_CurrentTrack].transform.position);
            Debug.Log(_CurrentTrack);
        } while (true);*/


    }

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void SetCountText()
    {

    }
}
