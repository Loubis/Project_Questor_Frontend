using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

[Serializable]
public class Quest
{

    public int id;
    public String setting;
    public String story;
    public int rating;
    public double duration;
    public String author;
    public Questmarker startPosition;

}
