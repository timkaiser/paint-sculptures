﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sc_popup_info : MonoBehaviour
{
    private static sc_popup_info instance; // singelton instance to avoid the doubeling of this script

    public GameObject popup_prefab;
    public GameObject drawing_canvas;

    private Dictionary<int, string> info_texts;

    // Start is called before the first frame update
    void Start()
    {
        // avoid doubeling of this script
        if (instance != null && instance != this) { Destroy(this.gameObject); } else { instance = this; }

        info_texts = new Dictionary<int, string>();
        info_texts[175] = "Mit einem Bart kennzeichneten die Griechen unabhänig von seinem tatsächlichen Aussehen einen älteren Mann und Familienvorstand.";
        info_texts[90] = "Die junge Frau ist im heiratsfähigen Alter, was an ihrem Schmuck zu erkennen ist.";
        info_texts[215] = "Im Giebelfeld steht der Name des Schusters. Übersetzt bedeutet er: xanthos = blond und hippos = Pferd, d. h. blondes Pferd.";
        info_texts[255] = "Der Giebel hält Regen vom oberen Teil des Reliefs ab und trägt dabei zur Haltbarkeit der ursprünglich bemalten Oberfläche bei.";
        info_texts[120] = "Der Chiton ist ein viereckiges Tuch, dass über den Schultern und den Oberarmen geknüft ist und mit einem Gürtel zusammengehalten wird.";
        info_texts[165] = "Der griechische Mantel, Himaton genannt, bestand aus einem viereckigen Tuch, welches um den Körper gewickelt wurde.";
        info_texts[105] = "Der Stuhl ist ein prächtiges und teures Möbelstück, dass den Wohlstand des Verstorbenen zeigt.";
        info_texts[75] = "Das Mädchen ist die Tochter des Verstorbenen. Ihre erhobenen Arme drücken Trauer aus.";
        info_texts[26] = "Der Schusterleisten weist auf den Beruf des Verstorbenen als Schuster hin.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void show_popup(int component_id)
    {
        if (info_texts.ContainsKey(component_id))
        {
            GameObject o = Instantiate(popup_prefab, drawing_canvas.transform);
            Text t = o.transform.Find("Text").GetComponent("Text") as Text;
            t.text = info_texts[component_id];
            GameObject.Destroy(o, 5);
        }
    }
}