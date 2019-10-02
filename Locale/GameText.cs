﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu]
public class GameText : ScriptableObject
{
    public List<TextVariation> TextVariations;

    public LocaleVariable CurrentLocale; 

    public string GetText() {
        var variation = TextVariations.FirstOrDefault(x => x.Locale == CurrentLocale.Value);
        Debug.Log(variation);
        return variation.Text ?? "";
    }

    [System.Serializable]
    public class TextVariation {
        public Locale Locale;
        public string Text;
    }
}