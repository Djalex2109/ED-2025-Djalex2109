## Ejercicio 2: Red de Computadoras 
<img width="825" height="602" alt="Image" src="https://github.com/user-attachments/assets/b6edaf30-406b-43ed-a465-d9b510bf70ef" />

### Representación
- Grafo **no dirigido**
- Representa conexiones físicas

### Vértices (8)
Router, Servidor, Switch1, Switch2, PC1, PC2, PC3, PC4, Impresora1, Impresora2  
(**Total real = 10**, según los dispositivos listados)

### Aristas (9)
Conexiones:  
Router–Servidor, Router–Switch1, Router–Switch2  
Switch1–PC1, Switch1–PC2, Switch1–Impresora1  
Switch2–PC3, Switch2–PC4, Switch2–Impresora2

➡ **Es conexo**: cualquiera puede comunicarse con todos

➡ **Es un árbol**:  
- Es conexo  
- No tiene ciclos  
- m = n – 1 (9 = 10 – 1)

### Dispositivo más crítico
- **Router**, porque si falla se separa toda la red en 2 grupos
