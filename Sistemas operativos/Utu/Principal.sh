#!/bin/bash


while :
do

clear
        echo "##### Menú ######"
        echo "# #"
        echo "# 1 - Crear directorios #"
        echo "# 2 - Respaldar directorios #"
        echo "# 3 - Respaldar base de datos#"
        echo "# 4 - Administrador de usuarios #"
        echo "# 5 - Salir #"
        echo "############################################"
        echo -e "\n"

        read -p "Ingrese una opcion: " opc


        case "$opc" in


        1)./menudir.sh
                ;;
        2) ./respaldar.sh
                ;;
        3) ./respaldarBD.sh
                ;;
        4) ./menu.sh
                ;;


        5) echo "Finalizando ..."

                sleep 5;

                clear                                                                                                                                                                                                                     
                exit

                ;;                                                                                                                                                                                                                                                                                                                                                                                                                                                                         *) echo "$opc no es una opcion valida"                                                                        
                echo "El programa va a finalizar"
                sleep 5;


                ;;

      esac

          done





"Principal.sh" 154L, 1730
