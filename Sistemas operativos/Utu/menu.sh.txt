#!/bin/bash



while :
do

clear

        echo "##### PROGRAMA DE GESTION DE USUARIOS #####"
        echo "# #"
        echo "# 1 - Crear grupo #"
        echo "# 2 - Crear usuario #":
        echo "# 3 - Eliminar usuario #"
        echo "# 4 - Modificar usuario #"
        echo "# 5 - Salir #"
        echo "############################################"
        echo -e "\n"
        read -p "Ingrese una opcion: " opc


        case "$opc" in
                ## CASE sirve para comprobar el valor de una variable y ejecutar una porcion de codigo dependiendo de que valor sea
                #En este caso se comprueba el valor de opc , si es 1 2 o 3 se ejecuta el codigo correspondiente, si es otra opcion se ejecuta el codigo dentro de la opcion *


        1)./altagrupo.sh
                ;;
        2) ./usu.sh
                ;;
        3) ./elimiusu.sh
                ;;
        4) ./modiusu.sh
                ;;
        5) echo "Finalizando ..."
                sleep 5;

         exit
                ;;

        *) echo "$opc no es una opcion valida"
                echo "El programa va a finalizar"
                sleep 5;

                ;;




      esac                                                                                                                                                                                                                                             done