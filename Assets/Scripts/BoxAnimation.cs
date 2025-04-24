using UnityEngine;

public class BoxAnimation : MonoBehaviour
{
    public float totalTime = 1;
    [SerializeField]private float nowTime = 0;
    public SpriteRenderer spriteRenderer;
    public Sprite[] box_1;
    private int nowSprite = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        nowTime = nowTime + Time.deltaTime;
        if (nowTime >= totalTime)
        {
            //Debug.Log("Reset");
            nowSprite ++;
            spriteRenderer.sprite = box_1[nowSprite];
            nowTime = 0;
        }
        if (nowSprite == box_1.Length - 1)
        {
            nowSprite = 0;
        }
    }
}
