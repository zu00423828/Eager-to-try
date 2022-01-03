using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;





public class player : MonoBehaviour
{
    Rigidbody2D playerRigidbody2D;

    public Text Massage;
    public Button back;
    public GameObject explo;
    public Button stop;
    public Button con;
    public Button hurry;
    public Button nohurry;
    public Text q;


    [Header("目前的水平速度")]
    public float speedX;

    [Header("目前的水平方向")]
    public float horizontalDirection;//數值會在 -1~1之間

    const string HORIZONTAL = "Horizontal";

    [Header("水平推力")]
    [Range(0, 150)]
    public float xForce;

    //目前垂直速度
    float speedY;

    [Header("最大水平速度")]
    public float maxSpeedX;

    [Header("垂直向上推力")]
    public float yForce;

    [Header("感應地板的距離")]
    [Range(0, 0.5f)]
    public float distance;

    [Header("偵測地板的射線起點")]
    public Transform groundCheck;

    [Header("地面圖層")]
    public LayerMask groundLayer;
    [Header("地板")]
    public GameObject ground;
    public bool grounded;

    public void ControlSpeed()
    {
        speedX = playerRigidbody2D.velocity.x;
        speedY = playerRigidbody2D.velocity.y;
        float newSpeedX = Mathf.Clamp(speedX, -maxSpeedX, maxSpeedX);
        playerRigidbody2D.velocity = new Vector2(newSpeedX, speedY);
    }

    public bool JumpKey
    {
        get
        {
            return Input.GetKeyDown(KeyCode.UpArrow);
        }
    }

    void TryJump()
    {
        if (IsGround && JumpKey)
        {
            playerRigidbody2D.AddForce(Vector2.up * yForce);
            // ground.SetActive(false);        
        }
    }
      

    //在玩家的底部射一條很短的射線 如果射線有打到地板圖層的話 代表正在踩著地板
    bool IsGround
    {
        get
        {
            Vector2 start = groundCheck.position;
            Vector2 end = new Vector2(start.x, start.y - distance);

            Debug.DrawLine(start, end, Color.blue);
            grounded = Physics2D.Linecast(start, end, groundLayer);
            return grounded;
        }
    }

    void Start()
    {
        //yForce = 500;
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        back.onClick.AddListener(backclick);
        stop.onClick.AddListener(stopclick);
        con.onClick.AddListener(continueclick);
        hurry.onClick.AddListener(hurryupclick);
        nohurry.onClick.AddListener(nohurryclick);
    }

    /// <summary>水平移動</summary>
    void MovementX()
    {
        horizontalDirection = Input.GetAxis(HORIZONTAL);
        playerRigidbody2D.AddForce(new Vector2(xForce * horizontalDirection, 0));
    }

    void Update()
    {
        MovementX();
        ControlSpeed();
        TryJump();
        //speedX = playerRigidbody2D.velocity.x;

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == QandA.nonanswer)
        {
            Destroy(GameObject.FindGameObjectsWithTag("answer")[0]);
            Destroy(GameObject.FindGameObjectsWithTag("answer")[1]);
            gameObject.SetActive(false);
            Instantiate(explo, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            Massage.text = "GAMEOVER";
            stop.gameObject.SetActive(false);
            con.gameObject.SetActive(false);
            back.gameObject.SetActive(true);
            hurry.gameObject.SetActive(false);
            nohurry.gameObject.SetActive(false);
            if (PlayerPrefs.GetInt("hightscore") <= ScoreText.Score)
            {
                PlayerPrefs.SetInt("hightscore", ScoreText.Score);
                PlayerPrefs.Save();
            }

        }
        else if (collision.gameObject.name == QandA.answer)
        {
            Destroy(GameObject.FindGameObjectsWithTag("answer")[0]);
            Destroy(GameObject.FindGameObjectsWithTag("answer")[1]);
            ScoreText.instance.AddScore();
            ground.transform.localPosition = new Vector3(-0.034f, -0.735f, 0);
            if (choose.chooseindex != 0)
            {
                QandA.index++;
            }
            else
            {
                QandA.qa.random();
            }

        }
        else
        {
            if (PlayerPrefs.GetInt("hightscore") <= ScoreText.Score)
            {
                PlayerPrefs.SetInt("hightscore", ScoreText.Score);
                PlayerPrefs.Save();
            }
        }
        
    }
    static void backclick()
    {
        SceneManager.LoadScene("test");
        
    }
    void stopclick()
    {
        Time.timeScale = 0;
        stop.gameObject.SetActive(false);
        con.gameObject.SetActive(true);
        hurry.gameObject.SetActive(false);
        nohurry.gameObject.SetActive(false);
        q.gameObject.SetActive(false);
    }

    void continueclick()
    {
        Time.timeScale = 1;
        con.gameObject.SetActive(false);
        stop.gameObject.SetActive(true);
        hurry.gameObject.SetActive(true);
        nohurry.gameObject.SetActive(false);
        q.gameObject.SetActive(true);
    }
   
    void hurryupclick()
    {
        Time.timeScale = 5;
        hurry.gameObject.SetActive(false);
        nohurry.gameObject.SetActive(true);
    }

    void nohurryclick()
    {
        Time.timeScale = 1;
        hurry.gameObject.SetActive(true);
        nohurry.gameObject.SetActive(false);
    }
    
}
