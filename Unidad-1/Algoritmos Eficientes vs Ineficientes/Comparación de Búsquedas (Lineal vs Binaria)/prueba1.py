# Ejercicio 1: Comparación de Búsquedas (Lineal vs Binaria)
import time

# Búsqueda Lineal O(n)
def busqueda_lineal(lista, objetivo):
    for i, valor in enumerate(lista):
        if valor == objetivo:
            return i
    return -1

# Búsqueda Binaria O(log n)
def busqueda_binaria(lista, objetivo):
    izquierda, derecha = 0, len(lista) - 1
    while izquierda <= derecha:
        medio = (izquierda + derecha) // 2
        if lista[medio] == objetivo:
            return medio
        elif lista[medio] < objetivo:
            izquierda = medio + 1
        else:
            derecha = medio - 1
    return -1

# Tamaño específico
n = 1000
lista = list(range(n))  # Lista ordenada de 0 a 999

# Elementos a buscar
existentes = [0, n//4, n//2, 3*n//4, n-1]  # 5 que sí existen
no_existentes = [n+1, n+2, n+3, n+4, n+5] # 5 que no existen
pruebas = existentes + no_existentes

# Medir tiempo búsqueda lineal
inicio = time.time()
for objetivo in pruebas:
    busqueda_lineal(lista, objetivo)
fin = time.time()
tiempo_lineal = (fin - inicio) / len(pruebas)

# Medir tiempo búsqueda binaria
inicio = time.time()
for objetivo in pruebas:
    busqueda_binaria(lista, objetivo)
fin = time.time()
tiempo_binaria = (fin - inicio) / len(pruebas)

# Mostrar resultados
print(f"Tamaño: {n}")
print(f"Búsqueda Lineal promedio (s): {tiempo_lineal:.8f}")
print(f"Búsqueda Binaria promedio (s): {tiempo_binaria:.8f}")
print(f"Ratio (Lineal / Binaria): {tiempo_lineal / tiempo_binaria:.2f}")
