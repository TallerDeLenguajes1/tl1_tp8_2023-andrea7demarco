﻿using System;

string path = @"c:\\taller\repo\tp8\tl1_tp8_2023-andrea7demarco"; //path de mi carpeta
List<string> archivos = Directory.GetFiles(path).ToList();

StreamWriter sw = new StreamWriter("index.csv");
int i = 1;

foreach (var archivo in archivos){
    //separado por comas 
    // 1c: índice, 2doc: nombre del archivo, 3erc: extensión del mismo 
    sw.WriteLine($"{i},{Path.GetFileNameWithoutExtension(archivo)},{Path.GetExtension(archivo)}");
    i += 1;
}

sw.Close();



