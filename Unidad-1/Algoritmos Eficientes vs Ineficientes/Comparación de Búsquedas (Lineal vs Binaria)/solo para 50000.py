import time

def busqueda_lineal(lista, objetivo):
    for i, valor in enumerate(lista):
        if valor == objetivo:
            return i
    return -1

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

n = 50000
lista = list(range(n))
existentes = [0, n//4, n//2, 3*n//4, n-1]
no_existentes = [n+1, n+2, n+3, n+4, n+5]
pruebas = existentes + no_existentes

repeticiones = 1000  # reducido para que termine rápido

inicio = time.perf_counter()
for _ in range(repeticiones):
    for objetivo in pruebas:
        busqueda_lineal(lista, objetivo)
fin = time.perf_counter()
tiempo_lineal = (fin - inicio) / (len(pruebas) * repeticiones)

inicio = time.perf_counter()
for _ in range(repeticiones):
    for objetivo in pruebas:
        busqueda_binaria(lista, objetivo)
fin = time.perf_counter()
tiempo_binaria = (fin - inicio) / (len(pruebas) * repeticiones)

ratio = tiempo_lineal / tiempo_binaria if tiempo_binaria != 0 else float('inf')

print(f"Tamaño: {n}")
print(f"Búsqueda Lineal promedio (s): {tiempo_lineal:.10f}")
print(f"Búsqueda Binaria promedio (s): {tiempo_binaria:.10f}")
print(f"Ratio (Lineal / Binaria): {ratio:.2f}")
