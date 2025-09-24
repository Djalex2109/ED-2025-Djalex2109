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

tamanos = [1000, 10000, 50000]
repeticiones = 100_000

print(f"{'Tamaño':<10}{'Lineal (s)':<20}{'Binaria (s)':<20}{'Ratio L/B':<10}")

for n in tamanos:
    lista = list(range(n))
    existentes = [0, n//4, n//2, 3*n//4, n-1]
    no_existentes = [n+1, n+2, n+3, n+4, n+5]
    pruebas = existentes + no_existentes

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

    print(f"{n:<10}{tiempo_lineal:<20.10f}{tiempo_binaria:<20.10f}{ratio:<10.2f}")
