import time
import random

# Bubble Sort
def bubble_sort(lista):
    n = len(lista)
    for i in range(n):
        for j in range(0, n-i-1):
            if lista[j] > lista[j+1]:
                lista[j], lista[j+1] = lista[j+1], lista[j]
    return lista

# Dimensiones a probar
dimensiones_ordenamiento = [100, 500, 1000]

print("Tabla 2.1 - Tiempos de Ejecución por Dimensión")
print(f"{'Dimensión':<10}{'Bubble Sort (s)':<20}{'Merge Sort (s)':<20}{'Relación BS/MS':<15}")

for n in dimensiones_ordenamiento:
    lista = random.sample(range(n*10), n)  # n elementos únicos aleatorios
    
    # Bubble Sort
    inicio = time.perf_counter()
    resultado_bs = bubble_sort(lista.copy())
    fin = time.perf_counter()
    tiempo_bs = fin - inicio
    
    # Merge Sort (Python sorted)
    inicio = time.perf_counter()
    resultado_ms = sorted(lista)
    fin = time.perf_counter()
    tiempo_ms = fin - inicio
    
    # Verificar ordenación
    assert resultado_bs == resultado_ms, "Error: los resultados no coinciden"
    
    relacion = tiempo_bs / tiempo_ms if tiempo_ms != 0 else float('inf')
    print(f"{n:<10}{tiempo_bs:<20.8f}{tiempo_ms:<20.8f}{relacion:<15.2f}")

# Casos específicos para n=1000
print("\nTabla 2.2 - Comportamiento en Casos Específicos (n=1000)")
print(f"{'Escenario':<15}{'Bubble Sort (s)':<20}{'Merge Sort (s)':<20}{'Observaciones':<20}")

secuencia_ordenada = list(range(1000))
secuencia_inversa = list(range(1000, 0, -1))
secuencia_casi_ordenada = [x if x % 100 != 0 else x+500 for x in range(1000)]

escenarios = [("Ordenado", secuencia_ordenada),
              ("Inverso", secuencia_inversa),
              ("Casi ordenado", secuencia_casi_ordenada)]

for nombre, lista in escenarios:
    inicio = time.perf_counter()
    bubble_sort(lista.copy())
    fin = time.perf_counter()
    tiempo_bs = fin - inicio
    
    inicio = time.perf_counter()
    sorted(lista)
    fin = time.perf_counter()
    tiempo_ms = fin - inicio
    
    print(f"{nombre:<15}{tiempo_bs:<20.8f}{tiempo_ms:<20.8f}{'':<20}")
    
    print(f"{nombre:<15}{tiempo_bs:<20.8f}{tiempo_ms:<20.8f}{'':<20}")
