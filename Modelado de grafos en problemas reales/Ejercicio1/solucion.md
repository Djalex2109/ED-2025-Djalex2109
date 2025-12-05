- ## Ejercicio 1: Sistema de Vuelos
- <img width="658" height="402" alt="Image" src="https://github.com/user-attachments/assets/083761ae-87ea-4046-bacb-5ef932b1edb7" />
- ### Representación
- Grafo **dirigido** (los vuelos son solo ida)
- Grafo **ponderado** (hay costos asociados)

### Grados
| Ciudad     | Grado de Entrada | Grado de Salida |
|------------|------------------|-----------------|
| México     | 1                | 2               |
| Cancún     | 1                | 1               |
| Monterrey  | 1                | 1               |
| Houston    | 1                | 1               |
| Miami      | 2                | 1               |

➡ **Ciudad con más vuelos salientes:** México

### Ruta más barata de México → Miami
- Ruta: México → Cancún → Miami  
- Costo: **$1500 + $3500 = $5000**  
(Otra ruta: México → Monterrey → Houston → Miami = $5800)

### Ciclo existente
- México → Cancún → Miami → México



