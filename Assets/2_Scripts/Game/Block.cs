using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private Sprite oSprite;
    [SerializeField] private Sprite xSprite;
    [SerializeField] private SpriteRenderer markerSpriteRenderer;

    //마커 타입
    public enum MarkerType { None, O, X }

    // Block Index
    private int _blockIndex;

    // 1. 초기화
    public void InitMarker(int blockIndex)
    {
        _blockIndex = blockIndex;
        SetMarker(MarkerType.None);
    }

    // 2. 마커 설정
    public void SetMarker(MarkerType markerType)
    {
        switch(markerType)
        {
            case MarkerType.None:
                markerSpriteRenderer.sprite = null;
                break;
            case MarkerType.O:
                markerSpriteRenderer.sprite = oSprite;
                break;
            case MarkerType.X:
                markerSpriteRenderer.sprite = xSprite;
                break;
        }
    }

    // 3. block 배경 색상 변경
    public void SetBlockColor(Color color)
    {

    }

}
