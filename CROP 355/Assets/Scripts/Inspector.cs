using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Inspector : MonoBehaviour
{
    public TMP_FontAsset blockFont;
    public TMP_FontAsset decorativeFont;
    public TMP_FontAsset scriptFont;

    public GameObject fontColorSelectionDropdown;
    public GameObject panelColorSelectionDropdown;
    public GameObject fontSelectionDropdown;

    public GameObject imageButtonPanel;
    public GameObject textButtonPanel;
    public GameObject ingredientsButtonPanel;
    public GameObject nutritionFactsButtonPanel;
    public GameObject coloredPanelButtonPanel;

    public TextMeshProUGUI itemTypeLabel;
    public GameObject MainLayout;

    public GameObject selectedImage;
    public TextMeshProUGUI selectedText;
    public TextMeshProUGUI selectedIngredients;
    public GameObject selectedNutritionFacts;
    public GameObject selectedPanel;


    public void EmptySelection()
    {
        selectedImage = null;
        selectedText = null;
        selectedIngredients = null;
        selectedNutritionFacts = null;
        selectedPanel = null;
    }

    private void Start()
    {
        itemTypeLabel.text = "Inspector";
    }

    private void Update()
    {
        if (selectedImage == null && selectedText == null && selectedIngredients == null && selectedNutritionFacts == null && selectedPanel == null) itemTypeLabel.text = "Inspector";
        if (selectedText != null)
        {
            textButtonPanel.SetActive(true);
            imageButtonPanel.SetActive(false);
            ingredientsButtonPanel.SetActive(false);
            nutritionFactsButtonPanel.SetActive(false);
            coloredPanelButtonPanel.SetActive(false);
        }

        if (selectedImage != null)
        {
            textButtonPanel.SetActive(false);
            imageButtonPanel.SetActive(true);
            ingredientsButtonPanel.SetActive(false);
            nutritionFactsButtonPanel.SetActive(false);
            coloredPanelButtonPanel.SetActive(false);
        }

        if (selectedIngredients != null)
        {
            textButtonPanel.SetActive(false);
            imageButtonPanel.SetActive(false);
            ingredientsButtonPanel.SetActive(true);
            nutritionFactsButtonPanel.SetActive(false);
            coloredPanelButtonPanel.SetActive(false);
        }

        if (selectedNutritionFacts != null)
        {
            textButtonPanel.SetActive(false);
            imageButtonPanel.SetActive(false);
            ingredientsButtonPanel.SetActive(false);
            nutritionFactsButtonPanel.SetActive(true);
            coloredPanelButtonPanel.SetActive(false);
        }

        if (selectedPanel != null)
        {
            textButtonPanel.SetActive(false);
            imageButtonPanel.SetActive(false);
            ingredientsButtonPanel.SetActive(false);
            nutritionFactsButtonPanel.SetActive(false);
            coloredPanelButtonPanel.SetActive(true);
        }
    }

    // Text Methods

    public void ChangeFont()
    {
        var selectedFontString = fontSelectionDropdown.GetComponent<TMP_Dropdown>().value;
        switch (selectedFontString)
        {
            case 0:
                selectedText.GetComponent<TextMeshProUGUI>().font = blockFont;
                break;
            case 1:
                selectedText.GetComponent<TextMeshProUGUI>().font = scriptFont;
                break;
            case 2:
                selectedText.GetComponent<TextMeshProUGUI>().font = decorativeFont;
                break;
            default:
                selectedText.GetComponent<TextMeshProUGUI>().font = blockFont;
                break;
        }
    }


    public void IncreaseFontSize()
    {
        var currentTextSize = selectedText.GetComponent<TextMeshProUGUI>().fontSize;
        selectedText.GetComponent<TextMeshProUGUI>().fontSize = currentTextSize + 5f;
    }

    public void DecreaseFontSize()
    {
        var currentTextSize = selectedText.GetComponent<TextMeshProUGUI>().fontSize;
        selectedText.GetComponent<TextMeshProUGUI>().fontSize = currentTextSize - 5f;
    }

    public void SelectBlock()
    {
        selectedText.GetComponent<TextMeshProUGUI>().font = blockFont;
    }

    public void SelectScript()
    {
        selectedText.GetComponent<TextMeshProUGUI>().font = scriptFont;
    }

    public void SelectDecorative()
    {
        selectedText.GetComponent<TextMeshProUGUI>().font = decorativeFont;
    }

    public void RotateTextCCW()
    {
        selectedText.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 5));
    }

    public void RotateTextCW()
    {
        selectedText.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -5));
    }

    public void SendBack()
    {
        var i = selectedText.transform.GetSiblingIndex();
        if (i >= 1) selectedText.transform.SetSiblingIndex(i - 1);
    }

    public void SendFront()
    {
        var i = selectedText.transform.GetSiblingIndex();
        var count = MainLayout.transform.childCount;
        if (i < count) selectedText.transform.SetSiblingIndex(i + 1);
    }

    public void ChangeColor()
    {
        var selectedColor = fontColorSelectionDropdown.GetComponent<TMP_Dropdown>().value;
        switch (selectedColor)
        {
            case 0:
                selectedText.GetComponent<TextMeshProUGUI>().color = Color.black;
                break;
            case 1:
                selectedText.GetComponent<TextMeshProUGUI>().color = Color.white;
                break;
            case 2:
                selectedText.GetComponent<TextMeshProUGUI>().color = Color.blue;
                break;
            case 3:
                selectedText.GetComponent<TextMeshProUGUI>().color = new Color(0.5f, 0, 1, 1);
                break;
            case 4:
                selectedText.GetComponent<TextMeshProUGUI>().color = Color.red;
                break;
            case 5:
                selectedText.GetComponent<TextMeshProUGUI>().color = new Color(1, 0.5f, 0, 1);
                break;
            case 6:
                selectedText.GetComponent<TextMeshProUGUI>().color = Color.yellow;
                break;
            case 7:
                selectedText.GetComponent<TextMeshProUGUI>().color = Color.green;
                break;
            default:
                selectedText.GetComponent<TextMeshProUGUI>().color = Color.black;
                break;
        }
    }


    // Image 

    public void IncreaseImageSize()
    {
        var currentSize = selectedImage.GetComponent<RectTransform>().sizeDelta;
        selectedImage.GetComponent<RectTransform>().sizeDelta = currentSize * 1.1f;
    }

    public void DecreaseImageSize()
    {
        var currentSize = selectedImage.GetComponent<RectTransform>().sizeDelta;
        selectedImage.GetComponent<RectTransform>().sizeDelta = currentSize * 0.95f;
    }

    public void RotateImageCCW()
    {
        selectedImage.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 5));
    }

    public void RotateImageCW()
    {
        selectedImage.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -5));
    }

    public void SendImageBack()
    {
        var i = selectedImage.transform.GetSiblingIndex();
        if (i >= 1) selectedImage.transform.SetSiblingIndex(i - 1);
    }

    public void SendImageFront()
    {
        var i = selectedImage.transform.GetSiblingIndex();
        var count = MainLayout.transform.childCount;
        if (i < count) selectedImage.transform.SetSiblingIndex(i + 1);
    }


    // Ingredients

    public void IncreaseIngredientFontSize()
    {
        var currentTextSize = selectedIngredients.GetComponent<TextMeshProUGUI>().fontSize;
        selectedIngredients.GetComponent<TextMeshProUGUI>().fontSize = currentTextSize + 2f;
    }
    public void DecreaseIngredientFontSize()
    {
        var currentTextSize = selectedIngredients.GetComponent<TextMeshProUGUI>().fontSize;
        selectedIngredients.GetComponent<TextMeshProUGUI>().fontSize = currentTextSize - 2f;
    }

    public void IncreaseIngredientWidth()
    {
        var currentIngredientWidth = selectedIngredients.GetComponent<RectTransform>().sizeDelta;
        selectedIngredients.GetComponent<RectTransform>().sizeDelta = new Vector2(currentIngredientWidth.x+5, currentIngredientWidth.y);
    }

    public void DecreaseIngredientWidth()
    {
        var currentIngredientWidth = selectedIngredients.GetComponent<RectTransform>().sizeDelta;
        selectedIngredients.GetComponent<RectTransform>().sizeDelta = new Vector2(currentIngredientWidth.x - 5, currentIngredientWidth.y);
    }

    // Nutrition Facts
    public void IncreaseNutritionFactsSize()
    {
        var currentScale = selectedNutritionFacts.GetComponent<RectTransform>().localScale;
        selectedNutritionFacts.GetComponent<RectTransform>().localScale = currentScale * 1.05f;
    }

    public void DecreaseNutritionFactSize()
    {
        var currentScale = selectedNutritionFacts.GetComponent<RectTransform>().localScale;
        selectedNutritionFacts.GetComponent<RectTransform>().localScale = currentScale * 0.95f;
    }

    public void RotateNutritionFactsCW()
    {
        selectedNutritionFacts.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -5));
    }

    public void RotateNutritionFactsCCW()
    {
        selectedNutritionFacts.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 5));
    }
    public void SendNutritionFactsBack()
    {
        var i = selectedNutritionFacts.transform.GetSiblingIndex();
        if (i >= 1) selectedNutritionFacts.transform.SetSiblingIndex(i - 1);
    }

    public void SendNutritionFactsFront()
    {
        var i = selectedNutritionFacts.transform.GetSiblingIndex();
        var count = MainLayout.transform.childCount;
        if (i < count) selectedNutritionFacts.transform.SetSiblingIndex(i + 1);
    }

    // Panel
    public int panelDelta = 10;
    public void IncreasePanelWidth()
    {
        var rect = selectedPanel.GetComponent<RectTransform>();
        var currentSize = rect.sizeDelta;
        rect.sizeDelta = new Vector2(currentSize.x + panelDelta, currentSize.y);
    }

    public void DecreasePanelWidth()
    {
        var rect = selectedPanel.GetComponent<RectTransform>();
        var currentSize = rect.sizeDelta;
        rect.sizeDelta = new Vector2(currentSize.x - panelDelta, currentSize.y);
    }

    public void IncreasePanelHeight()
    {
        var rect = selectedPanel.GetComponent<RectTransform>();
        var currentSize = rect.sizeDelta;
        rect.sizeDelta = new Vector2(currentSize.x, currentSize.y + panelDelta);
    }

    public void DecreasePanelHeight()
    {
        var rect = selectedPanel.GetComponent<RectTransform>();
        var currentSize = rect.sizeDelta;
        rect.sizeDelta = new Vector2(currentSize.x, currentSize.y - panelDelta);
    }

    public void ChangePanelColor()
    {
        var selectedColor = panelColorSelectionDropdown.GetComponent<TMP_Dropdown>().value;
        switch (selectedColor)
        {
            case 0:
                selectedPanel.GetComponent<Image>().color = Color.black;
                break;
            case 1:
                selectedPanel.GetComponent<Image>().color = Color.white;
                break;
            case 2:
                selectedPanel.GetComponent<Image>().color = Color.blue;
                break;
            case 3:
                selectedPanel.GetComponent<Image>().color = new Color(0.5f, 0, 1, 1);
                break;
            case 4:
                selectedPanel.GetComponent<Image>().color = Color.red;
                break;
            case 5:
                selectedPanel.GetComponent<Image>().color = new Color(1, 0.5f, 0, 1);
                break;
            case 6:
                selectedPanel.GetComponent<Image>().color = Color.yellow;
                break;
            case 7:
                selectedPanel.GetComponent<Image>().color = Color.green;
                break;
            default:
                selectedPanel.GetComponent<Image>().color = Color.black;
                break;
        }
    }
    public void RotatePanelCW()
    {
        selectedPanel.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, -5));
    }

    public void RotatePanelCCW()
    {
        selectedPanel.GetComponent<RectTransform>().Rotate(new Vector3(0, 0, 5));
    }

    public void SendPanelBack()
    {
        var i = selectedPanel.transform.GetSiblingIndex();
        if (i >= 1) selectedPanel.transform.SetSiblingIndex(i - 1);
    }

    public void SendPanelFront()
    {
        var i = selectedPanel.transform.GetSiblingIndex();
        var count = MainLayout.transform.childCount;
        if (i < count) selectedPanel.transform.SetSiblingIndex(i + 1);
    }
}