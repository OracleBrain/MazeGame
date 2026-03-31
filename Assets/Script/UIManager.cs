using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    void Awake()
    {
        Canvas canvas = CreateCanvas();
        CreateTitleText(canvas);
        CreateInstructionsText(canvas);
    }

    private Canvas CreateCanvas()
    {
        GameObject canvasObject = new GameObject("GameCanvas");
        Canvas canvas = canvasObject.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 0;

        CanvasScaler scaler = canvasObject.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920, 1080);
        scaler.matchWidthOrHeight = 0.5f;

        canvasObject.AddComponent<GraphicRaycaster>();
        return canvas;
    }

    private void CreateTitleText(Canvas canvas)
    {
        GameObject titleObject = new GameObject("TitleText");
        titleObject.transform.SetParent(canvas.transform, false);

        TextMeshProUGUI titleText = titleObject.AddComponent<TextMeshProUGUI>();
        titleText.text = "Maze Game";
        titleText.fontSize = 48;
        titleText.fontStyle = FontStyles.Bold;
        titleText.color = Color.white;
        titleText.alignment = TextAlignmentOptions.Top;

        RectTransform rect = titleObject.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(0f, 1f);
        rect.anchorMax = new Vector2(1f, 1f);
        rect.pivot = new Vector2(0.5f, 1f);
        rect.anchoredPosition = new Vector2(0f, -20f);
        rect.sizeDelta = new Vector2(0f, 70f);
    }

    private void CreateInstructionsText(Canvas canvas)
    {
        GameObject instructionsObject = new GameObject("InstructionsText");
        instructionsObject.transform.SetParent(canvas.transform, false);

        TextMeshProUGUI instructionsText = instructionsObject.AddComponent<TextMeshProUGUI>();
        instructionsText.text = "Use WASD or Arrow Keys to Move";
        instructionsText.fontSize = 28;
        instructionsText.color = Color.white;
        instructionsText.alignment = TextAlignmentOptions.Bottom;

        RectTransform rect = instructionsObject.GetComponent<RectTransform>();
        rect.anchorMin = new Vector2(0f, 0f);
        rect.anchorMax = new Vector2(1f, 0f);
        rect.pivot = new Vector2(0.5f, 0f);
        rect.anchoredPosition = new Vector2(0f, 20f);
        rect.sizeDelta = new Vector2(0f, 50f);
    }
}
