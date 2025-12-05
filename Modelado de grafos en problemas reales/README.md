# Tarea 1.2: Modelado de Grafos
## Información
- **Nombre:** Alexis Dueñez Maldonado, 23100155
- **Fecha:** 05/12/2025

---

## Ejercicio 3: Transporte que uso en la ciudad 

### Descripción
Grafo que modela las rutas que uso para ir a diferentes lugares:  
Escuela, Casa de un amigo, Trabajo, Centro comercial, Gimnasio y Hospital.

### Representación
- Vértices → lugares
- Aristas → existe una ruta directa entre los lugares

### Grados y análisis (ejemplo)
| Lugar               | Grado |
|--------------------|-------|
| Casa               | 3     |
| Escuela            | 2     |
| Trabajo            | 2     |
| Centro Comercial   | 3     |
| Gimnasio           | 1     |
| Hospital           | 1     |

➡ **Es conexo**  
➡ Tiene ciclos (ej: Casa → Escuela → Centro → Casa)

### Pregunta interesante
¿Cuál es el lugar más accesible?  
→ El **Centro Comercial**, porque tiene mayor grado.

📌 Diagrama del grafo:  
![Diagrama](ejercicio3/diagrama.png)

---

## Conclusiones
Los grafos permiten modelar sistemas reales como rutas, redes y conexiones.  
Nos ayudan a analizar accesibilidad, comunicación y eficiencia en sistemas.

---
