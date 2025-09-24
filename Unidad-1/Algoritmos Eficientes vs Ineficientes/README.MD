Algoritmos Eficientes vs Ineficientes
 
ALEXIS DUEÑEZ MALDONADO - 23100155 , EN COLABORACION CON  RICARDO RODRIGUEZ HERHANDEZ - 23100207

|Objetivo|
Comparar experimentalmente diferentes algoritmos y comprender cómo la complejidad algorítmica afecta el rendimiento en la práctica.

1-Comparación de Búsquedas (Lineal vs Binaria)
2-Comparación de Ordenamientos (Bubble Sort vs Python sorted)
3-Fibonacci Recursivo vs Iterativo

TABLA EJERCICIO 1
Tamaño    Lineal (s)          Binaria (s)         Ratio L/B 
1000      0.0000416452        0.0000015156        27.48     
10000     0.0004510529        0.0000020983        214.97    



TABLA EJERCICIO 2.1
Tabla 2.1 - Tiempos de Ejecución por Dimensión
Dimensión Bubble Sort (s)     Merge Sort (s)      Relación BS/MS 
100       0.00054239          0.00001732          31.31          
500       0.01322032          0.00007414          178.31         
1000      0.04861638          0.00016882          287.98      

TABLA EJERCICIO 2.2
Tabla 2.2 - Comportamiento en Casos Específicos (n=1000)
Escenario      Bubble Sort (s)     Merge Sort (s)      Observaciones       
Ordenado       0.02782807          0.00001486         bubble tarda mas que en Merge             
Inverso        0.07936441          0.00001657         bubble tarda mas que en el odenado                     
Casi ordenado  0.03715100          0.00002602         bubble mejora pero sigue siendo mas lento que Merge

TABLA EJERCICIO 3
n    Fibonacci      Recursivo (s)       Iterativo (s)       Diferencia     
5    5              0.00000400          0.00000299          0.00000101     
10   55             0.00001538          0.00000183          0.00001355     
20   6765           0.00187468          0.00000286          0.00187182     
30   832040         0.18616788          0.00000957          0.18615830     
35   9227465        1.88125657          0.00000763          1.88124894     
