# Matriz con información de los títulos
# [Título, Año, Calificación, Género]

videoteca = [
    ["Inception", 2010, 9, "Ciencia Ficción"],
    ["Avatar", 2009, 8, "Acción"],
    ["Dune", 2021, 9, "Ciencia Ficción"],
    ["Encanto", 2021, 8, "Animación"],
    ["Oppenheimer", 2023, 10, "Drama"],
    ["The Batman", 2022, 8, "Acción"],
    ["Interstellar", 2014, 9, "Ciencia Ficción"]
]

# Función para contar títulos que cumplen los criterios
def contar_titulos(matriz, calificacion_minima, anio_limite):
    contador = 0

    for titulo in matriz:
        anio = titulo[1]
        calificacion = titulo[2]

        if calificacion >= calificacion_minima and anio >= anio_limite:
            contador += 1

    return contador

# Parámetros de búsqueda
calificacion_minima = 8
anio_limite = 2020

# Llamado de la función
resultado = contar_titulos(videoteca, calificacion_minima, anio_limite)

# Mostrar resultado
print("Cantidad de títulos que cumplen los criterios:", resultado)
