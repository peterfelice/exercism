using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static Dictionary<string, string> translations = new Dictionary<string, string>()
    {
        {"AUG", "Methionine"},
        {"UUU","Phenylalanine"},
        {"UUC","Phenylalanine"},
        {"UUA", "Leucine"},
        {"UUG", "Leucine"},
        {"UCU","Serine"},
        {"UCC","Serine"},
        {"UCA","Serine"},
        {"UCG", "Serine"},
        {"UAU","Tyrosine"},
        {"UAC", "Tyrosine"},
        {"UGU","Cysteine"},
        {"UGC","Cysteine"},
        {"UGG","Tryptophan"},
        {"UAA","STOP"},
        {"UAG","STOP"},
        {"UGA","STOP"}
    };

    public static string[] Translate(string codon)
    {
        List<string> protiens = new List<string>();
        for (int i = 0; i < codon.Length; i += 3)
        {
            string currentCodon = codon.Substring(i, 3);

            if (!translations.ContainsKey(currentCodon))
            {
                throw new Exception();
            }

            string currentProtien = translations[currentCodon];
            if (currentProtien == "STOP")
            {
                break;
            }
            protiens.Add(currentProtien);
        }

        return protiens.ToArray();
    }
}