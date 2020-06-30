#!/bin/bash

while :
do

clear

echo "################## Menú ####################"
echo "# #"
echo "# 1 - Eliminar directorios de medicos #"
echo "# 2 - Eliminar directorios de Administradores #"
echo "# 3 - Eliminar todos los directorios de usuarios #"
echo "# 4 - Eliminar directorios de afuera #"
echo "# 5 - Salir #"
echo "############################################"
echo -e "\n"

read -p "Ingrese una opcion: " opc



case "$opc" in



        1)
               cd Usuarios
                cd Medicos

                read -p "Ingrese la cantidad de directorios a borrar: " veces

        for (( c=0; c<$veces; c++ ))


                do


                read -p "Ingrese el nombre del directorio a eliminar: " dir

                rm -r -i -f  $dir

                echo "El directorio ah sido eliminado"
                        sleep 5;
                        clear

                                done
                ;;
        2)
                cd Usuarios
                cd Administradores
                read -p "Ingrese la cantidad de directorios a borrar: " veces

                for (( c=0; c<$veces; c++ ))

                do

                        read -p "Ingrese el nombre del directorio a eliminar: " dir

                        rm -r -i -f  $dir

                        echo "El directorio ah sido eliminado"
                        sleep 5;clear
                                done

                ;;
        3)
                cd Usuarios

                rm -r -i -f  Usuarios

                echo "El directorio ah sido eliminado"
                sleep 5;
                clear

                ;;
        4)  cd Usuarios

                cd Medicos
                read -p "Ingrese la cantidad de directorios a borrar: " veces
                for (( c=0; c<$veces; c++ ))

                do

                        read -p "Ingrese el nombre del directorio a eliminar: " dir

                        rm -r -i -f  $dir
                        echo "El directorio ah sido eliminado"
                        sleep 5;
                        clear
                done
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