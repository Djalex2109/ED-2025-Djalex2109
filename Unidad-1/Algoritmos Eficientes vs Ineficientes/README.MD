# Algoritmos Eficientes vs Ineficientes

**Autores:**  
- Alexis Dueñez Maldonado - 23100155  
- Ricardo Rodriguez Hernandez - 23100207  

---

## Objetivo
Comparar experimentalmente diferentes algoritmos y comprender cómo la complejidad algorítmica afecta el rendimiento en la práctica.

Los experimentos realizados incluyen:  
1. Comparación de búsquedas: Lineal vs Binaria  
2. Comparación de ordenamientos: Bubble Sort vs Merge Sort  
3. Fibonacci: Recursivo vs Iterativo  

---

## Ejercicio 1: Comparación de Búsquedas

| Tamaño | Lineal (s)       | Binaria (s)       | Ratio L/B |
|--------|-----------------|-----------------|-----------|
| 1,000  | 0.0000416452    | 0.0000015156    | 27.48     |
| 10,000 | 0.0004510529    | 0.0000020983    | 214.97    |
| 50,000 | 0.0022868407    | 0.0000023299    | 981.53    |

---

## Ejercicio 2.1: Comparación de Ordenamientos (Tiempos de Ejecución por Dimensión)

| Dimensión | Bubble Sort (s) | Merge Sort (s) | Relación BS/MS |
|-----------|----------------|----------------|----------------|
| 100       | 0.00054239     | 0.00001732     | 31.31          |
| 500       | 0.01322032     | 0.00007414     | 178.31         |
| 1,000     | 0.04861638     | 0.00016882     | 287.98         |

---

## Ejercicio 2.2: Comportamiento en Casos Específicos (n = 1000)

| Escenario    | Bubble Sort (s) | Merge Sort (s) | Observaciones                               |
|-------------|----------------|----------------|--------------------------------------------|
| Ordenado    | 0.02782807     | 0.00001486     | Bubble Sort tarda más que Merge Sort       |
| Inverso     | 0.07936441     | 0.00001657     | Bubble Sort tarda más que en el ordenado   |
| Casi ordenado | 0.03715100   | 0.00002602     | Bubble Sort mejora, pero sigue siendo más lento que Merge |

---

## Ejercicio 3: Fibonacci Recursivo vs Iterativo

| n   | Fibonacci | Recursivo (s) | Iterativo (s) | Diferencia (s) |
|-----|-----------|----------------|----------------|----------------|
| 5   | 5         | 0.00000400     | 0.00000299     | 0.00000101     |
| 10  | 55        | 0.00001538     | 0.00000183     | 0.00001355     |
| 20  | 6,765     | 0.00187468     | 0.00000286     | 0.00187182     |
| 30  | 832,040   | 0.18616788     | 0.00000957     | 0.18615830     |
| 35  | 9,227,465 | 1.88125657     | 0.00000763     | 1.88124894     |
