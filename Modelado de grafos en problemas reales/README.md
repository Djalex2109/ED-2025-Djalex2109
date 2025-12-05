# Tarea 1.2: Modelado de Grafos
## Información
- **Nombre:** Alexis Dueñez Maldonado, 23100155
- **Fecha:** 05/12/2025

---

# Ejercicio 3: Rutas de Transporte (Mi trayecto diario)

## a) Descripción del problema
Se modela la red de rutas que uso en la ciudad para desplazarme entre lugares habituales: Casa, Escuela, Trabajo, Centro Comercial, Gimnasio y Hospital.  
El grafo representa si existe una ruta directa (ida y vuelta) entre dos lugares (ej. línea de transporte, calle directa, etc.).

## b) Qué representa cada vértice
- **Casa**: Mi residencia.  
- **Escuela**: Centro educativo al que asisto.  
- **Trabajo**: Mi centro de trabajo.  
- **Centro Comercial**: Lugar de compras/ocio que visito frecuentemente.  
- **Gimnasio**: Donde hago ejercicio.  
- **Hospital**: Centro de salud cercano.

## c) Qué representa cada arista
Cada arista no dirigida `A — B` indica que existe una **ruta directa** entre el lugar A y el lugar B (transporte público o camino habitual), por lo que se puede viajar entre ambos sin pasar por un tercero.

Las aristas consideradas (rutas directas):
- Casa — Escuela  
- Casa — Centro Comercial  
- Casa — Trabajo  
- Escuela — Centro Comercial  
- Centro Comercial — Trabajo  
- Centro Comercial — Hospital  
- Trabajo — Gimnasio

## d) Diagrama del grafo


![Diagrama Rutas de Transporte](diagrama.png)


## e) Análisis: grados, conexidad, ciclos

### Vértices y aristas
- **V** = {Casa, Escuela, Trabajo, Centro Comercial, Gimnasio, Hospital} → **n = 6**  
- **E** = 7 aristas (lista arriba) → **m = 7**

### Lista de adyacencia
- Casa: Escuela, Centro Comercial, Trabajo  
- Escuela: Casa, Centro Comercial  
- Trabajo: Casa, Centro Comercial, Gimnasio  
- Centro Comercial: Casa, Escuela, Trabajo, Hospital  
- Gimnasio: Trabajo  
- Hospital: Centro Comercial

### Grados (grafo no dirigido)
| Lugar            | Grado |
|------------------|:-----:|
| Casa             | 3     |
| Escuela          | 2     |
| Trabajo          | 3     |
| Centro Comercial | 4     |
| Gimnasio         | 1     |
| Hospital         | 1     |

### ¿Es conexo?
Sí. El grafo es **conexo**: existe una ruta (posiblemente pasando por otros nodos) entre cualquier par de vértices.  
Ejemplo: Gimnasio → Trabajo → Centro Comercial → Escuela conecta Gimnasio con Escuela.

### Ciclos
Sí existen ciclos. Un ciclo simple es:
- **Casa — Escuela — Centro Comercial — Casa** (ciclo de longitud 3).

También hay otros ciclos más largos que incluyen Trabajo y Centro Comercial.

## f) Pregunta interesante y respuesta
**Pregunta:** ¿Cuál es el lugar más accesible desde el resto (mayor conectividad)?  
**Respuesta:** **Centro Comercial**, porque tiene el mayor grado (**4**) — conecta directamente con Casa, Escuela, Trabajo y Hospital. Es el nodo que maximiza accesibilidad y sirve como hub/local de intercambio.

---

## Extra: rutas cortas
- Camino más corto (en número de aristas) entre **Gimnasio** y **Escuela**:  
  Gimnasio — Trabajo — Centro Comercial — Escuela → **3 aristas**.  
  (También existe Gimnasio — Trabajo — Casa — Escuela con 3 aristas; hay empate en longitud.)

---

**Observaciones finales:**  
El grafo modela bien las ventajas de un hub (Centro Comercial) y permite analizar vulnerabilidades (por ejemplo, si el Centro Comercial queda inhabilitado, algunas rutas cortas se alargarían significativamente).

---


