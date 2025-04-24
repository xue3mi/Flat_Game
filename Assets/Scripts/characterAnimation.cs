using UnityEngine;
using UnityEngine.UIElements;

public class characterAnimation : MonoBehaviour
{

    public float totalTime = 1;
    [SerializeField] private float nowTime = 0;

    public SpriteRenderer spriteRenderer;
    public Sprite[] idle;
    public Sprite[] walkUp;
    public Sprite[] walkDown;
    public Sprite[] walkRight;
    public Sprite[] walkLeft;

    private int nowSprite = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAnimation(Vector2 direction)
    {
        if (direction.y > 0)
        {
            PlayAnimationFrames(walkUp);
        }
        else if (direction.y < 0)
        {
            PlayAnimationFrames(walkDown);
        }
        else if (direction.x > 0)
        {
            PlayAnimationFrames(walkRight);
        }
        else if (direction.x < 0)
        {
            PlayAnimationFrames(walkLeft);
        }
    }

    public void PlayIdleAnimation()
    {
        PlayAnimationFrames(idle);
    }

    private void PlayAnimationFrames(Sprite[] animationFrames)
    {
        nowTime += Time.deltaTime;
        if (nowTime >= totalTime)
        {
            nowSprite++;
            if (nowSprite >= animationFrames.Length) nowSprite = 0;
            spriteRenderer.sprite = animationFrames[nowSprite];
            nowTime = 0;
        }
    }

}
