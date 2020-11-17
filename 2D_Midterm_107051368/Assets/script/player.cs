using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{
    public GameObject exit;
    public Text textcount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("碰到傳送門");
        if (collision.name == "傳送門")
        {
            exit.SetActive(true);
        }

        if (collision.tag == "蘋果")
        {
            Destroy(collision.gameObject);
            count++;
            textcount.text = "蘋果數量:" + count;

        }
    }

}