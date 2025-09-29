alumnos = []

while True:
    nombre = input("Ingresa el nombre del alumno (escribe 'Fin' para terminar): ")
    if nombre.strip().lower() == "fin":
        break
    alumnos.append(nombre)

print("\nLista de alumnos registrados:")
for alumno in alumnos:
    print(alumno)

print(f"\nTotal de alumnos registrados: {len(alumnos)}")
