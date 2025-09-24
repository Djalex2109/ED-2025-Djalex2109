import time

def fib_recursivo(n):
    if n <= 1:
        return n
    return fib_recursivo(n-1) + fib_recursivo(n-2)

def fib_iterativo(n):
    if n <= 1:
        return n
    a, b = 0, 1
    for _ in range(2, n + 1):
        a, b = b, a + b
    return b

def fib_memoization(n, memo={}):
    if n in memo:
        return memo[n]
    if n <= 1:
        memo[n] = n
    else:
        memo[n] = fib_memoization(n-1, memo) + fib_memoization(n-2, memo)
    return memo[n]

valores_n = [5, 10, 20, 30, 35]

print(f"{'n':<5}{'Fibonacci':<15}{'Recursivo (s)':<20}{'Iterativo (s)':<20}{'Diferencia':<15}")

for n in valores_n:
    inicio = time.perf_counter()
    fib_r = fib_recursivo(n)
    fin = time.perf_counter()
    tiempo_recursivo = fin - inicio

    inicio = time.perf_counter()
    fib_i = fib_iterativo(n)
    fin = time.perf_counter()
    tiempo_iterativo = fin - inicio

    assert fib_r == fib_i

    diferencia = abs(tiempo_recursivo - tiempo_iterativo)

    print(f"{n:<5}{fib_i:<15}{tiempo_recursivo:<20.8f}{tiempo_iterativo:<20.8f}{diferencia:<15.8f}")
