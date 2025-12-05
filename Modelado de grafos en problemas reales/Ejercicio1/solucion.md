- ## Ejercicio 1: Sistema de Vuelos
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

![Diagrama del Sistema de Vuelos](Ejercicio1/Diagrama.png)

