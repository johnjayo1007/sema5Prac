from importlib.metadata import packages_distributions
from xml.etree.ElementTree import PI


def ejer1():
    edad =      int(input("Ingrese su edad: "))
    if edad > 130 or edad < 0:
        print("Esa edad no es valida")
    elif edad < 18:
        print ("Usted es Menor de edad")
    elif 18 <= edad <= 64:
        print ("Usted esta Adulto")
    else:
        print ("Usted es Adulto Mayor")

def ejer2():
    año = int(input("Ingrese el anio: "))

    if año % 4 == 0:
       if año % 100 == 0:
          if año % 400 == 0:
            print ("Es año bisiesto")
          else:
              print("No es Año bisiesto")
       else:
           print("Es Año bisiesto")
    else:
        print("No es Año bisiesto")

    if año % 2 == 0:
                print ("Es un año par")
    else:
                print("Es un año impar")

                 
def ejer3():
    monto = float(input("Ingrese un monto en Soles (PEN): "))
    print("¿Elige una opcion?")
    print(" (1) USD ")
    print(" (2) EUR ")
    print( " (3) Salir ")

    opcion = int(input("Eliga una opcion:  "))

    USD = monto/3.75
    EUR = monto/4.05

    match opcion:
        case 1:
            print(f"En dolares es: {USD:.2f}")
        case 2:
            print(f"En Euros es: {EUR:.2f}")
        case 3:
            print("Saliendo del programa")
        case _ :
            print("Opcion no valida")   


import math 

def ejer4():
    print("¿Que quieres realizar?")
    print("------ Seleccion de Areas ------")
    print("(1)Area del Cuadrado")
    print("(2)Area del Rectangulo")
    print("(3)Area del Triangulo")
    print("(4)Area del Circulo")
    opcion = int(input("Eliga una opcion:  "))

    match opcion:
        case 1:
            lado = float(input("Ingrese el Lado del cuadrado: "))
            areacua = lado*lado 
            print(f"El Area del Cuadrado es: {areacua:.2f}")
        case 2:
            base = float(input("Ingrese la base del rectangulo: "))
            alt = float(input("Ingrese la altura del rectangulo: "))
            arearect = base*alt
            print(f"El Area del rectangulo es: {arearect:.2f}")
        case 3:
            base = float(input("Ingrese la base del triangulo: "))
            alt = float(input("Ingrese la altura del triangulo: "))
            areatria = (base*alt)/2
            print(f"El Area del triangulo es: {areatria:.2f}")
        case 4:
            radio = float(input("Ingrese el Radio del Triangulo: "))
            areacirc = math.pi * (radio ** 2)
            print(f"El area del Circulo es: {areacirc:.2f}")
        case _ :
            print("La opcion no es valida")



ejer4()